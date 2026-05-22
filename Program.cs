using Models.Animals;
using Models.Transports;
using Models.Employee;
using Models.Person;

var cat = new Cat
{
    Name = "Murka"
};

cat.Eat();
cat.Meowing();

var dog = new Dog
{
    Name = "Rex"
};

dog.Eat();
dog.Bark();


var car = new Car
{
    Brand = "Mercedes"
};

car.Move();
car.Drive();

var bike = new Bike
{
    Brand = "Giant"
};

bike.Move();
bike.Ride();

var train = new Train
{
    Brand = "Afrosiyob"
};

train.Move();
train.CarryPassengers();


var developer = new Developer
{
    Name = "John",
    Salary = 1000
};

developer.Work();
developer.Code();

var teacher = new Teacher
{
    Name = "Alex",
    Salary = 700
};

teacher.Work();
teacher.Teach();

var designer = new Designer
{
    Name = "Jek",
    Salary = 850
};

designer.Work();
designer.Design();


Student student = new Student("Ali", 5);
Models.Person.Teacher teachers =
    new Models.Person.Teacher("Hasan", "Math");
