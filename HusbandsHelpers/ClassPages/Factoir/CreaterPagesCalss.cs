using HusbandsHelpers.ClassPages;
using HusbandsHelpers.Inrefaces;
using HusbandsHelpers.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace HusbandsHelpers
{
	class CreatePagesCalss
	{

		public IEnumerable<IPageForMenu> GetPage()
		{

			return new List<IPageForMenu>()
			{
				new UsersClass(),
				new OrderingClass(),
				new HusbandsClass(),
				new ServiceClass(),
				new ContractClass(),
				new ExitClass()
			};
		}

	}
}
