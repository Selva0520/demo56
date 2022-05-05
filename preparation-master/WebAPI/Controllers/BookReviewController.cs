using BookBussinessLayer;
using BookDataTransferLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class BookReviewController : ApiController
    {
        BookBL blobj;
        public BookReviewController()
        {
            blobj = new BookBL();
        }
        [HttpGet]
        public HttpResponseMessage GetRatingsForBook()
        {
            try
            {
                List<BookDTO> lstBooks = blobj.DisplayReviewFortheBook();
                if(lstBooks.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,lstBooks);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK,"No data");
                }

    }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
