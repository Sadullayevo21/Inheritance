namespace Models.Employee;

class Employee
{
	public string Name { get; set; }
    public decimal Salary { get; set; }

	public void Work()
	{
		Console.WriteLine($"{this.Name} is working. He get {this.Salary}$");
	}
}