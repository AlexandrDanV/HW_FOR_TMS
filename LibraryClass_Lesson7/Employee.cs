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

        public string GiveBookToReader(string idBook, Library library, Reader reader)
        {
            var index = library.GetIndexBook(idBook);
            var statusBook = library.statusBook[index].isFree;
            if (statusBook is true)
            {
                library.statusBook[index].isFree = false;
                library.statusBook[index].Readers_Id = reader.Id_Reader;
                reader.TakeBook(idBook);                                // может лучше убрать в управляющий код?????
                return $"Книга {library.books[index].NameBook} - выдана читателю {reader.NameReader}.";
            }
            return $"Книга {library.books[index].NameBook}, {library.books[index].Autor} уже выдана. " +
                $"ID читателя - {library.statusBook[index].Readers_Id} ";
        }

        public string TakeBookBack(string idBook, Library library, Reader reader)
        {
            var index = library.GetIndexBook(idBook);
            var statusBook = library.statusBook[index].isFree;
            if (statusBook is false)
            {
                library.statusBook[index].isFree = true;
                library.statusBook[index].Readers_Id = "";
                reader.BackBook(idBook);                                   // может лучше убрать в управляющий код?????
                return $"Книга {library.books[index].NameBook} возвращена";
            }
            return "Книга в картотеке не числится!";
        }





    }
}
