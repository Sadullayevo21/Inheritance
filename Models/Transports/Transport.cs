namespace Models.Transports;

class Transport
{
	public string Brand { get; set; }

	public void Move()
	{
		Console.WriteLine("Vehicle is moving");
	}
}