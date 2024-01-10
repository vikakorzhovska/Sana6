using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CourseException : Exception
    {
        public int Course {  get; set; }
        public CourseException(int course, string message) : base(message)
        {
            Course = course;
        }
    }
}
