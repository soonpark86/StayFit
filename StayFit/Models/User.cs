﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StayFit.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Excercise> Excercises { get; set; }
    }
}