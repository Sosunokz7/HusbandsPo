
using HusbandsHelpers.Settings;

namespace HusbandsHelpers.Abstract.Inrefaces
{
	interface ITable<T>
		where T:class
	{
		public int id { get; set; }
		public string TableName { get; set; }
			
		public bool IsActiv { get; set; }
		public IQustion<T> Qustion { get; set; } 


	}
}
