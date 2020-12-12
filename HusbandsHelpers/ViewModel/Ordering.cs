using HusbandsHelpers.Abstract;
using HusbandsHelpers.DataBase.Tables;
using System.Threading.Tasks;


namespace HusbandsHelpers.ViewModel
{
	class Ordering :AbstractRightElementPanel<OrderingProperty>
	{
		private string _nameRowsForFind = "Поиск по:Номеру мужа";
		public string NameRowsForFind { get { return _nameRowsForFind; } }
		public Ordering()
		{
			Task.Run(() => { ChengeTable(new OrderingProperty()); });

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
						CollumNameForFind = "surname";
						break;
					}
			}
		}
	}
}
