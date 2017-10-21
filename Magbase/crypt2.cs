using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Xml;

namespace Security.Cryptography
{

    /// <summary>
    /// В классе собраны различные методы по шифрованию и расшифровыванию данных, проверки их контрольных 
    /// сумм, генерации ключей, векторов инициализаций и т.п.
    /// </summary>
    public static class XSecurity
    {
        /// <summary>
        /// Получение строкового значения MD5-хеша для файла.
        /// </summary>
        /// <param name="fileName">Имя файла, MD5-хэш которого необходимо получить</param>
        /// <returns>Строковое значение MD5-хэша</returns>
        //public static string GetFileMD5Hash(string fileName)
        //{
        //    if (!File.Exists(fileName))
        //        throw new FileNotFoundException(string.Format(Resource.FileNotFound, fileName));

        //    System.Security.Cryptography.MD5 x = System.Security.Cryptography.MD5.Create();
        //    byte[] data = null;
        //    using (FileStream fs = new FileStream(fileName, FileMode.Open))
        //    {
        //        data = x.ComputeHash(fs);
        //    }
        //    StringBuilder sBuilder = new StringBuilder();
        //    for (int i = 0; i < data.Length; i++)
        //        sBuilder.Append(data[i].ToString("x2"));

        //    return sBuilder.ToString();
        //}

        ///// <summary>
        ///// Получение строкового значения MD5-хеша для строки.
        ///// </summary>
        ///// <param name="text">строка, MD5-хэш которой необходимо получить</param>
        ///// <returns>Строковое значение MD5-хэша</returns>
        //public static string GetStringMD5Hash(string text)
        //{
        //    MD5 md5Hasher = MD5.Create();
        //    byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(text));

        //    StringBuilder sBuilder = new StringBuilder();
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        sBuilder.Append(data[i].ToString("x2"));
        //    }
        //    return sBuilder.ToString();
        //}

        /// <summary>
        /// Проверка того, соответствует ли MD5-хэш указанного файла тому MD5-хешу, строковое значение которого передаётся для сравнения
        /// </summary>
        /// <param name="fileName">Имя файла, MD5-хэш которого нужно проверить</param>
        /// <param name="md5hash">Строковое значение оригинального MD5-хеша</param>
        /// <returns>True - хеши совпадают. False - не совпадают</returns>
        //public static bool VerifyMd5Hash(string fileName, string md5hash)
        //{
        //    if (!File.Exists(fileName))
        //        throw new FileNotFoundException(Resource.FileNotFound, fileName);
        //    string hashOfInput = GetFileMD5Hash(fileName);

        //    StringComparer comparer = StringComparer.OrdinalIgnoreCase;
        //    if (0 == comparer.Compare(hashOfInput, md5hash))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        /// <summary>
        /// Сохранение массива байтов в файл. С помощью этого метода можно сохранять во
        /// внешний файл ключ симметричного шифрования или вектор инициализации.
        /// </summary>
        /// <param name="bytes">Массив байтов, которые необходимо сохранить в файл</param>
        /// <param name="keyFileName">Имя файла</param>
        public static void SaveBytesToFile(byte[] bytes, string keyFileName)
        {
            using (FileStream fs = new FileStream(keyFileName, FileMode.CreateNew, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Flush();
                fs.Close();
            }
        }
        /// <summary>
        /// Считывание массива байтов из файла. С помощью этого метода можно извлекать из
        /// внешнего файла ключ симметричного шифрования или вектор инициализации.
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Массив байтов</returns>
        public static byte[] GetBytesFromFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                fs.Close();
                return bytes;
            }
        }

        /// <summary>
        /// Генерация строки, которую можно использовать в качестве произвольного имени для файла
        /// </summary>
        /// <param name="byteSize">Размер в байтах</param>
        /// <returns>Сгенерированная строка</returns>
        public static string GenerateString(int byteSize)
        {
            byte[] bytes = new byte[255];
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            rand.GetBytes(bytes);
            return BitConverter.ToUInt64(bytes, 0).ToString("X");
        }

