using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDataTransferLayer
{
    public class BookDTO
    {
        public string Authors { get; set; }

        public string Books { get; set; }

        public string Reviews { get; set; }

        public int Book_isbn { get; set; }

        public string title { get; set; }

        public int book_edition { get; set; }

        public int author_id { get; set; }

        public int rating { get; set; }
    }
}
