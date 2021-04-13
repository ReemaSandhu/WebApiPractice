using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebAPIsEntities.Entities.BookDatabase
{
    public class BookData
    {
        [Key]
        public long BookID { get; set; }

        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public long PublishedYear { get; set; }
        public long Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }
    }
}
