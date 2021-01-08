using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cmm_console_app
{
    public class TextReader
    {
        public StreamReader StreamReader { get; set; }

        public bool DefineStreamReader()
        {
            try
            {
                StreamReader = new StreamReader("/Users/jenev/source/repos/cover-my-meds/cmm-console-app/cmm-console-app/article.txt");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR connecting");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<string> ConvertTextFileToParagraphList(StreamReader stream)
        {
            List<string> paragraphList = new List<string>();
            using (stream)
            {
                string line;
                //while ((line = stream.ReadLine()) != null)
                //{
                //    paragraphList.Add(line.Trim());
                //}
                line = stream.ReadLine();
                paragraphList.Add(line);
            }
            return paragraphList;
        }

    }
}
