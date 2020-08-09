//**********************************************************************************
//* テンプレート
//**********************************************************************************

// サンプル中のテンプレートなので、必要に応じて使用して下さい。

//**********************************************************************************
//* クラス名        ：Program
//* クラス日本語名  ：Program
//*
//* 作成日時        ：－
//* 作成者          ：－
//* 更新履歴        ：－
//*
//*  日時        更新者            内容
//*  ----------  ----------------  -------------------------------------------------
//*  20xx/xx/xx  ＸＸ ＸＸ         ＸＸＸＸ
//**********************************************************************************

using System;
using System.Net.Http;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using Touryo.Infrastructure.Framework.Authentication;

namespace ASPNETWebServiceCore
{
    /// <summary>Program</summary>
    public class Program
    {
        /// <summary>
        /// Main（エントリポイント）</summary>
        /// <param name="args">コマンドライン引数</param>
        public static void Main(string[] args)
        {
            // JwkSet取得用
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                OAuth2AndOIDCClient.HttpClient = new HttpClient();
            }
            else
            {
                //OAuth2AndOIDCClient.HttpClient = new HttpClient();

                // 暫定
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback 
                    = (message, cert, chain, sslPlicyErrors) => true;
                OAuth2AndOIDCClient.HttpClient = new HttpClient(handler);
            }

            // BuildWebHostが返すIWebHostをRunする。
            // 呼び出し元スレッドは終了までブロックされる。
            Program.CreateHostBuilder(args).Build().Run();
        }

        /// <summary>CreateHostBuilder</summary>
        /// <param name="args">コマンドライン引数</param>
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
                        .UseStartup<Startup>() // IWebHostBuilder.UseStartup<TStartup> メソッドにStartupクラスを指定。
                        .UseUrls(url); // 使用するプロトコルとポートを決定する。
                });
    }
}
