using System;
using System.Text;

namespace OOPEx
{
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
            get
            {
                return this.title;
            }
            private set
            {
                if (value.Length < 3) throw new ArgumentException("Title not valid!");
                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0) throw new ArgumentException("Price not valid!");
                this.price = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            private set
            {
                var data = value.Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries);
                if(data.Length > 1)
                {
                    var firstName = data[0];
                    var secondName = data[1];
                    if (secondName[0] >= '0' && secondName[0] <= '9')
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
              
                this.author = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }

    }
}
