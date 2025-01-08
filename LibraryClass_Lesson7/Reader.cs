using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    internal class Reader
    {
        public string NameReader { get; set; }
        public string Id_Reader { get; set; }
        public List<string> IdTakenBook { get; set; } //для хранения  idKниг которые он взял.

        public Reader(string nameReader)
        {
            NameReader = nameReader;
            Id_Reader = Guid.NewGuid().ToString();
            IdTakenBook = new List<string>();
        }

        public void TakeBook(string idBook)
        {
            IdTakenBook.Add(idBook);
        }
        public void BackBook(string idBook)
        {
            IdTakenBook.Remove(idBook);
        }

    }
}
