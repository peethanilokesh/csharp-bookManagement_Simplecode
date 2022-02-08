using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_assessment_1
{   
    class book
    {
        public int id;
        public string title;
        public string author;
        public double rating;
        public double price;
        public book(List<book> bookstore)
        {
            try
            {
                this.id = bookstore.Count == 0 ? 100 : bookstore.Max(b => b.id) + 1;
                Console.WriteLine("Give book title");
                this.title = Console.ReadLine();
                Console.WriteLine("Give author name");
                this.author = Console.ReadLine();
                Console.WriteLine("Give book rating");
                this.rating = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Give book price");
                this.price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Book is added Thankyou");
            }
            catch(Exception e)
            {
                Console.WriteLine("Give inputs properly");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<book> bookstore = new List<book>();
            while (true)
            {
                Console.WriteLine("Type no if u dont want to use bookstore , type anything for yes");
                string option = Console.ReadLine();
                if(option == "no")
                {
                    break;
                }
                Console.WriteLine("Pick a choice (type numbers [1-5])");
                Console.WriteLine("1 to Add a book\n2 to View all the books in store\n3 to search book by author\n4 to search book by rating \n5 to delete book by id");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        bookstore.Add(new book(bookstore));
              
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Books available:");
                        foreach(book book in bookstore)
                        {
                            Console.WriteLine(book.id+"   "+book.title+"   "+book.author+"   "+book.rating+"   "+book.price);

                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Give author name");
                        string authorname = Console.ReadLine();
                        List<book> booksbyauthor = bookstore.FindAll(b => b.author == authorname);
                        foreach (book book in booksbyauthor)
                        {
                            Console.WriteLine(book.id + "   " + book.title + "   " + book.author + "   " + book.rating + "   " + book.price);
                        }
                        if (booksbyauthor.Count == 0)
                        {
                            Console.WriteLine("Book doesnt exist");
                        }
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Give The book rating");
                        double bookrating = Convert.ToDouble(Console.ReadLine());
                        List<book> booksbyrating = bookstore.FindAll(b => b.rating ==bookrating);
                        foreach (book book in booksbyrating)
                        {
                            Console.WriteLine(book.id + "   " + book.title + "   " + book.author + "   " + book.rating + "   " + book.price);
                        }
                        if (booksbyrating.Count == 0)
                        {
                            Console.WriteLine("Book doesnt exist");
                        }
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Give the book id to be deleted");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if(bookstore.RemoveAll(b => b.id == id)==0)
                        {
                            Console.WriteLine("Book doesnt exists");
                        }
                        foreach (book book in bookstore)
                        {
                            Console.WriteLine(book.id + "   " + book.title + "   " + book.author + "   " + book.rating + "   " + book.price);

                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Give inputs properly");
                }
            }
          

        }
    }
}
