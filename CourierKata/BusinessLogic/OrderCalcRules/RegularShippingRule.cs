using System.Linq;
using CourierKata.Interfaces;

namespace CourierKata.BusinessLogic.OrderCalcRules
{
	class RegularShippingRule : ICalcOrderRule
	{
		public void GetOrderPrice(IOrder order)
		{
			double total = order.Parcels.Sum(x => x.Price);
			order.TotalPrice = total;
			order.PriceDetails.AppendLine("=========== RegularShippingRule ===========");
			order.PriceDetails.AppendFormat("Order price is {0}\n\n", total);
		}
	}
}
