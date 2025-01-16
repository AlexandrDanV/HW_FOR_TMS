using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    internal class Book // описывает одну книгу
    {
        public string NameBook { get; set; }
        public string Autor { get; set; }
        public string Genre { get; set; }
        public string IdBook { get; set; }
        public string Key_Book { get; set; }

        public void OpenBook()
        {
            Console.WriteLine("The book is open!");
        }
        public void CloseBook()
        {
            Console.WriteLine("The book is close");
        }

    }
}
