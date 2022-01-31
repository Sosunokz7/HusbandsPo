using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.View.PageTables;
using System;
using System.Windows.Controls;

namespace HusbandsHelpers.Pages
{
	class UsersClass : IPageForMenu
	{
		public string Name { get; set; } = "Пользователи";
		public Page page { get; set; }

		public void Update()
		{
			this.page = new ClientsTable();
		}

	}
}
