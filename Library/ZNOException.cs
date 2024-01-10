using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ZNOException : Exception
    {
        public int ZNO { get; set; }
        public ZNOException(int zno, string message) : base(message)
        { 
            ZNO = zno;
        }
    }
}
