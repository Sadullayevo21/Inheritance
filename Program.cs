using Models.Animals;
using Models.Transports;

var cat = new Cat
{
    Name = "Murka"
};

var dog = new Dog
{
    Name = "Rex"
};

cat.Eat();
cat.Meowing();
dog.Eat();
dog.Bark();


Car car = new Car();
car.Brand = "Mercedes";
car.Move();
car.Drive();
Bike bike = new Bike();
bike.Brand = "Giant";
bike.Move();
bike.Ride();
Train train = new Train();
train.Brand = "Afrosiyob";
train.Move();
train.CarryPassengers();