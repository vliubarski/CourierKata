namespace CourierKata
{
	interface IOrderReader
	{
		IOrder GetOrder(string path);
	}
}