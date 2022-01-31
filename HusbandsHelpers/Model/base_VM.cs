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

		//public void onProp([CallerMemberName] string prop = "")
		//{
		//	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		//}

		public bool SetValue<T>(ref T property,T value, [CallerMemberName] string propName = "")
		{
			if (Equals(property, value))
				return false;

			property = value;
			onProp(propName);
			return true;

		}
	}
}
