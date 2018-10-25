namespace PizzaCalories
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {

           





            //Bug => Ne stava => Ne raboti
            //string[] command = Console.ReadLine().Split();

            //try
            //{
            //    while (command[0].ToLower() !="END")
            //    {
            //        switch (command[0])
            //        {
            //            case "pizza":

            //                break;
            //        }
            //        command = Console.ReadLine().Split();
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //while (command !="END")
            //{
            //    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //    if (tokens[0] == "Dough")
            //    {
            //        try
            //        {
            //            Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
            //            Console.WriteLine($"{dough.GetCalories():f2}");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            return;
            //        }
            //    }
            //    else if (tokens[0] == "Topping")
            //    {
            //        try
            //        {
            //            Topping toppings = new Topping(tokens[1],int.Parse(tokens[2]));
            //            Console.WriteLine($"{toppings.CaloriesCalculate():f2}");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        string name = tokens[1];
            //        int numberOfToppings = 0;
            //        numberOfToppings = int.Parse(tokens[2]);
            //        if (numberOfToppings>10)
            //        {
            //            Console.WriteLine("Number of toppings should be in range [0..10].");
            //            return;
            //        }
            //        command = Console.ReadLine();
            //        tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            //        Pizza pizza;
            //        try
            //        {
            //            Dough dought = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
            //            pizza = new Pizza(tokens[1], dought);
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            return;
            //        }
            //        for (int i = 0; i < numberOfToppings; i++)
            //        {
            //            command = Console.ReadLine();
            //            tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            //            try
            //            {
            //                Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
            //                pizza.AddTopping(topping);
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //                return;
            //            }
            //        }
            //        Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():f2} Calories.");
            //        return;

            //    }
            //    command = Console.ReadLine();
            //}
        }
    }
}
