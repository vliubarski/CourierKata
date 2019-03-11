using System.Collections.Generic;
using System.Text;

namespace CourierKata
{
	public class Order : IOrder
	{
		public Order()
		{
			PriceDetails = new StringBuilder();
		}
		public List<IParcel> Parcels { get; set; }
		public bool Speedy { get; set; }
		public double TotalPrice { get; set; }
		public StringBuilder PriceDetails { get; }
	}
}
