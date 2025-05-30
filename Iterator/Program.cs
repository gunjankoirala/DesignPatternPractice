using System;
using System.Collections.Generic;


public class Book
{
    public string Title { get; private set; }

    public Book(string title)
    {
        Title = title;
    }
}


public interface IBookIterator
{
    bool HasNext();
    Book Next();
}


public interface IBookCollection
{
    IBookIterator CreateIterator();
}


public class BookCollection : IBookCollection
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book GetBookAt(int index)
    {
        return books[index];
    }

    public int Count
    {
        get { return books.Count; }
    }

    public IBookIterator CreateIterator()
    {
        return new BookIterator(this);
    }
}


public class BookIterator : IBookIterator
{
    private BookCollection collection;
    private int current = 0;

    public BookIterator(BookCollection collection)
    {
        this.collection = collection;
    }

    public bool HasNext()
    {
        return current < collection.Count;
    }

    public Book Next()
    {
        return collection.GetBookAt(current++);
    }
}


class Program
{
    static void Main(string[] args)
    {
        BookCollection myBooks = new BookCollection();
        myBooks.AddBook(new Book("Norwegian Woods"));
        myBooks.AddBook(new Book("Kafka on the shore"));
        myBooks.AddBook(new Book("Harry Potter and the Sorcerer's Stone"));

        IBookIterator iterator = myBooks.CreateIterator();

        Console.WriteLine("Books in your collection:");
        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine("- " + book.Title);
        }
    }
}

