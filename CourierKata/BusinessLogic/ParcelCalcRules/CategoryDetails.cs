
using System.Collections.Generic;
using CourierKata.Interfaces;

namespace CourierKata
{
	public class CategoryDetails
	{
		static public double PriceOverWeightPerKg { get; }
		static public double HeavyParcelLimitKg { get; }
		static public double HeavyParcelLimitPrice { get; }
		static public double HeavyParcelPriceOverLimitPerKg { get; }
		public class Details
		{
			public Details(double nominalPrice, double maxWeight, double maxLength)
			{
				NominalPrice = nominalPrice;
				MaxWeight = maxWeight;
				MaxLength = maxLength;
			}
			public double MaxLength { get; }
			public double NominalPrice { get; }
			public double MaxWeight { get; }
		}

		static CategoryDetails()
		{
			Data = new Dictionary<Categories, Details>();

			Data.Add(Categories.Small, new Details(3, 1, 10)); //parcel details contain nominalPrice, maxWeight, maxLength
			Data.Add(Categories.Medium, new Details(8, 3, 50));
			Data.Add(Categories.Large, new Details(15, 6, 100));
			Data.Add(Categories.XLarge, new Details(25, 10, 101));
			Data.Add(Categories.Heavy, new Details(50, 11, 1));
			PriceOverWeightPerKg = 2;
			HeavyParcelLimitKg = 50;
			HeavyParcelLimitPrice = 50;
			HeavyParcelPriceOverLimitPerKg = 1;
		}

		static public Dictionary<Categories, Details> Data { get; }

		static public Categories GetCategoryByLengthWeight(double length, double weight)
		{
			if (weight > Data[Categories.XLarge].MaxWeight)
			{
				return Categories.Heavy;
			}
			if (length <= Data[Categories.Small].MaxLength)
			{
				return Categories.Small;
			}
			if (length <= Data[Categories.Medium].MaxLength)
			{
				return Categories.Medium;
			}
			if (length <= Data[Categories.Large].MaxLength)
			{
				return Categories.Large;
			}
			return Categories.XLarge;
		}
	}
}