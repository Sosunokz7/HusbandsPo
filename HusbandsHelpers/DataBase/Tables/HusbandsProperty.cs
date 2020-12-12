using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.SqlQuections;
using HusbandsHelpers.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace HusbandsHelpers.DataBase.Tables
{
	class HusbandsProperty : ITable<HusbandsProperty>
	{
		public int id { get; set; }
		public string TableName { get; set; } = "husbands";
		public IQustion<HusbandsProperty> Qustion { get; set; } = new HusbandQuestions();


		public string name { get; set; }
		public string surname { get; set; }

		public string number_phone { get; set; }
		public string address { get; set; }

		public byte[] imageByte { get; set; }
		public bool IsActiv { get; set; } = false;
	}

}
