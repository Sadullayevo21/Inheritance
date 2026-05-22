namespace Models.Employee;

class Designer : Employee
{
    public void Design()
    {
        Console.WriteLine($"{this.Name} is decigning");
    }
}