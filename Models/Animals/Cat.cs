namespace Models.Animals;
public class Cat : Animal
{
    public void Meowing()
    {
        Console.WriteLine($"{this.Name} is Meowing"); 
    }

    public void Eat()
    {
        Console.WriteLine($"{this.Name} is eating mouce");
    }
}