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
                string paragraph = "";
                bool continueRead = true;
                do
                {
                    paragraph += stream.ReadLine();
                    if (stream.Peek() == 13) // if the next character is a carriage return, consume it and continue to read next line
                    {
                        stream.Read(); // consume the carriage return
                        paragraph += " ";  // replace carriag return with a space
                    }
                    else if (stream.Peek() == 32) // if the next character is a space, it exists between paragraphs
                    {
                        stream.ReadLine();  // consume the next space and carriage return
                        paragraphList.Add(paragraph); // add the string as a separate paragraph to the paragraph list
                        paragraph = "";
                    }
                    else if (stream.Peek() == -1)
                    {
                        continueRead = false;
                    }
                } while (continueRead);
            }
            return paragraphList;
        }

    }
}
