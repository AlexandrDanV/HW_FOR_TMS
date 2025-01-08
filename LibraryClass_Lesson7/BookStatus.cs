using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass_Lesson7
{
    internal class BookStatus //описание состояния книги
    {
        public bool isFree { get; set; } //свободна или нет
        public string Book_Id { get; set; }
        public string Readers_Id { get; set; }

    }
}
