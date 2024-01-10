using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student : People
    {
        protected int _course;
        public int Course {
            get
            {
                return _course;
            }
            set
            {
                if (value >= 1 && value <= 4)
                    _course = value;
                else
                    throw new CourseException(value, "Курс може бути від 1 по 4");
            }
            }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int course, string group, string faculty, string university) : base(firstName, lastName, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public override string ShowInfo()
        {
            return $"{LastName} {FirstName} {DateOfBirth} {Course} {Group} {Faculty} {University}";
        }
    }
}
