using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_Offered_Course
{

    class Course
    {
        public string Name { get; set; }
        public HashSet<int> Prerequisites { get; set; }
        public int CourseCredit { get; set; }
        public int CourseType { get; set; }
        public int CourseDept { get; set; }

    }
}
