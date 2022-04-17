﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
    }
}
