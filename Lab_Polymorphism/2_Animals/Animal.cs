
public class Animal
{
    protected string Name;
    protected string FavouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }
}

