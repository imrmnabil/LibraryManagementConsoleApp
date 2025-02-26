using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleApp
{
    interface IOperations
    {
        void BorrowBook(Book book, User user);
        void ReturnBook(Book book, User user);


    }
}
