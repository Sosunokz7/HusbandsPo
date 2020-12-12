using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using HusbandsHelpers.Abstract;
using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.Tables;

namespace HusbandsHelpers.DataBase.SqlQuections
{
	class ClientQuestions:AbstractQustion,IQustion<ClientProperty>
	{

		public async Task<int> GetQustion(string question , BindingList<ClientProperty> ls)
		{
			
			var reader=BaseCommand(question).Result;
			await Application.Current.Dispatcher.BeginInvoke(new Action(() =>
			{
				if (ls.Count > 0)
					ls.Clear();
				while (reader.Read())
					  {

						  ls.Add(new ClientProperty()
						  {
							  
							  id =  reader.GetInt32(0),
							  surname = CheckingNUll(reader, 1) ? null : reader.GetString(1),
							  name = CheckingNUll(reader, 2)?null:reader.GetString(2),
							  numberPhone = CheckingNUll(reader, 3) ? null:reader.GetString(3),
							  address = CheckingNUll(reader, 4) ? null:reader.GetString(4),
						  });

					  }

				  }));
			
			reader.CloseAsync();
			return ls.Count;



		}

		public void SetQustion(string question)
		{
			setQuestion(question);

		}

		
	}
}
