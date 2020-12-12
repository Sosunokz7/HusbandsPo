using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace HusbandsHelpers.Model
{
	class base_VM : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void onProp([CallerMemberName] string prop="")
		{
			PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(prop));
		}
	}
}
