using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWriter_And_StringReader
{
    class StringReadWrite
    {
        StringBuilder sb = new StringBuilder();

        public StringReadWrite()
        {
            WriteData();
            ReadData();
        }
        #region "Read Data from StringBuilder"
        private void ReadData()
        {
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine("Reading the information....");

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");

            sr.Close();
        }
        #endregion
        #region "Write Date using StringWriter"
        private void WriteData()
        {
            StringWriter sw = new StringWriter(sb);
            Console.WriteLine("Please enter your first and last name..");
            string name = Console.ReadLine();
            sw.WriteLine("Name : " + name);
            sw.Flush();
            sw.Close();
        }
        #endregion


    }
}
