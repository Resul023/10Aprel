using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        public List<Book> BookList { get; set; } = new List<Book>();
        public List<Book> FilterByPrice(double MinPrice,double MaxPrice) 
        {
            /*(Book x) => x.Price > MinPrice && x.Price < MaxPrice)*/
             List<Book> NewBookList = new List<Book>();
            foreach (var book in BookList.FindAll(x=> x.Price> MinPrice && x.Price< MaxPrice))
            {                
                    NewBookList.Add(book);
            }
            return NewBookList ;



        }
        public List<Book> FilterByGenre(TypeOfGenre Type) 
        {
            List<Book> NewBookList = new List<Book>();
            foreach (var book in BookList.FindAll((Book x) => x.Genre == Type))
            {
                
                    NewBookList.Add(book);
                
            }return NewBookList;

        }
        public List<Book> FindBookByNo(int no) 
        {
            List<Book> NewBookList = new List<Book>();
            foreach (var book in BookList.FindAll((Book x) => x.No == no))
            {
                    NewBookList.Add(book);   
            }
            return NewBookList;

        }

        public bool IsExistBookByNo(int no) 
        {

            if (BookList.Exists((x)=> x.No == no))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveAll(Predicate<Book> predicate) 
        {

            foreach (var item in BookList)
            {
                if (predicate(item))
                {
                    BookList.Remove(item);
                    break;
                }
            }
            
        
        }
    }
}
