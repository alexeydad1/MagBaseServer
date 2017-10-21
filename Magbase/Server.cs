using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Threading;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace MagbaseServer
{
   public class Server
    {
        public DataTable dt = new DataTable();
        //public delegate void AddMessageDelegate(string message);
        public TcpListener server = null;
        public int flagsql = 0;
        public int counter = 0;
        logger _Log = new logger();
        public void run_server()
        {
            server = null;
            try
            {
                // Определим нужное максимальное количество потоков
                // Пусть будет по 4 на каждый процессор
                int MaxThreadsCount = 1;// один поток для одного запроса и нет проблем))))ОШИБКА ЗАКРЫТИЯ КОННЕКТА РАНЬШЕ ВРЕМЕНИ большое число потоков 
                //int MaxThreadsCount = Environment.ProcessorCount * 4;
                
                // Установим максимальное количество рабочих потоков
                ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
                // Установим минимальное количество рабочих потоков
                ThreadPool.SetMinThreads(MaxThreadsCount, MaxThreadsCount);
                //ThreadPool.SetMinThreads(2, 2);
                //int nWorkerThreads;
                //int nCompletionThreads;
                //ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionThreads);
                //Debug.WriteLine("Максимальное количество потоков: {0}\nПотоков ввода-вывода доступно: {1}", nWorkerThreads, nCompletionThreads);
                // Устанавливаем порт для TcpListener = 34567.
                IPAddress ipAddr = IPAddress.Parse(Sform.ServerIP); //IPAddress.Parse("25.102.117.164");
                Int32 Port = Convert.ToInt32(Sform.ServerPort);//34567;
                
                server = new TcpListener(ipAddr, Port);
                // Запускаем TcpListener и начинаем слушать клиентов.
                server.Start();
                
                // Принимаем клиентов в бесконечном цикле.
                while (true)
                {
                    
                    //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Ожидаем подключения\n\n" });
                    // При появлении клиента добавляем в очередь потоков его обработку.
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ObrabotkaZaprosa), server.AcceptTcpClient());
                    
                    // Выводим информацию о подключении.
                    counter++;
                    //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Клиент №" + counter.ToString() + "!\n\n" });

                }
            }
            catch (SocketException e)
            {
                _Log.logwrite("Ошибка запуска сервера: " + Environment.NewLine + e.Message, e);
                //В случае ошибки, выводим что это за ошибка.
                MessageBox.Show("SocketException: " + e);
                //Invoke(new AddMessageDelegate(LogAdd), new object[] { "SocketException: " + e });

            }
            finally
            {
                // Останавливаем TcpListener.
                server.Stop();
            }

        }
        public void ObrabotkaZaprosa(object client_obj)
        {
            //Можно раскомментировать Thread.Sleep(1000); 
            //Запустить несколько клиентов
            //и наглядно увидеть как они обрабатываются в очереди. 
           
            
            //Thread.Sleep(100);
            //Encoding cp1251 = Encoding.GetEncoding(1251);
            using (TcpClient client = client_obj as TcpClient)
            {
                
                string ipClient = client.Client.RemoteEndPoint.ToString();
                
                //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Клиент подключился!\nАдрес клиента: " + ipClient + "\n\n" });

                using (NetworkStream readerStream = client.GetStream())
                {// поток для чтения из сети

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (BinaryWriter bw = new BinaryWriter(ms))
                        {
                            BinaryFormatter outformat = new BinaryFormatter();
                            int count;
                            count = int.Parse(outformat.Deserialize(readerStream).ToString());//Получаем размер файла/сообщения
                            //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Размер сообщения " + count + "\n\n" });

                            int i = 0;
                            for (; i < count; i += 1024)//Цикл пока не дойдём до конца файла
                            {

                                byte[] buf = (byte[])(outformat.Deserialize(readerStream));//Собственно читаем из потока и записываем в файл/память
                                bw.Write(buf);
                            }

                            //ms.SetLength(count);
                            long d = ms.Length;
                            byte[] queryByte = ms.ToArray();
                            string sqlquery = Encoding.UTF8.GetString(queryByte);
                            int lenSQl = sqlquery.Length;
                            //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Сообщение принято!\n" + sqlquery + "\nразмер сообщения " + lenSQl + "\n\n" });

                            string sqlqueryUpper = sqlquery.ToUpper();
                            //Debug.WriteLine("адрес клиента {0} номер {1}", ipClient, counter);
                            //Debug.WriteLine(Environment.NewLine + "Поток номер {0}" + Environment.NewLine + "запрос:{1}" + Environment.NewLine, Thread.CurrentThread.ManagedThreadId, sqlqueryUpper);
                            
                            if (sqlqueryUpper.IndexOf("SELECT", 0, 6) == -1)
                            {
                                sql_from_base(sqlquery);
                                if (sqlqueryUpper.IndexOf("INSERT INTO BLOCKT") == 0)
                                {
                                    BinaryFormatter format = new BinaryFormatter();
                                    byte[] bufout = new byte[1024];

                                    MemoryStream msout = new MemoryStream(GetBinaryFormatData(dt));
                                    BinaryReader br = new BinaryReader(msout);
                                    int k = flagsql;//Размер сообщения
                                    //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Размер сообщения " + k + "\n\n" });

                                    format.Serialize(readerStream, k.ToString());//Вначале передаём размер
                                    //client.Close();
                                }
                            }
                            else
                            {
                                sql_from_base_select(sqlquery);
                                ////отправка Datatable dt
                                BinaryFormatter format = new BinaryFormatter();
                                byte[] bufout = new byte[1024];
                                int countOut;

                                MemoryStream msout = new MemoryStream(GetBinaryFormatData(dt));
                                BinaryReader br = new BinaryReader(msout);
                                long k = msout.Length;//Размер сообщения
                                //Invoke(new AddMessageDelegate(LogAdd), new object[] { "Размер сообщения " + k + "\n\n" });

                                format.Serialize(readerStream, k.ToString());//Вначале передаём размер
                                while ((countOut = br.Read(bufout, 0, 1024)) > 0)
                                {
                                    format.Serialize(readerStream, bufout);//А теперь в цикле по 1024 байта передаём сообщение
                                }

                                //client.Close();
                            }

                        }
                    }
                }
                //Debug.WriteLine(Environment.NewLine + "адрес клиента {0} номер {1},закрыл соеденение", ipClient, counter);
            }
            
        }
        public byte[] GetBinaryFormatData(DataTable dt)
        {
            BinaryFormatter bFormat = new BinaryFormatter();
            byte[] outList = null;
            dt.RemotingFormat = SerializationFormat.Binary;
            using (MemoryStream ms = new MemoryStream())
            {
                bFormat.Serialize(ms, dt);
                outList = ms.ToArray();
            }
            return outList;
        }
        public void sql_from_base_select(string query)
        {
            sqldb _SQL = new sqldb();
            dt = _SQL.ExecuteSQL_CL(query);
        }
        public void sql_from_base(string query)
        {
            sqldb _SQL = new sqldb();
            _SQL.SQL_Query_CL(query);
            flagsql=_SQL.uniqBlockTCL;
        }
    }
}
