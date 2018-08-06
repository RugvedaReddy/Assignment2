using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace question1
{
    class UserTrail
    {
        int val1, val2;

        public void Show()
        {
            try
            {
                Console.WriteLine("enter val1 and val2");
                val1 = int.Parse(Console.ReadLine());
                val2 = int.Parse(Console.ReadLine());
                if (val1 < 0)

                    throw new Exception();

                if (val2 < 0)

                    throw new Exception();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        public void Calculate()
        {
            try
            {

                if (val1 - val2 < 0)
                {
                    throw new Exception();
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
