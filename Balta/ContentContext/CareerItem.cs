﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class CareerItem : Base
    {
       

        public int Order { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public Course Course { get; set; }


        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;

            //if (course == null)
            //{
            //    throw new System.Exception("O curso não pode ser nulo!");
            //}
        }



    }
}
