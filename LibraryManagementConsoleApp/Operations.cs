using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleApp
{
    class Operations : IOperations
    {
        public void BorrowBook(Book book, User user)
        {
            if(book.IsAvailable)
            {
                book.IsAvailable = false;
                book.BorrowedBy = user;

                Console.WriteLine("Book is borrowed by {0}", user.Name.ToUpper());
            }
            else 
            {
                Console.WriteLine("Book is not available.");
            }
        }

        public void ReturnBook(Book book, User user)
        {
            if(book.IsAvailable == false && book.BorrowedBy == user)
            {
                book.IsAvailable = true;
                book.BorrowedBy = null;
            }
            else
            {
                Console.WriteLine("Book is not borrowed by {0}", user.Name.ToUpper());
            }
        }
    }
}
