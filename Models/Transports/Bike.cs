namespace Models.Transports;

 class Bike : Transport
{
	public void Ride()
	{
		Console.WriteLine($"{this.Brand} is riding");
	}
}