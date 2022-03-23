using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace Classes
{
    public class Class_1Dog
    {
        //Below are properties 
        public string Name { get; set; }

        public double Weight { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string Size { get; set; }


        //below is a method
        //Dogs can bark 
        public string Bark()
        {
            return "Woof";
        }
    }
}

