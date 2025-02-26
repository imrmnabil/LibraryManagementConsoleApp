using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleApp
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public User? BorrowedBy { get; set; }

        public Book(int id, string title, Author author, string isbn, int year, string publisher, string language, int pages, Genre genre, string description, double price, bool isAvailable) : this(id, title, author)
        {
            ISBN = isbn;
            Year = year;
            Publisher = publisher;
            Language = language;
            Pages = pages;
            Genre = genre;
            Description = description;
            Price = price;
            IsAvailable = isAvailable;
        }

        public Book(int id , string title, Author author): this()
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public Book() {

        }


        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Author: {Author.AuthorName}, ISBN: {ISBN}, Year: {Year}, Publisher: {Publisher}, Language: {Language}, Pages: {Pages}, Genre: {Genre.GenreName}, Description: {Description}, Price: {Price}, IsAvailable: {IsAvailable}";
        }
    }
}
