using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}

 public class BOOKSCRUD
{
    static List<Book> books = new List<Book>();
    static int nextId = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewAllBooks();
                    break;
                case "3":
                    UpdateBook();
                    break;
                case "4":
                    DeleteBook();
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.WriteLine("\nAdd Book:");
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Book book = new Book
        {
            Id = nextId++,
            Title = title,
            Author = author,
            Year = year
        };

        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    static void ViewAllBooks()
    {
        Console.WriteLine("\nAll Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }

    static void UpdateBook()
    {
        Console.WriteLine("\nUpdate Book:");
        Console.Write("Enter ID of the book to update: ");
        int id = int.Parse(Console.ReadLine());

        Book bookToUpdate = books.Find(b => b.Id == id);
        if (bookToUpdate != null)
        {
            Console.Write("Enter new title: ");
            bookToUpdate.Title = Console.ReadLine();
            Console.Write("Enter new author: ");
            bookToUpdate.Author = Console.ReadLine();
            Console.Write("Enter new year: ");
            bookToUpdate.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Book updated successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void DeleteBook()
    {
        Console.WriteLine("\nDelete Book:");
        Console.Write("Enter ID of the book to delete: ");
        int id = int.Parse(Console.ReadLine());

        Book bookToDelete = books.Find(b => b.Id == id);
        if (bookToDelete != null)
        {
            books.Remove(bookToDelete);
            Console.WriteLine("Book deleted successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}