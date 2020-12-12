using HusbandsHelpers.Abstract;
using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.Tables;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace HusbandsHelpers.DataBase.SqlQuections
{
	class ServiceQuestions:AbstractQustion,IQustion<ServiceProperty>
	{


		public async Task<int> GetQustion(string question, BindingList<ServiceProperty> ls)
		{
			
			var reader = BaseCommand(question).Result;

			await Application.Current.Dispatcher.BeginInvoke(new Action(() =>
			{
				if (ls.Count > 0)
					ls.Clear();
				while (reader.Read())
				{
					
					ls.Add(new ServiceProperty()
					{
						id = reader.GetInt32(0),
						name_service = CheckingNUll(reader, 2) ? null : reader.GetString(1),
						price = CheckingNUll(reader,2)? 0 : reader.GetDouble(2),
						imageByte = CheckingNUll(reader, 3) ? null: (byte[]) reader.GetValue(3)

					}); 
					
				}

			}));
			reader.CloseAsync();
			return ls.Count;
		}

		public void SetQustion(string question)
		{
			var reader = BaseCommand(question).Result;
			reader.CloseAsync();
		}
	}
}
