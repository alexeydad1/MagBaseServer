using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MagbaseServer
{
   public static class func
    {
      static  sqldb _SQl = new sqldb();

       

       public static String replace_date_sql(string datetime)
       {
           string date = datetime.Substring(6, 4) + "-" + datetime.Substring(3, 2) + "-" + datetime.Substring(0, 2);
           return date;
       }

       public static String between(string Original, string Findstring1, string Findstring2)
       {
           int lenOrig = Original.Length;
           int lenFind1 = Findstring1.Length;
           int lenFind2 = Findstring2.Length;

           int pos1 = Original.IndexOf(Findstring1);
           int pos2 = Original.IndexOf(Findstring2,pos1+1);

           string rString = Original.Substring(pos1+lenFind1, pos2 - pos1-lenFind1);

           return rString;
       }
      
    }
}
