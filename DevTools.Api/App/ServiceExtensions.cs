﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DevTools.Api.App
{
	public static class ServiceExtensions
	{
		public static void AddServices(this IServiceCollection services)
		{
			var svcs = Assembly.GetExecutingAssembly()
				.GetTypes()
				.Where(t => t.IsClass && !t.IsAbstract)
				.Select(t => new KeyValuePair<Type, ServiceAttribute>(t, t.GetCustomAttribute(typeof(ServiceAttribute)) as ServiceAttribute))
				.Where(t => t.Value != null);
			foreach (var item in svcs)
			{
				if (item.Value.ServiceLife == ServiceLifetime.Transient)
				{
					services.AddTransient(item.Key);
				}
				else if (item.Value.ServiceLife == ServiceLifetime.Scoped)
				{
					services.AddScoped(item.Key);
				}
				else if (item.Value.ServiceLife == ServiceLifetime.Singleton)
				{
					services.AddSingleton(item.Key);
				}
			}
		}
	}
}
