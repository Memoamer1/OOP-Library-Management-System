using System;
using System.Collections.Generic;
using System.Text;

namespace library_mangemant_system
{
    internal class Librarian : User
    {
        private string _name;
        public override string Name
        {
            get => _name;
            set => _name = value;
        }

        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Book newbook, Libaray libaray)
        {
            libaray.Add(newbook);
        }
        public void RemoveBook(Book newbook, Libaray libaray)
        {
            libaray.Romove(newbook);
        }
    }
}