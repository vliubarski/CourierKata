using System;
using System.Collections.Generic;
using CourierKata.Interfaces;

namespace CourierKata
{
	class Calculator
	{
		private readonly IOrder _order;
		private readonly List<ICalcParcelRule> _parcelRules;
		private readonly List<ICalcOrderRule> _orderRules;

		public Calculator(IOrder order, List<ICalcParcelRule> parcelRules, List<ICalcOrderRule> orderRules)
		{
			_order = order;
			_parcelRules = parcelRules;
			_orderRules = orderRules;
			ApplyCategories();
		}
		private void ApplyCategories()
		{
			foreach (var parcel in _order.Parcels)
			{
				parcel.Category = CategoryDetails.GetCategoryByLengthWeight(
					Math.Max(parcel.Height, parcel.Width), parcel.Weight);
			}
		}

		public string GetOrderPriceDetails()
		{
			foreach (var rule in _parcelRules)
			{
				rule.GetParcelsPrice(_order);
			}

			foreach (var rule in _orderRules)
			{
				rule.GetOrderPrice(_order);
			}

			return _order.PriceDetails.ToString();
		}
	}
}
