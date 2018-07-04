using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EndToEnd.Request;
using Newtonsoft.Json;
using Xunit;

namespace EndToEnd
{
    public class Library
    {
        public Library()
        {
            InitAppAndDependencies();
        }

        [Fact]
        public async Task It_Adds_Book()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:3000");
                var request = new AddBookRequest { Author = "Bob", Title = "My Book" };
                var result = await httpClient.PostAsync("", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
                Assert.True(result.IsSuccessStatusCode);
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            }
        }

        private static void InitAppAndDependencies()
        {
            Console.WriteLine("Starting Application and Dependencies");

            var process = Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = $"{Directory.GetCurrentDirectory()}\\..\\..\\..",
                FileName = "start.bat"
            });

            process.WaitForExit();
            Assert.Equal(0, process.ExitCode);
        }

        private static void TearDownAppAndDependencies()
        {
            Console.WriteLine("Stopping Application and Dependencies");

            var process = Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = $"{Directory.GetCurrentDirectory()}\\..\\..\\..",
                FileName = "stop.bat"
            });

            process.WaitForExit();
            Assert.Equal(0, process.ExitCode);
        }
    }
}
