using System;
using System.Collections.Generic;
using CourierKata.BusinessLogic;
using CourierKata.BusinessLogic.OrderCalcRules;
using CourierKata.Interfaces;

namespace CourierKata
{
	class Program
	{
		static void Main()
		{
			IOrderReader orderReader = new OrderReader();
			IOrder order;
			try
			{
				order = orderReader.GetOrder("../../../Items.xml");
				var parcelRules = new List<ICalcParcelRule>
				{
					new CostByDimensionsRule(),
					new CostByWeightRule(),
					new ExtraWeightRule(),
				};

				var orderRules = new List<ICalcOrderRule>
				{
					new RegularShippingRule(),
					new SpeedyShippingRule()
				};

				Calculator calculator = new Calculator(order, parcelRules, orderRules);
				string priceDetails = calculator.GetOrderPriceDetails();

				Console.WriteLine(priceDetails);
				Console.ReadKey();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Console.ReadKey();
			}
		}
	}
}
