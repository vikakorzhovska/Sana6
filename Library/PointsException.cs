using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PointsException : Exception
    {
        public int Points {  get; set; }
        public PointsException(int points, string message) : base(message)
        {
            Points = points;
        }
    }
}
