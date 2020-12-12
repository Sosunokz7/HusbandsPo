using HusbandsHelpers.Abstract.Inrefaces;
using HusbandsHelpers.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.IO;

using Microsoft.Win32;
using HusbandsHelpers.DataBase.Tables;

namespace HusbandsHelpers.Abstract
{ 
	abstract class AbstractRightElementPanel<T>:AbstractTableClass<T>
		where T :class 
	{
		#region Propertis

		public event Action ChangeSelectIndex;
		public int CountList { get; set; } = 0;

		private int _selectedIndex = 1;
		public int SelectedIndex { get { return _selectedIndex; } set { _selectedIndex = value;  onProp();} }

		private ITable<T> _selectedItem;
		public ITable<T> SelectedItem { get { return _selectedItem; } set { _selectedItem = value; onProp(); } }
		


		private string _textForFind;

		public string TextForFind
		{
			get { return _textForFind; }
			set
			{

				_textForFind = value;
				FindDataFromTable();
				onProp();

			}
		}

		private int _indexTypeFind = 0;
		public int IndexTypeFind { get { return _indexTypeFind; } set { _indexTypeFind = value; ConverterIntTOCollumName(_indexTypeFind); onProp(); } }

		protected string CollumNameForFind { get; set; } = "id";

		#endregion
		
		

		public  ICommand Remove
		{
			get
			{
				return new RelayCommand((obj) => {

					bool resulr = MessageBox.Show("Вы уверенны что хотите удалить запись из таблицы??", "Потверждение", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes;
					if (resulr)
					{
						Task.Factory.StartNew(() =>
						{

							questions.SetQustion($"DELETE FROM {table.TableName} WHERE id={SelectedItem.id};");
							GetTable();
						});
						
					}
					
				});
				
			}
		}

		public ICommand GetDown
		{
			get
			{
				return new RelayCommand((obj) => {
					if (InformationClients.Count - 2 < SelectedIndex)
						return;
						DuidFalse();
					++SelectedIndex;
					(InformationClients[SelectedIndex - 1] as ITable<T>).IsActiv = true;
					
						InformationClients.ResetBindings();

				}, (obj) => SelectedIndex != (InformationClients != null ? InformationClients.Count : 0));
			}
		}

		public ICommand GetUp
		{
			get
			{
				return new RelayCommand((obj) => {

					DuidFalse();
					--SelectedIndex;
					(InformationClients[SelectedIndex - 1] as ITable<T>).IsActiv = true;
					InformationClients.ResetBindings();

				}, (obj) => SelectedIndex > 1);
			}
		}

		

		public async void FindDataFromTable()
		{
			if (TextForFind != string.Empty)
			{
				await questions.GetQustion($"SELECT * FROM {table.TableName} WHERE {CollumNameForFind} LIKE '{TextForFind}%' ", InformationClients);
				return;
			}
			
			GetTable();
		}

		public void DuidFalse()
		{
			for (int i = 0; i != InformationClients.Count ; i++)
				(InformationClients[i] as ITable<T>).IsActiv = false;
		
		}
	}
}
