using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    internal class Library /// как хранилище для книг и учета выданных книг 
    {
        public List<Book> books;  // связь один ко многим

        public List<BookStatus> statusBook;

        public List<Reader> readers; //ид пользователя взявшего книгу
        public int Count { get; set; }

        public Library()
        {
            books = new List<Book>();
            statusBook = new List<BookStatus>();
            readers = new List<Reader>();
        }

        public void AddBook(string nameBook, string autor, Genre genre)
        {
            var idBook = Guid.NewGuid().ToString();

            books.Add(new Book { NameBook = nameBook, Autor = autor, Genre = GetGenre(genre), IdBook = idBook });
            statusBook.Add(new BookStatus() { Book_Id = idBook, isFree = true });
            Count++;
        }
        public void RemoveBook(string nameBook, string autor)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].NameBook == nameBook && books[i].Autor == autor)
                {
                    books.Remove(books[i]);
                }
            }
        }
        //return LIst т.к. могут быть одноименные книги
        public List<Book> FindBookByName(string nameBook)
        {
            var booksForReturn = new List<Book>();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].NameBook == nameBook)
                {
                    booksForReturn.Add(books[i]);
                }
            }
            return booksForReturn;
        }
        public List<Book> FindBookByAutor(string autor)
        {
            var bookForReturn = new List<Book>();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Autor == autor)
                {
                    bookForReturn.Add(books[i]);
                }
            }
            return bookForReturn;
        }
        public int GetIndexBook(string idBook)
        {
            int result = 0;
            for (int index = 0; index < books.Count; index++)
            {
                var book = books[index];
                if (book.IdBook == idBook)
                {
                    result = index;
                    break;
                }
            }
            return result;
        }


        private string GetGenre(Genre genre)
        {
            var result = "";
            switch (genre)
            {
                case Genre.Classic:
                    result = "Класическая литература";
                    break;
                case Genre.Science:
                    result = "Научная литература";
                    break;
                case Genre.Art:
                    result = "Искуство";
                    break;
                case Genre.Programming:
                    result = "Программирование";
                    break;
                case Genre.Religion:
                    result = "Религия";
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
