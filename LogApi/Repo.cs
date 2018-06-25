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
            File.AppendAllText(@"c:\Logs\logapi.log", "text content" + Environment.NewLine);

        }
    }
}
