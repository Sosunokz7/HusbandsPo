using HusbandsHelpers.Abstract;
using HusbandsHelpers.DataBase.Tables;
using System.Threading.Tasks;


namespace HusbandsHelpers.ViewModel
{
	class Service : AbstractRightElementPanel<ServiceProperty>
	{
		private string _nameRowsForFind = "Поиск по: Названию";
		public string NameRowsForFind { get { return _nameRowsForFind; } }
		public Service()
		{
			Task.Run(() => { ChengeTable(new ServiceProperty()); });
		}
	

		public override void ConverterIntTOCollumName(int idex)
		{
			switch (idex)
			{
				case 0:
					{
						CollumNameForFind = "id";
						break;
					}
				case 1:
					{
						CollumNameForFind = "name_service";
						break;
					}
			}
		}

	}
}
