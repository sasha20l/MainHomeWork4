﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    class Program
    {
        static async Task Main()
        {
            int startId = 4;
            int endId = 13;
            var tasks = new List<Task<Post>>();

            // Создаем таски
            for (int id = startId; id <= endId; id++)
            {
                tasks.Add(HttpHandler.GetPostAsync(id));
            }
            try
            {
                var postsList = (await Task.WhenAll(tasks.Where(t => t.IsFaulted == false))).ToList();
                await FileHandler.WriteToFile(postsList);
            }
            catch (Exception e)
            {
            }
        }
    }
}
