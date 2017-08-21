using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book 
    {
        private string title;
        private int year;
        List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.authors = new List<string>(authors);
        }

        public int Year
        {
            get
            {
                return this.year;

            }
            private set
            {
                this.year = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            private set
            {
                this.title = value;
            }
        }

    }

