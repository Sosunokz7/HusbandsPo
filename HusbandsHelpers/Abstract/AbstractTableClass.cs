using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase;
using HusbandsHelpers.DataBase.SqlQuections;
using HusbandsHelpers.Model;
using HusbandsHelpers.Settings;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading.Tasks;


namespace HusbandsHelpers.Abstract
{
	abstract class AbstractTableClass<T> : base_VM
		where T : class
	{
		
		public BindingList<T> InformationClients { get; set; } 
		protected ConnectToDb db;
		protected IQustion<T> questions;
		protected int CountObservaleCollection { get; set; } = 0;
		protected ITable<T> table = null;

		public AbstractTableClass()
		{
			InformationClients = new BindingList<T>();
			
		}

		

		public  void ChengeTable(ITable<T> table)
		{

			this.table = table;
			db = new ConnectToDb(new DbSetting());
			this.table.Qustion.Connection = db.Connection;
			questions = this.table.Qustion;
			Task.Run(GetTable);

		}
		
		
		public abstract void ConverterIntTOCollumName(int idex);

		public void GetTable()
		{
			questions.GetQustion($"SELECT * FROM {table.TableName};", InformationClients);
		}

	}
}
