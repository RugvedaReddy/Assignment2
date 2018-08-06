using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QUESTION2
{
    class NoMatchException:Exception
    {
        string msg;
        public NoMatchException()
        {
            msg = "THE TWO STRINGS ARE DIFFERENT";
        }
        public NoMatchException(string message)
        {
            msg = message;
        }
        public override string Message
        {
            get
            { return msg; }
        }

        
    }
}
