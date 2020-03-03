﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Our.Umbraco.EnvironmentDashboard.Models
{
	public class Dashboard
	{
		public Dashboard()
		{
			Groups = new List<Group>();
		}

		[JsonProperty("currentEnvironment")]
		public string CurrentEnvironment { get; set; }

		[JsonProperty("groups")]
		public List<Group> Groups { get; set; }
	}
}