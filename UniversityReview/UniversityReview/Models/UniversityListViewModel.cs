﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityReview.Models
{
    public class UniversityListViewModel
    {
        //hello 3 added
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CountOfReviews { get; set; }
    }
}