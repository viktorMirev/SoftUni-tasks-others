using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace softUni
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Prise { get; set; }
        public Book (string title, string author, string publisher, DateTime release, string isbn, double prise)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = release;
            this.ISBN = isbn;
            this.Prise = prise;
        }
    }
    public class Lybrary
    {
        public string Name { get; set; }
        public List<Book> books { get; set; }
        public Dictionary<string, double> Authors {get; set;}
        public Lybrary(string Name)
        {
            this.Name = Name;
            books = new List<Book>();
            Authors = new Dictionary<string, double>();
        }
        public void GetAuthors()
        {
            foreach (var item in books)
            {
                if (!Authors.ContainsKey(item.Author))
                {
                    Authors.Add(item.Author, 0);
                }
                Authors[item.Author] += item.Prise;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Lybrary = new Lybrary("MyLybrary");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ');
                Book currBook = new Book(command[0],command[1],command[2],DateTime.ParseExact(command[3],"dd.MM.yyyy",CultureInfo.InvariantCulture),command[4], double.Parse(command[5]));
                Lybrary.books.Add(currBook);
            }
            var Date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            //Lybrary.GetAuthors();
            foreach (var item in Lybrary.books.OrderBy(b=>b.ReleaseDate).ThenBy(b=>b.Title))
            {
                if (item.ReleaseDate>Date)
                {
                    Console.WriteLine(item.Title + " -> "+ item.ReleaseDate.ToString("dd.MM.yyyy"));
                }
            }
        }
    }
}