        /// <summary>
        /// Получение строкового представления массива байтов в формате шестнадцатеричных символов
        /// </summary>
        /// <param name="bytes">Массив байтов</param>
        /// <returns>Результат представлен в формате шестнадцатеричных символов</returns>
        public static string GetHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0x");
            foreach (byte item in bytes)
            {
                sb.Append(item.ToString("X"));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Получение строкового представления массива байтов в формате кодировки Base64
        /// </summary>
        /// <param name="bytes">Массив байтов</param>
        /// <returns>Результат представлен в формате кодировки Base64</returns>
        public static string GetBase64String(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Шифрование текстового файла симметричным ключом
        /// </summary>
        /// <param name="symmetricKey">Симметричный ключ</param>
        /// <param name="iv">Вектор инициализации</param>
        /// <param name="sourceFileName">Имя файла, содержимое которого требуется зашифровать</param>
        /// <param name="resultFileName">Имя файла, в котором должен быть сохранён результат шифрования. Задавая имя зашифрованному файлу, к его расширению добавьте суффикс '+' - это поможет визуально отличить зашифрованный файл от незашифрованного.</param>
        public static void EncriptingFile(byte[] symmetricKey, byte[] iv, string sourceFileName, string resultFileName)
        {
            using (FileStream unencryptedFile = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read))
            {
                using (FileStream encryptedFile = new FileStream(resultFileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    RijndaelManaged myAlg = new RijndaelManaged();
                    myAlg.Key = symmetricKey;
                    myAlg.IV = iv;
                    byte[] fileData = new byte[unencryptedFile.Length];
                    unencryptedFile.Read(fileData, 0, (int)unencryptedFile.Length);
                    ICryptoTransform encryptor = myAlg.CreateEncryptor();
                    using (CryptoStream encruptStream = new CryptoStream(encryptedFile, encryptor, CryptoStreamMode.Write))
                    {
                        encruptStream.Write(fileData, 0, (int)unencryptedFile.Length);
                        encruptStream.Flush();
                        encruptStream.Close();
                    }
                    encryptedFile.Close();
                }
                unencryptedFile.Close();
            }
        }

        /// <summary>
        /// Расшифровать текстовый файл симметричным ключом и сохранить результат в новом файле.
        /// </summary>
        /// <param name="symmetricKey">Симметричный ключ</param>
        /// <param name="iv">Вектор инициализации</param>
        /// <param name="sourceFileName">Имя зашифрованного файла</param>
        /// <param name="resultFileName">Имя файла, в котором должен быть сохранён расшифрованный результат</param>
        /// <param name="encoding">Кодировка, которую следует использовать</param>
        public static void DecryptingFile(byte[] symmetricKey, byte[] iv, string sourceFileName, string resultFileName, Encoding encoding)
        {
            using (FileStream unencryptedFile = new FileStream(resultFileName, FileMode.Create, FileAccess.Write))
            {
                using (FileStream encryptedFile = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read))
                {
                    //Создаём объект синхронного шифрования и назначаем ему ключ и вектор инициализации
                    RijndaelManaged myAlg = new RijndaelManaged();
                    myAlg.Key = symmetricKey;
                    myAlg.IV = iv;
                    //Создаём объект-дешифратор
                    ICryptoTransform unencryptor = myAlg.CreateDecryptor();
                    //Расшифровываем информацию и записываем её в новый файл
                    using (CryptoStream encruptStream = new CryptoStream(encryptedFile, unencryptor, CryptoStreamMode.Read))
                    {
                        //Read the stream.
                        StreamReader SReader = new StreamReader(encruptStream, encoding);
                        byte[] bytes = new byte[encryptedFile.Length];
                        StreamWriter sw = new StreamWriter(unencryptedFile);
                        sw.Write(SReader.ReadToEnd());
                        sw.Flush();
                        sw.Close();
                        SReader.Close();
                        encruptStream.Close();
                    }
                    encryptedFile.Close();
                }
                unencryptedFile.Close();
            }
        }

        /// <summary>
        /// Расшифровать текстовый файл симметричным ключом и сохранить результат в потоке MemoryStream.
        /// </summary>
        /// <param name="symmetricKey">Симметричный ключ</param>
        /// <param name="iv">Вектор инициализации</param>
        /// <param name="sourceFileName">Имя зашифрованного файла</param>
        /// <param name="encoding">Кодировка, которую следует использовать</param>
        /// <returns>Расшифрованные данные возвращаются в потоке</returns>
        public static MemoryStream DecryptingFileToStream(byte[] symmetricKey, byte[] iv, string sourceFileName, Encoding encoding)
        {
            MemoryStream ms = new MemoryStream();
            using (FileStream encryptedFile = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read))
            {
                //Создаём объект синхронного шифрования и назначаем ему ключ и вектор инициализации
                RijndaelManaged myAlg = new RijndaelManaged();
                myAlg.Key = symmetricKey;
                myAlg.IV = iv;
                //Создаём объект-дешифратор
                ICryptoTransform unencryptor = myAlg.CreateDecryptor();
                //Расшифровываем информацию и записываем её в виде потока
                using (CryptoStream encruptStream = new CryptoStream(encryptedFile, unencryptor, CryptoStreamMode.Read))
                {
                    StreamReader SReader = new StreamReader(encruptStream, encoding);
                    StreamWriter sw = new StreamWriter(ms);
                    string xxx = SReader.ReadToEnd();
                    sw.Write(xxx);
                    sw.Flush();
                    ms.Position = 0;
                    SReader.Close();
                    encruptStream.Close();
                }
                encryptedFile.Close();
            }
            return ms;
        }

