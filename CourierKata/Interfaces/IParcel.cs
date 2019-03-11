using CourierKata.Interfaces;

namespace CourierKata
{
	public interface IParcel
	{
		double Height { get; set; }
		double Weight { get; set; }
		double Width { get; set; }
		Categories Category { get; set; }
		double Price { get; set; }
	}
}