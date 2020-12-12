using HusbandsHelpers.Abstract;
using HusbandsHelpers.DataBase.Tables;
using HusbandsHelpers.Model;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HusbandsHelpers.ViewModel
{
	class Client :AbstractRightElementPanel<ClientProperty>
	{
		private string _nameRowsForFind = "Поиск по: Фамлии";
		public string NameRowsForFind { get { return _nameRowsForFind; } }
		public Client()
		{
			
			Task.Run(() => { ChengeTable(new ClientProperty() ); });
			
		}

		public ICommand Add
		{
			get
			{
				return new RelayCommand((obj) => {

					
					questions.SetQustion($"INSERT INTO {table.TableName} VALUES ({InformationClients.Last().id},'{InformationClients.Last().surname}'," +
						$"'{InformationClients.Last().name}','{InformationClients.Last().numberPhone}','{InformationClients.Last().address}');");
				

				});
			}
		}

		public override void ConverterIntTOCollumName(int idex)
		{
			switch(idex)
			{
				case 0:
					{
						CollumNameForFind = "id";
						break;
					}
				case 1:
					{
						CollumNameForFind = "surname";
						break;
					}
			}
		}

		
		


	}
}
