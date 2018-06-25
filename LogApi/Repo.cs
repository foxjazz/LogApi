using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LogApi
{
    public class Repo
    {
        public static void writeLog(string str)
        {
            //File.AppendAllText(@"c:\Logs\logapi.log", "text content" + Environment.NewLine);
            //TextWriter writeFile = new StreamWriter(@"c:\Logs\logapi.log", str + Environment.NewLine);
            //string outputFile = @"c:\Logs\logapi.log";
            using (StreamWriter writer =
                new StreamWriter(dnow, true))
            {
                writer.WriteLine(str);
                writer.Flush();
            }

            

        }
        public static string dt { get; set; }
        public static string dnow { get; set; }
    }
}
