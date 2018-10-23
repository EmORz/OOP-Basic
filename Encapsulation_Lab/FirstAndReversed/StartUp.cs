namespace PersonsInfo
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var team = new Team("Name");

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var firstName = input[0];
                var lastName = input[1];
                var age = int.Parse(input[2]);
                var salary = decimal.Parse(input[3]);
                //
                var current = new Person(firstName, lastName, age, salary);
                team.AddPlayer(current);
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");



        }
    }
}
