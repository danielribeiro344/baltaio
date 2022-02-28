using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Balta.Enums;

namespace Balta.ContentContext
{
   
        public class Lesson  : Base
        {
            public string Title { get; set; }

            public int OrderClassesLessons { get; set; }

            public int DurationInMinutes { get; set; }

            public EContentLevel Level { get; set; }




    }


}
