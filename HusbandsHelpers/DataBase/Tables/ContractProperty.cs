using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.SqlQuections;
using System;
using System.Collections.Generic;
using System.Text;

namespace HusbandsHelpers.DataBase.Tables
{
	class ContractProperty : ITable<ContractProperty>
	{
		public int id { get; set; }
		public int husband_id { get; set; }
		public string? date { get; set; }
		public string TableName { get; set; } = "contract";
		public IQustion<ContractProperty> Qustion { get; set; } = new ContractQuestions();
		public bool IsActiv { get; set; } = false;
	}
}
