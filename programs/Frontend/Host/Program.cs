using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FrontendHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                	string url = Environment.GetEnvironmentVariable("UseUrl");
                    if (string.IsNullOrEmpty(url))
                    {
                        url = "http://0.0.0.0:5000/";
                    }

                    webBuilder//.UseStartup<Startup>();
                        .UseStartup<Startup>() // IWebHostBuilder.UseStartup<TStartup> ���\�b�h��Startup�N���X���w��B
                        .UseUrls(url); // �g�p����v���g�R���ƃ|�[�g�����肷��B
                });
    }
}
