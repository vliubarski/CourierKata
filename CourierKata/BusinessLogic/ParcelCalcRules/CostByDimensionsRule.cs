
using CourierKata.Interfaces;

namespace CourierKata.BusinessLogic
{
	public class CostByDimensionsRule : ICalcParcelRule
	{
		public void GetParcelsPrice(IOrder order)
		{
			order.PriceDetails.AppendLine("=========== CostByDimensionsRule ===========");

			foreach (var parcel in order.Parcels)
			{
				parcel.Price =  CategoryDetails.Data[parcel.Category].NominalPrice;
				order.PriceDetails.AppendFormat("{0} parcel price : {1}.\n", parcel.Category, parcel.Price);
			}
		}
	}
}