        /// <summary>
        /// Зашифровать сразу целый массив файлов
        /// </summary>
        /// <param name="files">Массив файлов, которые необходимо зашифровать</param>
        /// <param name="symmetricKey">симметричный ключ шифрования</param>
        /// <param name="iv">вектор инициализации</param>
        /// <param name="removeSourceFile">Следует ли удалять оригинальный файл после того, как будет создана шифрованная версия файла</param>
        public static void EncryptingFiles(FileInfo[] files, byte[] symmetricKey, byte[] iv, bool removeSourceFile)
        {
            foreach (FileInfo item in files)
            {
                EncriptingFile(symmetricKey, iv, item.FullName, item.FullName + "+");
                if (removeSourceFile)
                    item.Delete();
            }
        }

        /// <summary>
        /// Расшифровать сразу целый массив файлов. Расшифрованные файлы записываются в тот же каталог под тем же именем (только у расширения файла убирается последний символ ("+")).
        /// </summary>
        /// <param name="files">Массив файлов, которые необходимо расшифровать</param>
        /// <param name="symmetricKey">симметричный ключ шифрования</param>
        /// <param name="iv">вектор инициализации</param>
        /// <param name="removeEncryptingFile">Следует ли удалять зашифрованный файл после того, как будет создана его расшифрованная версия</param>
        /// <param name="encoding">Кодировка файлов. Для xml-файлов это, как правило - UTF-8</param>
        public static void DecryptingFiles(FileInfo[] files, byte[] symmetricKey, byte[] iv, bool removeEncryptingFile, Encoding encoding)
        {
            foreach (FileInfo item in files)
            {
                DecryptingFile(symmetricKey, iv, item.FullName, item.FullName.Substring(0, item.FullName.Length - 1), encoding);
                if (removeEncryptingFile)
                    item.Delete();
            }
        }

        /// <summary>
        /// Зашифровать текст и сохранить его в файл
        /// </summary>
        /// <param name="text">Текстовая строка, которую следует зашифровать</param>
        /// <param name="fileName">Имя файла, который </param>
        /// <param name="key">Ключ шифрования</param>
        /// <param name="iv">Вектор инициализации</param>
        /// <param name="encoding">Кодировка символов</param>
        public static void EncryptTextToFile(String text, String fileName, byte[] key, byte[] iv, Encoding encoding)
        {
            // Создаём файловый поток
            FileStream fStream = new FileStream(fileName, FileMode.Create);
            // Создаём объект алгоритма шифрования
            Rijndael alg = Rijndael.Create();
            // Создаём поток шифрования, используя файловоый поток и ключ с инициализатором
            CryptoStream cStream = new CryptoStream(fStream,
                alg.CreateEncryptor(key, iv),
                CryptoStreamMode.Write);
            // Создаём объект для записи в символьный поток
            StreamWriter sWriter = new StreamWriter(cStream, encoding);
            // Записываем данные в поток, чтобы зашифровать их
            sWriter.WriteLine(text);
            sWriter.Flush();
            // Закрываем поток и файл
            sWriter.Close();
            cStream.Close();
            fStream.Close();
        }

        /// <summary>
        /// Зашифровать поток, содержащий в себе xml-элемент, во внешний файл
        /// </summary>
        /// <param name="stream">Поток, содержащий информацию, подлежащую шифрованию. Поток будет закрыт и уничтожен после считывания из него данных.</param>
        /// <param name="fileName">Имя файла, в который следует записать результат шифрования</param>
        /// <param name="key">Ключ шифрования</param>
        /// <param name="iv">Вектор инициализации</param>
        /// <param name="encoding">Кодировка символов</param>
        public static void EncryptingStreamToFile(Stream stream, string fileName, byte[] key, byte[] iv, Encoding encoding)
        {
            XElement xml = XElement.Load(XmlReader.Create(stream));
            EncryptTextToFile(xml.ToString(), fileName, key, iv, encoding);
            stream.Close();
            stream.Dispose();
        }
    }
}