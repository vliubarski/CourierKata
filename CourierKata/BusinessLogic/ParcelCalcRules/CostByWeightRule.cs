
using CourierKata.Interfaces;

namespace CourierKata.BusinessLogic
{
	class CostByWeightRule : ICalcParcelRule
	{
		public void GetParcelsPrice(IOrder order)
		{
			order.PriceDetails.AppendLine("\n=========== CostByWeightRule ===========");

			foreach (var parcel in order.Parcels)
			{
				if (parcel.Category==Categories.Heavy)
				{
					continue;
				}
				double overWeight = parcel.Weight - CategoryDetails.Data[parcel.Category].MaxWeight;
				if (overWeight >= 1)// 1kg precision
				{
					parcel.Price += (int)overWeight * CategoryDetails.PriceOverWeightPerKg;
					order.PriceDetails.AppendFormat("{0} parcel price for over weight : {1}.\n", parcel.Category, parcel.Price);
				}
			}
		}
	}
}
