//**********************************************************************************
//* �e���v���[�g
//**********************************************************************************

// �T���v�����̃e���v���[�g�Ȃ̂ŁA�K�v�ɉ����Ďg�p���ĉ������B

//**********************************************************************************
//* �N���X��        �FProgram
//* �N���X���{�ꖼ  �FProgram
//*
//* �쐬����        �F�|
//* �쐬��          �F�|
//* �X�V����        �F�|
//*
//*  ����        �X�V��            ���e
//*  ----------  ----------------  -------------------------------------------------
//*  20xx/xx/xx  �w�w �w�w         �w�w�w�w
//**********************************************************************************

using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FrontendHost
{
    /// <summary>Program</summary>
    public class Program
    {
        /// <summary>
        /// Main�i�G���g���|�C���g�j</summary>
        /// <param name="args">�R�}���h���C������</param>
        public static void Main(string[] args)
        {
            // BuildWebHost���Ԃ�IWebHost��Run����B
            // �Ăяo�����X���b�h�͏I���܂Ńu���b�N�����B
            Program.CreateHostBuilder(args).Build().Run();
        }

        /// <summary>CreateHostBuilder</summary>
        /// <param name="args">�R�}���h���C������</param>
        /// <returns>IWebHost</returns>
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
