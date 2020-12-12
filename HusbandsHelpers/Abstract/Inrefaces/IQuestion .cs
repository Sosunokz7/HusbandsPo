using HusbandsHelpers.DataBase.Tables;
using MySql.Data.MySqlClient;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HusbandsHelpers.Abstract.Inrefaces
{
	interface IQustion<T>where T:class
	{
		public MySqlConnection Connection { get; set; }
		public Task<int> GetQustion(string question, BindingList<T> ls);

		public void SetQustion(string question);

		
	}
}
