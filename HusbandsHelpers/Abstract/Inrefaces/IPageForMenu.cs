using System.Windows.Controls;

namespace HusbandsHelpers.Inrefaces
{
	interface IPageForMenu
	{
		string Name { get; set; }
		
		Page page { get; set; }

		void Update();

	}
}
