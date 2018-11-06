public class Animal
{
    protected string name;
    protected string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.name = name;
        this.favouriteFood = favouriteFood;
    }

    //one virtual method ExplainSelf(): string.

    public virtual string ExplainSelf()
    {
        string result = $"I am {this.name} and my favourite food is {this.favouriteFood}";
        return result;
    }
}

