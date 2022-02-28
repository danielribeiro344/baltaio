﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses { 
            
            
            get
            
            {

                return Items.Count;
            
            } 
        }
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

       

    }
    
}
