using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Component
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            InitAppAndDependencies();
        }

        [Fact]
        public async Task Test1()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:3000");
                var result = await httpClient.GetAsync("");
                Assert.True(result.IsSuccessStatusCode);
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
