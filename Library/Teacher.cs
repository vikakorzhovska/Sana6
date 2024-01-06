using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Teacher : People
    {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string University { get; set; }
        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position, string chair, string university) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Chair = chair;
            University = university;
        }
        public override string ShowInfo()
        {
            return $"{LastName} {FirstName} {DateOfBirth} {Position} {Chair} {University}";
        }
    } 
}
