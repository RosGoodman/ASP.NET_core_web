using Lesson_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        private static readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private static readonly HttpClient _client = new HttpClient();
        private const string _fileName = "result.txt";

        static void Main(string[] args)
        {
            try
            {
                List<string> postsStr = GetData().Result;

                File.WriteAllLinesAsync(_fileName, postsStr, _cts.Token);
                Console.WriteLine("Done!");
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                _cts.Dispose();
            }

            Console.ReadKey();
        }

        /// <summary>Получить данные нескольких постов.</summary>
        /// <returns>Список постов.</returns>
        private async static Task<List<string>> GetData()
        {
            var tasks = new List<Task<PostModel>>();
            List<string> postsStr = new List<string>();

            #region тут 10 запросов выполненных асинхронно

            //await Task.Run(() =>
            //{
            //    for (var i = 4; i <= 13; i++)
            //    {
            //        tasks.Add(GetPost(i));
            //    }
            //});

            //foreach (var task in tasks)
            //{
            //    var result = task.Result;
            //    postsStr.Add(result.UserId.ToString());
            //    postsStr.Add(result.Id.ToString());
            //    postsStr.Add(result.Title);
            //    postsStr.Add(result.Body);
            //    postsStr.Add(string.Empty);
            //}

            #endregion

            #region тут 10 асинхронных (каждый) запросов

            var tasks2 = new List<PostModel>();

            for (var i = 4; i <= 13; i++)
            {
                var responce = await Task.Run(() => GetPost(i));
                tasks2.Add(responce);
            }

            foreach (var task in tasks2)
            {
                postsStr.Add(task.UserId.ToString());
                postsStr.Add(task.Id.ToString());
                postsStr.Add(task.Title);
                postsStr.Add(task.Body);
                postsStr.Add(string.Empty);
            }

            #endregion

            return postsStr;
        }

        /// <summary>Получить данные поста по id.</summary>
        /// <param name="id">id поста.</param>
        /// <returns>Результат.</returns>
        private static async Task<PostModel> GetPost(int id)
        {
            string url = $"https://jsonplaceholder.typicode.com/posts/{id}";
            PostModel postModel = new PostModel();

            try
            {
                HttpResponseMessage httpResponse = await _client.GetAsync(url, _cts.Token);
                httpResponse.EnsureSuccessStatusCode();

                string responseStr = await httpResponse.Content.ReadAsStringAsync(_cts.Token);
                postModel = JsonSerializer.Deserialize<PostModel>(responseStr);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
            }

            return postModel;
        }
    }
}
