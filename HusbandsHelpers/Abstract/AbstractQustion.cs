using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows;

namespace HusbandsHelpers.Abstract
{
	class AbstractQustion
	{

		public MySqlConnection Connection { get; set; }
		protected async Task<DbDataReader> BaseCommand(string sqlCommand)
		{

			if (Connection.State == System.Data.ConnectionState.Closed)
				Connection.Open();

			MySqlCommand command = new MySqlCommand(sqlCommand, Connection);


			return await command.ExecuteReaderAsync();
		}

		protected void setQuestion(string slqCommand)
		{
			try
			{
				BaseCommand(slqCommand).Result.CloseAsync();
			}
			catch(System.AggregateException ex)
			{
				MessageBox.Show("Id не могут быть одинаковые");
			}
		
		}


		protected bool CheckingNUll (DbDataReader reader,int index)
		{
			return reader.GetValue(index) == DBNull.Value;
		}

	}
}
