using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Applicant : People
    {
        public int PointsZNO { get; set; }
        public int PointsOfEducationDocument { get; set; }
        public string SchoolName { get; set; }
        public Applicant(string firstName, string lastName, DateTime dateOfBirth, int pointsZNO, int pointsOfEducationDocument, string schoolName) : base(firstName, lastName, dateOfBirth)
        {
            PointsZNO = pointsZNO;
            PointsOfEducationDocument = pointsOfEducationDocument;
            SchoolName = schoolName;
        }
        public override string ShowInfo()
        {
            return $"{LastName} {FirstName} {DateOfBirth} {PointsZNO} {PointsOfEducationDocument} {SchoolName}"; 
        }
    }
}
