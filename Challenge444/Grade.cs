using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge444
{
    class Grade
    {
        //Properties
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        //properties linked with other classes
        public ICollection<Student> Students { get; set; }
    }
}
