using System;
using library_mangemant_system;

namespace heloo
{
    internal class FileProgram
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");

            Libaray libaray = new Libaray();

            Console.WriteLine("Are you librarian or regular user (L or R)");
            char x = Console.ReadLine().ToUpper()[0];

            Librarian l1 = null; // Declare l1 outside the if block

            if (x == 'L')
            {
                Console.WriteLine("Enter your name");
                string librarianName = Console.ReadLine();

                l1 = new Librarian(librarianName);
                Console.WriteLine($"Welcome {l1.Name}");

                while (true)
                {
                    Console.WriteLine("Choose: Add Book (A) / Remove Book (R) / Display Books (D)");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book title:");
                            string bookName = Console.ReadLine();

                            Console.WriteLine("Enter author:");
                            string bookAuthor = Console.ReadLine();

                            Console.WriteLine("Enter year:");
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book
                            {
                                Titel = bookName,
                                Author = bookAuthor,
                                year = bookYear.ToString()
                            };

                            l1.AddBook(book, libaray);
                            break;

                        case 'R':
                            Console.WriteLine("Enter book title:");
                            bookName = Console.ReadLine();

                            Console.WriteLine("Enter author:");
                            bookAuthor = Console.ReadLine();

                            Console.WriteLine("Enter year:");
                            bookYear = Convert.ToInt32(Console.ReadLine());

                            book = new Book
                            {
                                Titel = bookName,
                                Author = bookAuthor,
                                year = bookYear.ToString()
                            };

                            l1.RemoveBook(book, libaray);
                            break;

                        case 'D':
                            Console.WriteLine("Books in the library:");
                            libaray.display();
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (x == 'R')
            {
                // Regular user logic
                Console.WriteLine("Welcom user, Enter your name");
                string name = Console.ReadLine();
                LibraryUser user = new LibraryUser(name);
                Console.WriteLine($"Welcome {user.Name}");
                while (true)
                {
                    Console.WriteLine("Choose:Display Books (D) / Borrow Book (B)");
                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("Books in the library:");
                            libaray.display();
                            break;
                        case 'B':
                            Console.WriteLine("Enter book details borrow:");
                            string bookName = Console.ReadLine();

                            Console.WriteLine("Enter author:");
                            string bookAuthor = Console.ReadLine();

                            Console.WriteLine("Enter year:");
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book
                            {
                                Titel = bookName,
                                Author = bookAuthor,
                                year = bookYear.ToString()
                            };

                            user.BorrowBook(book, libaray);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter correct value (L or R)");
            }
        }
    }
}
