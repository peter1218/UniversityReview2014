﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityReview.Models
{
    public class UniRatingDB : DbContext
    {
       
        //hello
        public UniRatingDB()
            : base("name=DefaultConnection")
        {

        }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<UniversityReviews> Reviews { get; set; }
    }
}