public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound(); 

    public void DisplayInfo()
    {
        Console.WriteLine($"Animal Name: {Name}");
    }
}

public class Dog : Animal
{
    public Dog(string name) 
        : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof woof!");
    }
}

public class Cat : Animal
{
    public Cat(string name)
        : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow meow!");
    }
}


class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        dog.DisplayInfo();
        dog.MakeSound();

        Animal cat = new Cat("Kitty");
        cat.DisplayInfo();
        cat.MakeSound();
    }
}