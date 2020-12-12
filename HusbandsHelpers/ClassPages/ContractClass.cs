using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.View.PageTables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace HusbandsHelpers.ClassPages
{
	class ContractClass : IPageForMenu
	{
		public string Name { get; set; } = "Контракты";
		public Page page { get; set; } = new ContractPage();

		public void Update()
		{
			page = new ContractPage();
		}
	}
}
