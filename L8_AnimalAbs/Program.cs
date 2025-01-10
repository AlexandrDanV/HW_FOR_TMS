using L8_AnimalAbs;

Dog dog = new Dog();
Console.Write("Укажите имя собаки: ");
var nameDog = Console.ReadLine();
dog.SetName(nameDog);
var namDog = dog.GetName();
dog.Eat();
var dogEat = StatusDog.DogEat != null ? StatusDog.DogEat : "Собака не ест!";
Console.WriteLine(dogEat);

Console.ReadLine();