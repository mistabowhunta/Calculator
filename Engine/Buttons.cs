﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Buttons
    {
        //Get set stores properties
        public decimal Decimals {get;set;}
        public char Operators { get; set;}
        public string Strings { get; set;}
        //Setting properties with this class constructor. When creating this object in form class, 
        //it is also passing a parameter, then the parameter gets assigned to the property of Buttons object. 
        public Buttons (decimal decimals)
        {
            Decimals = decimals;
        }
        public Buttons (char operators)
        {
            Operators = operators;
        }
        public Buttons (string strings)
        {
            Strings = strings;
        }
    }
}
