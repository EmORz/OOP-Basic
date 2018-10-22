using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        public static void Main()
        {           
            Dictionary<string, Departments> departmentsS = new Dictionary<string, Departments>();
            Dictionary<string, Doctors> doctors = new Dictionary<string, Doctors>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] input = command.Split();

                var departament = input[0];
                var fullName = input[1] + input[2];
                var patients = input[3];

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new Doctors(new List<string>());
                }
                if (!departmentsS.ContainsKey(departament))
                {
                    departmentsS[departament] = new Departments(new List<List<string>>());
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departmentsS[departament].Department.Add(new List<string>());
                    }
                }

                bool isFree = Check(departmentsS, departament);
                if (isFree)
                {
                    int room = 0;
                    doctors[fullName].Patients.Add(patients);
                    for (int rooms = 0; rooms < departmentsS[departament].Department.Count; rooms++)
                    {
                        if (departmentsS[departament].Department[rooms].Count < 3)
                        {
                            room = rooms;
                            break;
                        }
                    }
                    departmentsS[departament].Department[room].Add(patients);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
          
            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departmentsS[args[0]].Department.Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    Console.WriteLine(string.Join("\n", departmentsS[args[0]].Department[room - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].Patients.OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }

        private static bool Check(Dictionary<string, Departments> departmentsS, string departament)
        {
            return departmentsS[departament].Department.SelectMany(x => x).Count() < 60;
        }
    }
}
