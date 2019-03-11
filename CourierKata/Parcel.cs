

using CourierKata.Interfaces;

namespace CourierKata
{
	public class Parcel : IParcel
	{
		public double Width { get; set; }
		public Categories Category { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
		public double Price { get; set; }
	}
}
