using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.SqlQuections;
using HusbandsHelpers.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HusbandsHelpers.DataBase.Tables
{
	class ClientProperty:ITable<ClientProperty>
	{

		public int id { get; set; }
		public string TableName { get; set; } = "clients";

		public IQustion<ClientProperty> Qustion { get; set; } = new ClientQuestions() ;


		public string? name { get; set; }
		public string? surname { get; set; }
		public string? numberPhone { get; set; }
		public string? address { get; set; }

		public bool IsActiv { get; set; } = false;
		
	}
}
