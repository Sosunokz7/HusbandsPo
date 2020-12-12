using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.SqlQuections;
using System;
using System.Collections.Generic;
using System.Text;

namespace HusbandsHelpers.DataBase.Tables
{
	class OrderingProperty : ITable<OrderingProperty>
	{
		public int id { get; set; }

		public int husband_id{ get;set;}

		public int client_id { get; set; }

		public int number_service { get; set; }
		public string TableName { get; set; } = "ordering";
		public IQustion<OrderingProperty> Qustion { get; set; } = new OrederingQuestions();
		public bool IsActiv { get; set; } = false;
	}
}
