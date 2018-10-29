namespace BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get => title;
            set
            {
                if (value.Length<3)
                {
                    Exception ex = new ArgumentException("Title not valid!");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                title = value;
            }
        }
        public string Author
        {
            get => author;
            set
            {
                var indexOfSpace = value.IndexOf(' ');

                if (indexOfSpace > 0 && indexOfSpace < value.Length - 1 && char.IsDigit(value[indexOfSpace + 1]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }
        public virtual decimal Price
        {
            get => price;
            set
            {
                if (value <= 0 )
                {
                    Exception ex = new ArgumentException("Price not valid!");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                price = value;
            }
        }
    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}"); ; 
            return sb.ToString().TrimEnd();
        }
    }
}
