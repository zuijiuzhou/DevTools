﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTools.Api.Models.Configuration
{
	public class Connections
	{
		public RedisSettings Redis { get; set; }

		public RabbitMQSettings RabbitMQ { get; set; }
	}
}
