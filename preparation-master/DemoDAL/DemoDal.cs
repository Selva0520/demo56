using BookDataTransferLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoDAL
{
    public class DemoDal
    {
        BookRecomendationEntities bookContextObj;

        public DemoDal()
        {
            bookContextObj = new BookRecomendationEntities();
        }

        public List<BookDTO> DisplayReviewFortheBook()

        {
            try
            {
                var lstBookReview = (from r in bookContextObj.Reviews
                                     join b in bookContextObj.Books on r.book_isbn equals b.book_isbn
                                 /*    where b.title.Contains(title)*/

                                     select new
                                     {
                                         b.book_isbn,
                                         b.title,
                                         r.rating,
                                         r.review1
                                     }).ToList();

                List<BookDTO> result = new List<BookDTO>();
                foreach (var item in lstBookReview)
                {
                    result.Add(new BookDTO()
                    {
                        title = item.title,
                        Book_isbn = item.book_isbn,
                        rating = item.rating,
                        Reviews = item.review1

                    });
                    
                }
                return result;

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public double AverageOfRatings(string title)
        {
            try
            {
                var AvgRating = (from r in bookContextObj.Reviews
                                 join b in bookContextObj.Books on r.book_isbn equals b.book_isbn
                                 select r.rating).Average();
                return AvgRating;                    
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<BookDTO>DisplayBooks(string title, int book_isbn, int edition ,int author_ID)
        {
            try
            {
                var lstBookDetials =(from b in bookContextObj.Books
                                     select new
                                     {
                                         b.title,
                                         b.book_isbn,
                                         b.book_edition,
                                         b.author_id
                                     }).ToList();
                List<BookDTO> displayObj = new List<BookDTO>();
                foreach(var Book in lstBookDetials)
                {
                    displayObj.Add(new BookDTO()
                    {
                        title = Book.title,
                        Book_isbn = Book.book_isbn,
                        book_edition = Book.book_edition,
                        author_id = Book.author_id
                    });

                }
                return displayObj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

