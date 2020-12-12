using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.View.PageTables;

using System.Windows.Controls;

namespace HusbandsHelpers.ClassPages
{
	class ExitClass : IPageForMenu
	{
		
		public string Name { get; set; } = "Выход";
		public Page page { get; set; }

		public void Update()
		{
			page =new AuthorizationPage();
		}
	}
}
