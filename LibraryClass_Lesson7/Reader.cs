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
        public List<string> TakenBookIDs { get; set; } //для хранения  idKниг которые он взял.

        public Reader(string nameReader)
        {
            NameReader = nameReader;
            ReaderID = Guid.NewGuid().ToString();
            TakenBookIDs = new List<string>();
        }

        public string TakeBook(string keyBook, Library library)
        {
            TakenBookIDs.Add(library.GetBookId(keyBook));
            return "Книгу взял.";
        }
        public void BackBook(string keyBook, Library library)
        {
            TakenBookIDs.Remove(library.GetBookId(keyBook));
        }

    }
}
