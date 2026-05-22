namespace Models.Transports;

class Train : Transport
{
	public void CarryPassengers()
	{
		Console.WriteLine($"{this.Brand} is carrying passengers");
	}
}