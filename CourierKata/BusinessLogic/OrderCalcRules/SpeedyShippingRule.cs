using CourierKata.Interfaces;

namespace CourierKata.BusinessLogic
{
	class SpeedyShippingRule : ICalcOrderRule
	{
		public void GetOrderPrice(IOrder order)
		{
			double SpeedyShippingFactor = 2;

			if (order.Speedy)
			{
				order.TotalPrice *= SpeedyShippingFactor;
				order.PriceDetails.AppendLine("=========== SpeedyShippingRule ===========");
				order.PriceDetails.AppendFormat("Order price is {0}\n", order.TotalPrice);
			}
		}
	}
}
