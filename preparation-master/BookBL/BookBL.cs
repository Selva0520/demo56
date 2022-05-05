using BookDataAccessLayer;
using BookDataTransferLayer;
using DemoDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBussinessLayer
{
    public class BookBL
    {
        DemoDal DemoDalObj;
        public BookBL()
        {
            DemoDalObj = new DemoDal();

        }
        //string title
        public List<BookDTO> DisplayReviewFortheBook()
        {
            List<BookDTO> d = DemoDalObj.DisplayReviewFortheBook();
            return d;
        }
        public double AverageOfRatings(string title)
        {
            try
            {
                DemoDal avgObj = new DemoDal();
                return avgObj.AverageOfRatings(title);
            }
            catch (Exception)
            {
                return -99;
            }
        }
        public List <BookDTO> DisplayBooks(string title,int book_isbn,int edition, int author_ID)
        {
            try
            {
                DemoDal dObj = new DemoDal();
                return dObj.DisplayBooks(title,book_isbn,edition,author_ID);
            }
            catch (Exception)
            {
                return null;
            }
        }
        

        }

/*        public int connectToDB()
        {
            try
            {
                return DemoDalObj.ConnectToDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int getBookCount()
        {
            try
            {
                return DemoDalObj.getBookCount();
            }
            catch (Exception)
            {
                return 0;
            }*/
        }
  
