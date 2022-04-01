using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    internal class Library
    {
        public List<Book> Book1 = new List<Book>();
       
        
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> NewList = new List<Book>();
            foreach (Book item in Book1)
            {
                if (item.PageCount > min && item.PageCount < max)
                {
                    NewList.Add(item);
                }
            }
            return NewList;
        }
        public void RemoveByCode(int number)
        {
            foreach (Book item in Book1)
            {
                if (item.No == number)
                {
                    Book1.Remove(item);
                }
            }
        }
        public List<Book> SearchBooks(string numStr)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (Book item in Book1)
            {
                string text = item.Name + item.AuthorName + item.PageCount;
                if (text.Contains(numStr))
                {
                    NewBooks.Add(item);
                }
            }
            return NewBooks;
        }
        public void RemoveAllBookByName(string numStr)
        {
            foreach (Book item in Book1)
            {
                if (item.Name.Contains(numStr))
                {
                    Book1.Remove(item);
                }
            }
        }
        public List<Book> FindAllBooksByName(string numStr)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (Book item in Book1)
            {
                if (item.Name.Contains(numStr))
                {
                    NewBooks.Add(item);
                }
            }
            return NewBooks;
        }
    }
}
