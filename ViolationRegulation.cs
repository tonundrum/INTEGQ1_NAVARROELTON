using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRMSBusinessLayer
{
    class ViolationRegulation
    {
       static public void CheckOffenses(int category)
        {
            if (category.Equals(1))
            {
                Console.WriteLine("1st offense - Expulsion");
                Console.WriteLine("What is the offense? (1st) ");
                string offense = Console.ReadLine();
                offense.Equals("Expulsion");
                
            }
            
        }

    }

}
