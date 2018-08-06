using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTION2
{
    class InputMessage
    {
        string input;
        public void Check()
        {
            try
            {


                Console.WriteLine("enter the input message");
                input = Console.ReadLine();
                if (input != "Deloitte Training")
                {
                    throw new NoMatchException();
                }
                else
                    Console.WriteLine("IT IS MATCHING");
            }
            catch (NoMatchException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
