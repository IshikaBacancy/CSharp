using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{


    public abstract class RentalService
    {


        public abstract void GetRentalType();
        
        public void PrintRentalPolicy()
        {
            Console.WriteLine("The Rental Policy here is");
        }

    }
}
