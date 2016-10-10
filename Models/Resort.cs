using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Resort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}