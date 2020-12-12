using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.Model;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace HusbandsHelpers.ViewModel
{
	class NavigateMenu:base_VM
	{
		
		private IPageForMenu pageForMenu;

		private CreatePagesCalss pageFactori;
		
		public ObservableCollection<IPageForMenu> menuPages { get; set; }

		private Page _tishPage = null;
		public Page thisPage { get { return _tishPage; } set { _tishPage = value;onProp(); } }

		private Page exit = null;
		public Page Exit{ get { return exit; } set {  exit = value; onProp(); } }

		public NavigateMenu()
		{
			
			pageFactori = new CreatePagesCalss();
			menuPages = new ObservableCollection<IPageForMenu>(pageFactori.GetPage());
			
		}

		public ICommand NewPageClick
		{
			get
			{
				return new RelayCommand((obj) => {
					pageForMenu = obj as IPageForMenu;
					pageForMenu.Update();
					if (pageForMenu.Name == "Выход")
						Exit = pageForMenu.page;
					thisPage = pageForMenu.page;
					
				},(obj)=> {
					if (pageForMenu != null)
					{
						var page = obj as IPageForMenu;

						return page.page != pageForMenu.page;
					}
					return true;
				
				});
			}
		}

	}
}
