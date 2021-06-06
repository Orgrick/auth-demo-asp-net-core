using AuthDemo.Resource.Api.Models;
using System;
using System.Collections.Generic;

namespace AuthDemo.Resource.Api.Repository
{
    public interface IBookRepository
    {
        List<Book> getBooks();

        Dictionary<Guid, int[]> getOrders();
    }

    public class BookRepository : IBookRepository
    {
        public List<Book> getBooks()
        {
            return new List<Book>
            {
                new Book{Id = 1, Author = "J. K. Rowling", Titile = "Гарри Поттер и философский камень", Price = 10.45M },
                new Book{Id = 2, Author = "Герман Мелвиль", Titile = "Моби Дик", Price = 8.52M },
                new Book{Id = 3, Author = "Жуль Верн", Titile = "Таинственный Острок", Price = 7.11M },
                new Book{Id = 4, Author = "Карло Колоди", Titile = "Приключения Пиноккио", Price = 6.42M },
            };
        }

        public Dictionary<Guid, int[]> getOrders()
        {
            return new Dictionary<Guid, int[]>
            {
                {Guid.Parse("4134280b-aa8a-45ad-aa98-53da12eabc05"), new int[] { 1,3 } },
                {Guid.Parse("f53d58c1-ab30-4d05-b265-7a9db9efb413"), new int[] { 2,3,4 } }
            };
        }
    }
}
