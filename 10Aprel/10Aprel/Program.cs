using System;
using ClassLibrary;
using System.Collections.Generic;
namespace _10Aprel

{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
           
            Library newLibrary = new Library();
            Book newBookdilqem = new Book();
            Predicate<Book> predicateInMain = x => x.Name.Length > 5;
            do
            {
                Console.WriteLine("1-Add Book \n2-Filter by Genre \n3-Find book Price \n4-Find book by No\n5-Exist book \n6-Remove book \n7-Stop Process\n8-Book list count for Tester");
                int answer = Convert.ToInt32(Console.ReadLine());

                

                switch (answer)
                {
                    case 1:
                        

                        Console.WriteLine("Write Book Name:");
                        string nameBook = Console.ReadLine();
                        Console.WriteLine("Write Price:");
                        double bookPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Type of Genre");
                        foreach (var item in Enum.GetValues(typeof(TypeOfGenre)))
                        {
                            Console.WriteLine((byte)item + " " + item);
                        }
                        byte typeOfGenre = Convert.ToByte(Console.ReadLine());
                        TypeOfGenre selected = (TypeOfGenre)typeOfGenre;
                        
                        while (!Enum.IsDefined(typeof(TypeOfGenre), selected))
                        {
                            Console.WriteLine("This value is not match with condition");    
                            typeOfGenre = Convert.ToByte(Console.ReadLine());
                            selected = (TypeOfGenre)typeOfGenre;
                        }
                        Book newBook = new Book()
                        {
                            Name = nameBook,
                            Price = bookPrice,
                            Genre = selected
                        
                        };

                        newLibrary.BookList.Add(newBook);
                        Console.WriteLine(newLibrary.BookList.Count);

                        break;
                        
                    case 2:

                        foreach (var item in Enum.GetValues(typeof(TypeOfGenre)))
                        {
                            Console.WriteLine((byte)item + " " + item);
                        }
                        Console.WriteLine("Search type for Genre");
                        byte typeOfGenreForSearch = Convert.ToByte(Console.ReadLine());
                        TypeOfGenre selectedForSearch = (TypeOfGenre)typeOfGenreForSearch;
                        foreach (var book in newLibrary.FilterByGenre(selectedForSearch))
                        {
                            Console.WriteLine(book.Name + "-" + book.Price + "-" + book.Genre);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Write min price");
                        double minPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Write max price");
                        double maxPrice = Convert.ToDouble(Console.ReadLine());
                        foreach (var book in newLibrary.FilterByPrice(minPrice, maxPrice))
                        {
                            Console.WriteLine(book.Name + "-" + book.Price + "-" + book.Genre);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Write No");
                        int findNo = Convert.ToInt32(Console.ReadLine());
                        foreach (var book in newLibrary.FindBookByNo(findNo))
                        {
                            Console.WriteLine(book.Name + "-" + book.Price + "-" + book.Genre);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Write No");
                        int existNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(newLibrary.IsExistBookByNo(existNo));
                        break;
                    case 6:
                        newLibrary.RemoveAll(predicateInMain);

                        break;
                    case 7:
                        check = false;

                        break;
                    case 8:
                        Console.WriteLine(newLibrary.BookList.Count);
                        break;
                }

            } while (check);

           
        }
    }
}
