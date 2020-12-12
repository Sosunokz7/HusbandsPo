using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.View.PageTables;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HusbandsHelpers.ClassPages
{
	class ServiceClass : IPageForMenu
	{
		public string Name { get; set; } = "Услуги";
		public Page page { get; set; } = new ServiceTable();

		public void Update()
		{

			this.page = new ServiceTable();
		}

		
	}
}
