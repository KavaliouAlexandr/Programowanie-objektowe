using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_5
{
    public record Book(string Title, string Author);
    class Library: IEnumerable<Book>
    {
        private Book[] _books =
        {
            new Book("C#", "Freeman"),
            new Book("Asp.net", "Pipka"),
            null,
            new Book("Pipkabook", "Pupa"),


        };
        public IEnumerator<Book> GetEnumerator()
        {
            return new BookEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        object IEnumerator.Current => Current;


        public void Disponse()
        {
        throw new NotImplementedException();
        }
    }
    


  class Program
    {
        static void Main(string[] args)
        {
           

            Library books = new Library();
            IEnumerator<Book> enumerator = books.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            for(var e = books.GetEnumerator(); e.MoveNext();)
            {
                Console.WriteLine(e.Current);
            }
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
        }

    }


}