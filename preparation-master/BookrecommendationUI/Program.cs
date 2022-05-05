using BookBussinessLayer;
using BookDataAccessLayer;
using BookDataTransferLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookrecommendationUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            BookBL blObj = new BookBL();
            List<BookDTO> bd = blObj.DisplayReviewFortheBook("The Little Prince");
            {
                foreach(BookDTO p in bd)
                {
                    Console.WriteLine(p.Book_isbn);
                    Console.WriteLine(p.title);
                    Console.WriteLine(p.rating);
                    Console.WriteLine(p.Reviews);

                }
                Console.WriteLine("Average ratings of book");

                BookBL averageObj = new BookBL();
                double average = averageObj.AverageOfRatings("The Little Prince");
                Console.WriteLine(average);
                Console.WriteLine("Display Book Detials");

                BookBL dObj = new BookBL();
                List<BookDTO> display = dObj.DisplayBooks("The Little Prince",55202,1,2);
                foreach(BookDTO dis in display)
                {
                    Console.WriteLine(dis.Book_isbn + "" + dis.title+""+dis.book_edition+""+dis.author_id);
                    Console.WriteLine();



                }
            }
           /* int returnValue = blObj.connectToDB();
            try
            {
                if (returnValue == 1)
                {
                    Console.WriteLine("Connection is successful");
                    title = Console.ReadLine();
                    

                }
                else
                {
                    Console.WriteLine("Connection is not successful");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("check");

            }*/
        }
    }
}
