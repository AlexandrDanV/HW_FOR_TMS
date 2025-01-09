using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    /// чтобы найти книгу по автору (а ключ название книги) нода еще один словарь? Или перебор

    internal class Library /// как хранилище для книг и учета выданных книг 
    {
        Dictionary<string, List<Book>> booksDict = new Dictionary<string, List<Book>>();
        Dictionary<string, List<BookStatus>> statusB = new Dictionary<string, List<BookStatus>>();
        public void AddBook(string key_nameBook, string nameBook, string autor, Genre genre)
        {
            var idBook = Guid.NewGuid().ToString();
            if (booksDict.ContainsKey(key_nameBook) is false)
            {
                booksDict[key_nameBook] = new List<Book>();
            }
            booksDict[key_nameBook].Add(new Book { IdBook = idBook, NameBook = nameBook, Autor = autor, Genre = GetGenre(genre), Key_Book = key_nameBook });
            if (statusB.ContainsKey(key_nameBook) is false)
            {
                statusB[key_nameBook] = new List<BookStatus>();
            }
            statusB[key_nameBook].Add(new BookStatus() { Book_Id = idBook, isFree = true });
        }
        public bool GetStatusBook(string key_nameBook)

        {
            var isFree = false;
            foreach (var item in statusB[key_nameBook])
            {
                isFree = item.isFree;
            }
            return isFree;
        }
        public string GetBookId(string key_nameBook)
        {
            var bookId = "";
            foreach (var item in booksDict[key_nameBook])
            {
                bookId = item.IdBook;
            }
            return bookId;
        }

        public void SetStatusBook(string key_nameBook, bool newStatus, string readersId)
        {
            foreach (var item in statusB[key_nameBook])
            {
                item.isFree = newStatus;
                item.Readers_Id = readersId;
            }
        }

        public string RemoveBook(string keyBook)
        {
            return (booksDict.Remove(keyBook)) ? "Книга удалена" : "Ошибка удаления из архива";
            
        }

        public List<Book> FindBook(string nameBook)
        {
            return booksDict.ContainsKey(nameBook) ? booksDict[nameBook] : null;
        }

        string GetGenre(Genre genre) => genre switch
        {
            Genre.Classic => "Класическая литература",
            Genre.Science => "Научная литература",
            Genre.Art => "Искуство",
            Genre.Programming => "Программирование",
            Genre.Religion => "Религия",
            Genre.Fantastic => "Фантастика",

        };

    }
}
