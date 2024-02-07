using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = "Anita desai";
            book.Title = "Village by the sea";

            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);

            Console.ReadLine();

        }
    }
}
