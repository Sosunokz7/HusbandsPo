using HusbandsHelpers.Abstract;
using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HusbandsHelpers.DataBase.SqlQuections
{
	class OrederingQuestions : AbstractQustion, IQustion<OrderingProperty>
	{
		public async Task<int> GetQustion(string question, BindingList<OrderingProperty> ls)
		{
			
			var reader = BaseCommand(question).Result;
			await Application.Current.Dispatcher.BeginInvoke(new Action(() =>
			{
				if (ls.Count > 0)
					ls.Clear();

				while (reader.Read())
				{

					ls.Add(new OrderingProperty()
					{
						id = reader.GetInt32(0),
						husband_id = reader.GetInt32(1),
						client_id = reader.GetInt32(2),
						number_service= reader.GetInt32(3)

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
