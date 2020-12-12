using HusbandsHelpers.Inrefaces;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Threading.Tasks;

namespace HusbandsHelpers.DataBase
{
	class ConnectToDb
	{
		private readonly string connectStr;
		
		public MySqlConnection Connection { get; private set; }

		public ConnectToDb(IDataBaseSetting dataBaseSetting)
		{
			connectStr = $"server={dataBaseSetting.Server};user={dataBaseSetting.User};database={dataBaseSetting.Database};password={dataBaseSetting.Password};";
			Connect();
		}

		

		private async Task<MySqlConnection>Connect()
		{
			if (Connection == null)
			{
				try
				{
					Connection = new MySqlConnection(connectStr);
					await Connection.OpenAsync();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Environment.Exit(0);
				}
				return Connection;
			}
			return Connection;
			
		}

		public void Clouse()
		{
			if (Connection != null)
			{
				Connection.CloseAsync();				
			}
			

		}

	}
}
