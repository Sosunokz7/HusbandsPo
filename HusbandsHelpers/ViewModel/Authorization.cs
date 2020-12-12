using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.Model;
using HusbandsHelpers.Settings;
using HusbandsHelpers.View;
using System.Windows.Controls;
using System.Windows.Input;

namespace HusbandsHelpers.ViewModel
{
	class Authorization : base_VM
	{
		private IUser user;
		private string _login ;
		public string Login { get { return _login; } set { _login = value; } }

		private string _password;
		public string Password { get { return _password; } set { _password = value; } }

		private Page _menu =new MainMenu() ;
		private Page _Mneu;
		public Page Menu { get { return _Mneu; }set { _Mneu = value; onProp(); } }
		

		public ICommand Logining{
			get {
				return new RelayCommand((obj)=> {
					if (Login == user.UserLogin && Password == user.UserPassword)
						Menu = _menu;
					
				});
			}
		}


		public Authorization()
		{
			_menu = new MainMenu();
			user = new ClientSetting();
		}
	}
}
