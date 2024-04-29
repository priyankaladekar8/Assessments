using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.CRUDoperations
{

    class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int year { get; set; }


         public class BookMain
        {
            static List<Book> books = new List<Book>();

            static int nextId = 1;
            static void Main()
            {

                while (true)
                {
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2.view all Books");
                    Console.WriteLine("3. Update Book");
                    Console.WriteLine("4.Delete Book");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Enter your choice");

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
                            Console.WriteLine("Exiting program");
                            return;
                        default:
                            Console.WriteLine("Invalid choice please try again");

                            break;


                    }
                }
                }
                static void AddBook()
                {
                    Console.WriteLine("\nAdd Book: ");
                    Console.Write("Enter tittle");
                    string title = Console.ReadLine();

                    Console.Write("Enter author :");
                    string author = Console.ReadLine();

                    Console.WriteLine("Enter year: ");
                    int year = int.Parse(Console.ReadLine());

                    Book book = new Book
                    {
                        id = nextId++,
                        Title = title,
                        Author = author,
                        year = year
                    };
                    books.Add(book);
                    Console.WriteLine("book added successfully");
                    Console.WriteLine("-------------------------------------------------------");

                }
                static void ViewAllBooks()
                {
                    Console.WriteLine("\nAll Books: ");
                    foreach (var book in books)
                    {
                        Console.WriteLine($"Id: {book.id}, Tittle: {book.Title}, Author: {book.Author}, year: {book.year}");
                        Console.WriteLine("---------------------------------------------------------");
                    }

                }

                static void UpdateBook()
                {
                    Console.WriteLine("\nUpdate Books: ");
                    Console.Write("Enter id of the book to update");
                    int id = int.Parse(Console.ReadLine());

                    Book bookToUpdate = books.Find(books => books.id == id);

                    if (bookToUpdate != null)
                    {
                        Console.Write("enter new title: ");
                        bookToUpdate.Title = Console.ReadLine();

                        Console.Write("Enter new Author");
                        bookToUpdate.Author = Console.ReadLine();


                        Console.Write("Enter new year :");
                        bookToUpdate.year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Book update successfully");
                        Console.WriteLine("--------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("book not found");
                    }
                }

                static void DeleteBook()
                {
                    Console.WriteLine("\nDelete book");

                    Console.Write("Enter id of the book to delete ");
                    int id = int.Parse(Console.ReadLine());

                    Book bookToDelete = books.Find(b => b.id == id);
                    if (bookToDelete != null)
                    {
                        books.Remove(bookToDelete);

                        Console.WriteLine("Book deleted successfully :");
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }

                }
            }
        }

    }
        