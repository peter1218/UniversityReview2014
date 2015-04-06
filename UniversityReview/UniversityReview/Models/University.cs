using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityReview.Models
{
    public class University
    {
        //peter
        //feature 2.2 created
        //feature 2.2
        // master c hange added
        //master second change
        public int Id { get; set; }
        public string Name{get;set;}
        public string City{get;set;}
        public virtual ICollection<UniversityReviews> Reviews { get; set; }
    }
}