using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.SqlQuections;
using HusbandsHelpers.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace HusbandsHelpers.DataBase.Tables
{
	class ServiceProperty:ITable<ServiceProperty>
	{
		public int id { get; set; }

		public string  TableName { get;  set; } = "service";

		public IQustion<ServiceProperty> Qustion { get; set; } = new ServiceQuestions();

		public string? name_service { get; set; }
		public double price { get; set; }

		public byte[] imageByte {get;set;}
		public bool IsActiv { get; set; } = false;
	}
}
