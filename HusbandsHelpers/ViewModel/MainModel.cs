using HusbandsHelpers.ClassPages;
using HusbandsHelpers.Model;
using HusbandsHelpers.View.PageTables;
using System.Windows.Controls;

namespace HusbandsHelpers.ViewModel
{
	class MainModel:base_VM
	{
		private Page _authorizationPage;
		public Page AuthorizationPage { get { return _authorizationPage; }set { _authorizationPage = value; onProp(); } }

		public MainModel()
		{
			AuthorizationPage = new AuthorizationPage();
			
			
		}

	
	}
}
