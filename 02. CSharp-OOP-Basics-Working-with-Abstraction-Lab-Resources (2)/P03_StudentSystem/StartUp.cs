using System;

namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            string input = Console.ReadLine();
            while (input!="Exit")
            {
                string[] args =input.Split();
                var command = args[0];
                var name = args[1];
               
                switch (command)
                {
                    case "Create":
                        var age = int.Parse(args[2]);
                        var grade = double.Parse(args[3]);
                        studentSystem.Create(name, age, grade);
                        break;
                    case "Show":
                        studentSystem.Show(name);
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
