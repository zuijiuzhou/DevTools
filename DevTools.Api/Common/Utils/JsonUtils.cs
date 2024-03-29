﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Utilities.Json;

namespace DevTools.Api.Common.Utils
{
	/// <summary>
	/// json工具类
	/// </summary>
    public static class JsonUtils
    {
		/// <summary>
		/// 属性转小写序列化设置
		/// </summary>
        public static readonly JsonSerializerSettings LowerCaseSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new JsonContractResolver() {  PropertyNameFormat = PropertyNameFormat.LowerCase }
        };
    }
}
