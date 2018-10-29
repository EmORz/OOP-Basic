
namespace BookShop
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var author = Console.ReadLine();
            var title = Console.ReadLine();
            var price = decimal.Parse(Console.ReadLine());

            try
            {
                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEdition = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book+Environment.NewLine);
                Console.WriteLine(goldenEdition);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
         
        }
    }
}
