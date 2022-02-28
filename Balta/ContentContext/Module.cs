using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
  
        public class Module : Base
        {
            public string Title { get; set; }

            public int OrderClasses { get; set; }

            public IList<Lesson> Lessons { get; set; }

            public Module()
            {
                Lessons = new List<Lesson>();
            }


        }
    
}
