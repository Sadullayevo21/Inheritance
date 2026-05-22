namespace Models
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name} is barking");
        }

        public void Eat()
        {
            Console.WriteLine($"{this.Name} is eating bone");
        }
    }
}