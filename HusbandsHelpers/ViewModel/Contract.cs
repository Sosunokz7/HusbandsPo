using HusbandsHelpers.Abstract;
using HusbandsHelpers.DataBase.Tables;
using System.Threading.Tasks;

namespace HusbandsHelpers.ViewModel
{
	class Contract : AbstractRightElementPanel<ContractProperty>
	{

		private string _nameRowsForFind = "Поиск по: Дате";
		public string NameRowsForFind { get { return _nameRowsForFind; } }
		public Contract()
		{
			Task.Run(() => { ChengeTable(new ContractProperty()); });

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
						CollumNameForFind = "date_contract";
						break;
					}
			}
		}
	}
}
