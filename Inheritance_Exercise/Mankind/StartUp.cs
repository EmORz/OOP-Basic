
namespace Mankind
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] inputStudent = Console.ReadLine().Split();
            string[] inputWorker = Console.ReadLine().Split();

            try
            {
                Student student = new Student(inputStudent[0], inputStudent[1], inputStudent[2]);
                Worker worker = new Worker(inputWorker[0], inputWorker[1], decimal.Parse(inputWorker[2]), double.Parse(inputWorker[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }   



       

        }
    }
}
