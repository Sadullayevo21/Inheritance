namespace Models.Employee;

class Developer : Employee
{
    public void Code()
    {
        Console.WriteLine($"{this.Name} is coding");
    }
}