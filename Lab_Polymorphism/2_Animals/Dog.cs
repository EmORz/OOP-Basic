using System.Text;

public class Dog : Animal
{
    public Dog(string name, string favouriteFood)
    : base(name, favouriteFood)
    {
    }

    public override string ExplainSelf()
    {
        var builder = new StringBuilder();
        builder.AppendLine(base.ExplainSelf())
            .AppendLine("DJAAF");
        string result = builder.ToString().TrimEnd();
        return result;
    }
}

