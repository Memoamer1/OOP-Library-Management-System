using System;
using System.Collections.Generic;
using System.Text;

namespace library_mangemant_system
{
    internal class Libaray
    {
        private Book[] books = new Book[100];
        private int count = 0;
        private Book[] borrowedBooks = new Book[50];
        private int borrowedcount = 0;


        public void display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i].Titel);
            }
        } 

        public void Add(Book book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
                Console.WriteLine("Book added sucessfull");
            }
            else
            {
                Console.WriteLine("library is full, can add new book");
            }
        }
        public void Romove(Book book)
        {
            int index = Array.IndexOf(books, book);
            books[index] = null;
            count--;
            Console.WriteLine("Book removed");

        }
        public void borrowBook(Book book)
        {
            if (borrowedcount < borrowedBooks.Length)
            {
                borrowedBooks[borrowedcount] = book;
                borrowedcount++;
                Console.WriteLine("Book borrowed sucessfull");
            }
            else
            {
                Console.WriteLine("Cannot borrow more books");
            }
        }
    }
}