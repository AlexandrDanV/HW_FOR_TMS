using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    internal class Employee
    {
        public string NameEmployee { get; set; }
        public Employee(string name) { NameEmployee = name; }

        public string GiveBook(string keyBook, Library library, Reader reader)
        {
            var statusBook = library.GetStatusBook(keyBook);
            if (statusBook is true)
            {
                library.SetStatusBook(keyBook, false, reader.ReaderID);

                return "Книга готова к выдаче!";
            }
            return "Книга уже выдана.";
        }

        public string TakeBookBack(string keyBook, Library library, Reader reader)
        {
            var statusBook = library.GetStatusBook(keyBook);           
            if (statusBook is false)
            {
                library.SetStatusBook(keyBook, true, "");
                return "Книга возвращена!";
            }
            return "Книга в картотеке не числится!";
        }





    }





}

