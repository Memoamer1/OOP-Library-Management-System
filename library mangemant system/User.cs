using System;
using System.Collections.Generic;
using System.Text;

namespace library_mangemant_system
{
    internal abstract class User
    {
        public abstract string Name { get; set; }
        public void displayBook(Libaray libaray)
        {
            libaray.display();
        }
    }
}
