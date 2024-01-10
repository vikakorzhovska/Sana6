using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Applicant : People
    {
        protected int _zno;
        protected int _points;
        public int PointsZNO
        {
            get
            {
                return _zno;
            }
            set
            {
                if (value >= 100 && value <= 200)
                _zno = value;
                else 
                    throw new ZNOException(value, "Бал ЗНО має бути в діапазоні від 100 до 200");
            }
        }
        public int PointsOfEducationDocument {
            get
            {
                return _points;
            }
            set
            {
                if (value >= 1 && value <= 12)
                    _points = value;
                else
                    throw new PointsException(value, "Бал документу має бути в діапазоні від 1 до 12");
            }
        }
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
