using System;
using System.Collections.Generic;
using System.Text;

namespace GoodBooks.Data.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }

        public virtual Book Book { get; set; }
    }
}
