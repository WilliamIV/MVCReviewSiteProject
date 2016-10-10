using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime TravelDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("Resort")]
        public int ResortID { get; set; }
        public virtual Resort Resort { get; set; }
    }
}