using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.View.PageTables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace HusbandsHelpers.ClassPages
{
	class OrderingClass : IPageForMenu
	{
		public string Name { get; set; } = "Заказы";
		public Page page { get; set; } = new OrderingsTable();

		public void Update()
		{
			page = new OrderingsTable();
		}
	}
}
