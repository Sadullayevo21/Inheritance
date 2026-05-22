namespace Models.Transports;

class Car : Transport
{
	public void Drive()
	{
		Console.WriteLine($"{this.Brand} is driving");
	}
}