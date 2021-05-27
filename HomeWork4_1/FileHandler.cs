using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    class FileHandler
    {
        private static readonly string _fileName = "result.txt";

        public static async Task WriteToFile(List<Post> posts)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(_fileName, false))
                {
                    foreach (var post in posts)
                    {
                        await streamWriter.WriteLineAsync($"{post.UserId}\n{post.Id}\n{post.Title}\n{post.Body}\n");
                    }
                };
            }
            catch (Exception e)
            {
            }

        }
    }
}
  
