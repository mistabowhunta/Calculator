using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Buttons
    {
        //Get set stores properties
        public int Numbers {get;set;}
        public char Operators { get; set; }
        public string Strings { get; set; }
        //Setting properties with this class constructor. When creating this object in form class, 
        //it is also passing a parameter, then the parameter gets assigned to the property of Buttons object. 
        public Buttons (int numbers)
        {
            Numbers = numbers;
        }
        public Buttons (char operators)
        {
            Operators = operators;
        }
        public Buttons (string strings)
        {
            Strings = strings;
        }
   
        //public char Period { get; set; }
        //public char Equal { get; set; }
        //public char Add { get; set; }
        //public char Subtract { get; set; }
    }
}
