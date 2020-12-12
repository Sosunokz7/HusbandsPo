using HusbandsHelpers.Inrefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HusbandsHelpers.Settings
{
	class ClientSetting : IUser
	{
		public string UserLogin { get; set; } = "1";
		public string UserPassword { get; set; } = "1";
	}
}
