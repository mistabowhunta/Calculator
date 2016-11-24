using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Buttons
    {
        //Creating list to store the numbers user enters
        //public List<int> iList = new List<int>();

        public int Numbers {get;set;}
        //Setting properties with this class constructor. When creating this object in form class, 
        //it is also passing a parameter, then the parameter gets assigned to the property of Buttons object. 
        public Buttons (int numbers)
        {
            Numbers = numbers;
           
        }
   
        //public char Period { get; set; }
        //public char Equal { get; set; }
        //public char Add { get; set; }
        //public char Subtract { get; set; }
    }
}
