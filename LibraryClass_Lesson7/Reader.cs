using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    //где лучше хранить коллекцию читателей???
    internal class Reader
    {
        public string NameReader { get; set; }
        public string ReaderID { get; set; }
        public List<string> TakenBookID { get; set; } //для хранения  idKниг которые он взял.

        public Reader(string nameReader)
        {
            NameReader = nameReader;
            ReaderID = Guid.NewGuid().ToString();
            TakenBookID = new List<string>();
        }

        public string TakeBook(string keyBook, Library library)
        {
            TakenBookID.Add(library.GetBookId(keyBook));
            return "Книгу взял.";
        }
        public void BackBook(string keyBook, Library library)
        {
            TakenBookID.Remove(library.GetBookId(keyBook));
        }

    }
}
