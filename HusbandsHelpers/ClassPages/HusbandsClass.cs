using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.View.PageTables;
using System.Windows.Controls;

namespace HusbandsHelpers.ClassPages
{
	class HusbandsClass:IPageForMenu
	{
		public string Name { get; set; } = "Мужья";
		public Page page { get; set; }

		public void Update()
		{
			this.page = new HusbandsTable();
		}
		
	}
}
