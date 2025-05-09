
namespace Lab8;

class Animal 
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
class Cat: Animal //Derived class
{
    public override void AnimalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog: Animal //Derived class
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
class Program
{
    static void Main(string[] args)
{
    Animal myAnimal=new();
    Animal myCat=new Cat();
    Animal myDog=new Dog();

    myAnimal.AnimalSound();
    myCat.AnimalSound();
    myDog.AnimalSound();
}
 
}