using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HusbandsHelpers.Model
{
	class RelayCommand : ICommand
	{
		private Action<object> _execute;
		private Func<object, bool> _canExecute;

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			this._execute(parameter);
		}

		public RelayCommand(Action<object> action,Func<object,bool> func=null)
		{
			this._execute = action;
			this._canExecute = func;
		}
	}
}
