namespace Farm
{
    using SingleInheritance;
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();
        }
    }
}
