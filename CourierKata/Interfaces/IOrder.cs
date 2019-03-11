using System.Collections.Generic;
using System.Text;

namespace CourierKata
{
	public interface IOrder
	{
		List<IParcel> Parcels { get; set; }
		bool Speedy { get; set; }
		double TotalPrice { get; set; }
		StringBuilder PriceDetails { get; }
	}
}
