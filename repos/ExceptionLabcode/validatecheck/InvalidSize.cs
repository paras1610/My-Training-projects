using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validatecheck
{
    public class InvalidSize:ApplicationException
    {
        public InvalidSize(string msg = null) : base(msg)
        {
           
        }
    }
}
