using System;
using System.Collections.Generic;
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

            List<string> paragraphList = reader.ConvertTextFileToParagraphList(reader.StreamReader);
            foreach (string paragraph in paragraphList)
            {
                reader.AddLineWrapToParagraph(paragraph);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
