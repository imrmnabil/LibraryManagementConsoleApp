using LibraryManagementConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            GenericCRUD<User> users = new GenericCRUD<User>();
            GenericCRUD<Book> books = new GenericCRUD<Book>();
            GenericCRUD<Genre> genres = new GenericCRUD<Genre>();
            GenericCRUD<Author> authors = new GenericCRUD<Author>();
            Operations operations = new Operations();

            while(true)
            {
                
                Console.WriteLine("Welcome to the Library Management System!");
                Console.WriteLine("=====================================");
                Console.WriteLine("Choose A Operation:\n 1. Add Author\n 2. Add Genre \n 3. Add Book \n 4. Borrow Book \n 5. Return Book \n 6. Add User \n 7. Remove User \n 8. Update User \n 9. Get All Users \n 10. Get All Books \n 11. Exit \n");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Author ID:");
                        int authorId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Author Name:");
                        string authorName = Console.ReadLine();
                        Author newAuthor = new Author(authorId, authorName ?? "");
                        authors.Add(newAuthor);
                        break;
                    case 2:
                        Console.WriteLine("Enter Genre ID:");
                        int genreId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Genre Name:");
                        string genreName = Console.ReadLine();
                        Genre newGenre = new Genre(genreId, genreName ?? "");
                        genres.Add(newGenre);
                        break;
                    case 3:
                        Console.WriteLine("Enter Book ID:");
                        int bookId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book Title:");
                        string bookTitle = Console.ReadLine();
                        Console.WriteLine("List of Authors:");
                        authors.GetAll().ForEach(a => Console.WriteLine(a.AuthorId + ": " + a.AuthorName));
                        Console.WriteLine("Enter Author ID:");
                        Author? author = authors.GetAll().FirstOrDefault(a => a.AuthorId == Convert.ToInt32(Console.ReadLine()));
                        books.Add(new Book(bookId, bookTitle ?? "", author));
                        break;
                    case 4:
                        Console.WriteLine("List of Users:");
                        users.GetAll().ForEach(u => Console.WriteLine(u.Id + ": " + u.Name));
                        Console.WriteLine("Enter User ID:");
                        User? user = users.GetAll().FirstOrDefault(u => u.Id == Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("List of Books:");
                        books.GetAll().ForEach(b => Console.WriteLine(b.Id + ": " + b.Title));
                        Console.WriteLine("Enter Book ID:");
                        Book? book = books.GetAll().FirstOrDefault(b => b.Id == Convert.ToInt32(Console.ReadLine()));
                        if (user != null && book != null) operations.BorrowBook(book, user);
                        break;
                    case 5:
                        Console.WriteLine("List of Users:");
                        users.GetAll().ForEach(u => Console.WriteLine(u.Id + ": " + u.Name));
                        Console.WriteLine("Enter User ID:");
                        User? user2 = users.GetAll().FirstOrDefault(u => u.Id == Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("List of Books:");
                        books.GetAll().ForEach(b => Console.WriteLine(b.Id + ": " + b.Title));
                        Console.WriteLine("Enter Book ID:");
                        Book? book2 = books.GetAll().FirstOrDefault(b => b.Id == Convert.ToInt32(Console.ReadLine()));
                        if (user2 != null && book2 != null) operations.ReturnBook(book2, user2);
                        break;
                    case 6:
                        Console.WriteLine("Enter User ID:");
                        int userId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter User Name:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter User Email:");
                        string userEmail = Console.ReadLine();
                        User newUser = new User(userId, userName ?? "", userEmail ?? "");
                        users.Add(newUser);
                        break;
                    case 7:
                        Console.WriteLine("List of Users:");
                        users.GetAll().ForEach(u => Console.WriteLine(u.Id + ": " + u.Name));
                        Console.WriteLine("Enter User ID:");
                        User? user3 = users.GetAll().FirstOrDefault(u => u.Id == Convert.ToInt32(Console.ReadLine()));
                        if (user3 != null) users.Remove(user3);
                        break;
                    case 8:
                        Console.WriteLine("List of Users:");
                        users.GetAll().ForEach(u => Console.WriteLine(u.Id + ": " + u.Name));
                        Console.WriteLine("Enter User ID:");
                        User? user4 = users.GetAll().FirstOrDefault(u => u.Id == Convert.ToInt32(Console.ReadLine()));
                        if (user4 != null)
                        {
                            Console.WriteLine("Enter User Name:");
                            string userName2 = Console.ReadLine();
                            Console.WriteLine("Enter User Email:");
                            string userEmail2 = Console.ReadLine();
                            User updatedUser = new User(user4.Id, userName2 ?? "", userEmail2 ?? "");
                            users.Update(user4, updatedUser);
                        }
                        else
                        {
                            Console.WriteLine("User not found.");
                        }
                        break;
                    case 9:
                        Console.WriteLine("List of Users:");
                        users.GetAll().ForEach(u => Console.WriteLine(u.Id + ": " + u.Name));
                        break;
                    case 10:
                        Console.WriteLine("List of Books:");
                        books.GetAll().ForEach(b => Console.WriteLine(b.Id + ": " + b.Title));
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}