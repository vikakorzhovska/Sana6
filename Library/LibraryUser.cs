using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryUser : People
    {
        public int NumberTicket { get; set; }
        public DateTime DateOfIssue { get; set; }
        public decimal ReaderContribution { get; set; }
        public LibraryUser(string firstName, string lastName, DateTime dateOfBirth, int numberTicket, DateTime dateOfIssue, decimal readerContribution) : base(firstName, lastName, dateOfBirth)
        {
            NumberTicket = numberTicket;
            DateOfIssue = dateOfIssue;
            ReaderContribution = readerContribution;
        }
        public override string ShowInfo()
        {
            return $"{LastName} {FirstName} {DateOfBirth} {NumberTicket} {DateOfIssue} {ReaderContribution}";
        }
    } 
}
