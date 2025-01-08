// See https://aka.ms/new-console-template for more information

using LibraryClass_Lesson7;

Library library = new Library();
library.AddBook("Война и мир", "Лев Толстой", Genre.Classic);
library.AddBook("Анна Каренина", "Лев Толстой", Genre.Classic);
library.AddBook("Психбольница в руках пациентов. Алан Купер об интерфейсах", "Алан Купер", Genre.Programming);
library.AddBook("Идеальный программист. Как стать профессионалом разработки ПО", "Роберт Мартин", Genre.Programming);


Employee employee = new Employee("Tanya");
Reader reader1 = new Reader("Vanya");
var book = library.FindBookByName("Анна Каренина");
var idBook = "";
foreach (var item in book)
{
    Console.WriteLine($"Книга - {item.NameBook}, автор - {item.Autor}");
    idBook = item.IdBook;
}
//выдаем книгу
var giveBook = employee.GiveBookToReader(idBook, library, reader1);
Console.WriteLine(giveBook);
// возвращаем книгу
var backBook = employee.TakeBookBack(idBook, library, reader1);
Console.WriteLine(backBook);

Console.ReadLine();