using HusbandsHelpers.Abstract;
using HusbandsHelpers.DataBase.Tables;
using System.Threading.Tasks;


namespace HusbandsHelpers.ViewModel
{
	class Husband : AbstractRightElementPanel<HusbandsProperty>
	{
		
		private string _nameRowsForFind = "Поиск по: Фамлии";
		public string NameRowsForFind { get { return _nameRowsForFind; } }
		public Husband()
		{
			Task.Run(() => { ChengeTable(new HusbandsProperty()); });

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
