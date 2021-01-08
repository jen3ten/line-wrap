using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cmm_console_app
{
    public class TextReader
    {
        public StreamReader streamReader { get; set; }

        public bool DefineStreamReader()
        {
            try
            {
                streamReader = new StreamReader("/Users/jenev/source/repos/cover-my-meds/cmm-console-app/cmm-console-app/article.txt");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR connecting");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public string ConvertTextFileToString(StreamReader stream)
        {
            string textString = "";
            using (stream)
            {
                string[] paragraphs;
                paragraphs = stream.ReadToEnd().Split(new[] { '\r', '\n' });
                foreach(string line in paragraphs)
                {
                    //textString += line + " ";
                    Console.WriteLine(line);
                }

                return textString;
            }
        }

    }
}
