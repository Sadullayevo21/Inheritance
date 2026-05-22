namespace Models.Employee;

class Teacher : Employee
{
    public void Teach()
    {
        Console.WriteLine($"{this.Name} is teaching");
    }
}