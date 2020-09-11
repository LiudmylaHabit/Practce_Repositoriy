using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_Repositariy
{
    class ArrayListPr
    {
        public void ShowYourself()
        {
            int[] nums = new int[] { 1, 2, 3, 10, 1577, 27 };
            ArrayList ArrL = new ArrayList(nums);
            ArrL.Add("this is object");
            ArrL.AddRange(new double[] { 1.2, 3.5, 7.4440, 8.09 });

            ArrL.Add("Word");
            ArrL.Add("Another word");

            foreach (object o in ArrL)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("----------------------");           
        }

    }
}
