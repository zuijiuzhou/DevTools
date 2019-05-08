﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.Extensions;
using NLog.Web;

namespace DevTools.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
			NLogBuilder.ConfigureNLog("nlog.config");
			var webHost = BuildWebHost(args);
            webHost.Run();
        }

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseIISIntegration()
				//.UseKestrel()
				.UseUrls("http://localhost:61003")
				//.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>()
				//.ConfigureLogging(options=> {
				//	options.ClearProviders();
				//	options.AddDebug();
				//	options.AddConsole();
				//})
				.ConfigureAppConfiguration(options=> {
					
				})
				.UseNLog()
                .Build();
    }
}