using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Models.Task_4
{
    public class Book : ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public int AvailableCopies { get; set; }

        public Book(string title, string author, int availableCopies)
        {
            Title=title;
            Author=author;
            AvailableCopies=availableCopies;
        }

        public void CheckOut()
        {
            if (AvailableCopies<=0) Console.WriteLine("This copy doesn't exist");
            else AvailableCopies--;
            Console.WriteLine($"Available copy count : {AvailableCopies}");
        }

        public void Return()
        {
            AvailableCopies++;
            Console.WriteLine($"Available copy count : {AvailableCopies}");
        }
    }
}
