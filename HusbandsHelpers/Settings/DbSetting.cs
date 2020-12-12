using HusbandsHelpers.Inrefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HusbandsHelpers.Settings
{
	class DbSetting : IDataBaseSetting
	{

		public string Server { get; set; } = "172.18.1.30";
		public string User { get; set; } = "pc7";
		public string Database { get; set; } = "pc7";
		public string Password { get; set; } = "12345678";
	}
}
