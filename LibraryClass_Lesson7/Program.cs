// See https://aka.ms/new-console-template for more information
using LibraryClass_Lesson7;
//1. Создаем библиотеку и заполняем её книгами.
Library library = new Library();

library.AddBook("Война и мир", "Война и мир, 1 том", "Лев Толстой", Genre.Classic);
library.AddBook("Война миров", "Война миров", "Герберт Уэллс", Genre.Fantastic);
library.AddBook("Война и мир", "Война и мир, 2 том", "Лев Толстой", Genre.Classic);
library.AddBook("Анна Каренина", "Анна Каренина", "Лев Толстой", Genre.Classic);
library.AddBook("Психбольница в руках пациентов. Алан Купер об интерфейсах", "Психбольница в руках пациентов. Алан Купер об интерфейсах", "Алан Купер", Genre.Programming);

Employee employee = new Employee("Tanya");
Reader reader1 = new Reader("Vanya");
var books = library.FindBook("Война миров");
var keyBook = "";
foreach (var book in books)
{
    Console.WriteLine($"Книга - {book.NameBook}, автор - {book.Autor}");
    keyBook = book.Key_Book;
}
//выдаем книгу
var giveBook = employee.GiveBook(keyBook, library, reader1);
var takeBook = reader1.TakeBook(keyBook, library);
Console.WriteLine(giveBook);
// возвращаем книгу
var backBook = employee.TakeBookBack(keyBook, library, reader1);
Console.WriteLine(backBook);

Console.ReadLine();