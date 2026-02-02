using System;
using System.Collections.Generic;
using System.Text;

namespace library_mangemant_system
{
    internal class LibraryUser : User
    {
        public override string Name { get; set; }
        public LibrayCard Card { get; set; }

        public LibraryUser(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book, Libaray libaray)
        {
            libaray.borrowBook(book);
        }
    }
}