using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validatecheck
{
  public class InvalidType:ApplicationException
    {
        public InvalidType(string msg = null) : base(msg)
        {
  
        }
    }
}
