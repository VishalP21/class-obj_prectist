using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_obj_prectist
{
    public class Cars
    {
        public string brand ="";
        public int mfgyear=0;
        public string model="";
        public string city="";
        public void input()
        {
            Console.WriteLine("enter car brand name");
             brand = Console.ReadLine();
            Console.WriteLine("enter car mfg year");
             mfgyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter car model");
             model = Console.ReadLine();
            Console.WriteLine("enter car city");
             city = Console.ReadLine();
        }

        public void output()
        {
            Console.WriteLine($"your car brand is {brand} and model is {model}. asembal year {mfgyear} & city is {city}.");
        }
    }
}
