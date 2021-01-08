using System;
using System.IO;

namespace cmm_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TextReader reader = new TextReader();
            bool response = reader.DefineStreamReader();

            string textFile = reader.ConvertTextFileToString(reader.streamReader);
            // Console.WriteLine(textFile);
        }

    }
}
