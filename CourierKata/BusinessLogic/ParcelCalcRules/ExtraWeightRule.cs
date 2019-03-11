
using CourierKata.Interfaces;

namespace CourierKata.BusinessLogic
{
	public class ExtraWeightRule : ICalcParcelRule
	{
		public void GetParcelsPrice(IOrder order)
		{
			order.PriceDetails.AppendLine("\n=========== ExtraWeightRule ===========");

			foreach (var parcel in order.Parcels)
			{
				if (parcel.Category == Categories.Heavy)
				{
					if (parcel.Weight <= CategoryDetails.HeavyParcelLimitKg)
					{
						parcel.Price = CategoryDetails.HeavyParcelLimitPrice;
					}
					else
					{
						double overWeight = parcel.Weight - CategoryDetails.HeavyParcelLimitKg;
						parcel.Price = CategoryDetails.HeavyParcelLimitPrice + overWeight * CategoryDetails.HeavyParcelPriceOverLimitPerKg;
					}
					order.PriceDetails.AppendFormat("{0} parcel price for extra over weight : {1}\n\n", parcel.Category, parcel.Price);
				}
			}
		}
	}
}
