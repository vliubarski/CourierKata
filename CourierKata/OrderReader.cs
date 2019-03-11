using System.Collections.Generic;
using System.Xml;

namespace CourierKata
{
	class OrderReader : IOrderReader
	{
		public IOrder GetOrder(string path)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(path);

			XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Order");
			IOrder res = new Order();
			List<IParcel> parcelList = new List<IParcel>();

			foreach (XmlNode node in nodes)
			{
				res.Speedy = bool.Parse(node.Attributes[0].Value);

				var parcels = node.SelectNodes("Parcel");

				foreach (XmlNode parcel in parcels)
				{
					parcelList.Add(new Parcel
					{
						Width =  double.Parse(parcel.Attributes[0].Value),
						Height = double.Parse(parcel.Attributes[1].Value),
						Weight = double.Parse(parcel.Attributes[2].Value)
					});
				}
				res.Parcels = parcelList;
			}
			return res;
		}
	}
}