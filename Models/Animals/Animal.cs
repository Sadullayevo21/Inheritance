namespace Models.Animals;

public class Animal
{
    public string Name { get; set; }

    public void MakeVoice()
    {
        Console.WriteLine($"{this.Name} is making noise!");
    }
}