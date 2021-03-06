﻿//Created on Dec 27, 2016
//@author: Isaac Nason
//The MIT License(MIT)
//Copyright(c) [2015]
//[Isaac Nason]
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Creating global lists to store all user's numbers and characters to perform calculations
        public List<decimal> decResList = new List<decimal>();
        public List<char> chList = new List<char>();
        public List<string> stList = new List<string>();
        public List<string> stMemList = new List<string>(); //stMemList stores everthing the user currently has on display
        public DateTime dateMouseDownTime;
        public Form1()
        {
            //Constructor for form
            InitializeComponent();
            KeyPreview = true; //Allows use of keyboard

            //Creating instance of using keyboard
            KeyDown += new KeyEventHandler(LinkingKeypad);

            //Creating/instantiating new Buttons object then passing default value to Buttons Class 
            Buttons button = new Buttons(0);

            //Telling ToolTips to popout a message when user hovers over memory button telling the user to double-click button to clear memory
            btnMemory.MouseHover += btnMemory_MouseHover;

            //Clears stMemList if the user double clicks btnMemory button
            btnMemory.MouseDown += new MouseEventHandler(btnMemory_MouseDown);
            btnMemory.MouseUp += new MouseEventHandler(btnMemory_MouseUp);

            //Setting text alignment for top display to right
            rtbTop.SelectionAlignment = HorizontalAlignment.Right;

            //Setting text alignment for left and right displays to center
            rtbLeft.SelectionAlignment = HorizontalAlignment.Center;
            rtbRight.SelectionAlignment = HorizontalAlignment.Center;
            rtbBottom.SelectionAlignment = HorizontalAlignment.Center;

        }
        private void LinkingKeypad(object sender, KeyEventArgs e)
        {
            //Numpad and keypad numbers activate corresponding method
            // Enter key is handled in the form level because key preview and key handlers cannot see all key - escape, enter, arrow keys. In form level they are excecuted first
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                e.SuppressKeyPress = true; //disables the beep sound when key pressed
                btnZero_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                e.SuppressKeyPress = true;
                btnOne_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                e.SuppressKeyPress = true;
                btnTwo_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                e.SuppressKeyPress = true;
                btnThree_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                e.SuppressKeyPress = true;
                btnFour_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                e.SuppressKeyPress = true;
                btnFive_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                e.SuppressKeyPress = true;
                btnSix_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                e.SuppressKeyPress = true;
                btnSeven_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                e.SuppressKeyPress = true;
                btnEight_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                e.SuppressKeyPress = true;
                btnNine_Click(sender, e);
            }
            //operators
            else if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
                btnBack_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                btnAdd_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                e.SuppressKeyPress = true;
                btnSubtract_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                e.SuppressKeyPress = true;
                btnMultiply_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
                btnDivide_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
                btnPeriod_Click(sender, e);
            }
        }
        //ALL BUTTON EVENTS BELOW
        //THESE ARE THE NUMBERS
        private void btnZero_Click(object sender, EventArgs e)
        {
            //Creating new object by passing 0 and adding that number to list in Buttons class
            Buttons button = new Buttons("0");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("0");
            rtbTop.Text += button.Strings;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("1");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("1");
            rtbTop.Text += button.Strings;
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("2");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("2");
            rtbTop.Text += button.Strings;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("3");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("3");
            rtbTop.Text += button.Strings;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("4");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("4");
            rtbTop.Text += button.Strings;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("5");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("5");
            rtbTop.Text += button.Strings;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("6");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("6");
            rtbTop.Text += button.Strings;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("7");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("7");
            rtbTop.Text += button.Strings;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("8");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("8");
            rtbTop.Text += button.Strings;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons("9");

            //In case user tried dividing by zero and the display shows zero, removing that zero
            if (stList.Count == 1)
            {
                if (stList[0] == "0")
                {
                    rtbTop.Text = "";
                    stList.RemoveAt(0);
                }
            }
            stList.Add("9");
            rtbTop.Text += button.Strings;
        }

        //THESE ARE THE OPERATORS/CHARACTERS
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(".");
            int intTemp = 0; //Temp integer for counting how many periods exist in stList, if greater than 1 then

            //In case user wants a decimal number < 1, adding a zero = 0.1 for easy readability
            if (stList.Count == 0)
            {
                rtbTop.Text += "0";
            }

            //If stList (users recently entered numbers) already contains a period then this if statement won't allow the user to enter another period
            foreach (string element in stList)
            {
                if (element == ".")
                {
                    intTemp++;
                }
            }
            if (intTemp >= 1) //intTemp >= 1 means there is already a period and don't want user entering more than one period
            {
                ; //Do nothing
            }
            else //if there are no periods in stList resume as normal
            {
                stList.Add(button.Strings);
                rtbTop.Text += button.Strings;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //When user clicks equal button, need to capture the last number/s entered. Those #'s are placed in the decResList for calculation. BUT if user clicks equals when there's a hanging
            //operator like +, -, *, or / the calculator will delete last character entered and perform normal calculation
            if ((stList.Count == 0) && (decResList.Count > 0) && (chList.Count > 1))
            {
                int intCount = (chList.Count) - 1; // minusing one to get correct index location
                chList.RemoveAt(intCount);

                //Converting the last decResList number into stList (user's temporary numbers). Need this in case user adds or deletes more numbers
                int j = (decResList.Count) - 1;//minusing 1 to get correct index

                //Converting last number in decResList to a string so can go through each character to add each individual to stList
                string strNewTempList = Convert.ToString(decResList[j]);
                foreach (char element in strNewTempList)
                {
                    string strNewVar = element.ToString();
                    //decimal intNewTempVar = Convert.ToDecimal(strNewVar);
                    stList.Add(strNewVar);
                }

                //Removing last number in decResList as just added it to stList
                decResList.RemoveAt(j);
            }
            else if ((stList.Count == 0) && (decResList.Count > 0) && (chList.Count == 1))
            {
                int intCount = (chList.Count) - 1; // minusing one to get correct index location
                chList.RemoveAt(intCount);
                foreach (int element in decResList)
                {
                    rtbTop.Text = element.ToString();
                    rtbBottom.Text = element.ToString();
                }

                //Converting the last decResList number into stList (user's temporary numbers). Need this in case user adds or deletes more numbers
                int j = (decResList.Count) - 1;//minusing 1 to get correct index

                //Converting last number in decResList to a string so can go through each character to add each individual to stList
                string strNewTempList = Convert.ToString(decResList[j]);
                foreach (char element in strNewTempList)
                {
                    string strNewVar = element.ToString();

                    //decimal intNewTempVar = Convert.ToDecimal(strNewVar);
                    stList.Add(strNewVar);
                }

                //Removing last number in decResList as just added it to stList
                decResList.RemoveAt(j);
            }

            //In case user clicks equals when there is only a negative sign on display OR user tries clicking equals when last button pressed was ???
            if ((stList.Count == 0) && (rtbTop.Text != " + + + + + + + + + +"))
            {
                ; // Do nothing proceed as normal
            }
            else if (((stList[0] == "-") && (decResList.Count == 0)) || (rtbTop.Text == " + + + + + + + + + +"))
            {
                ; //Do nothing because the user pushed the equals sign when only a negative character was entered or last button pressed was ???
            }
            else //resume as normal if there is not only a negative sign on display
            {
                //Checking if decimal dataype is overflowed
                try
                {
                    checked
                    {

                        string strNewList = string.Join("", stList);
                        decimal intNewVar = Convert.ToDecimal(strNewList);
                        decResList.Add(intNewVar);
                    }
                }
                catch (OverflowException oex)
                {
                    stList.Clear();
                    rtbTop.Text = "";
                    MessageBox.Show(oex.Message);
                }
                int intListTracker = 1;
                decimal decResult = 0;

                //If user tries pushing equal when there is only one number to calculate the display will only show that number (no calculation)
                if (decResList.Count == 0)
                {
                    ; // Do nothing. If code gets to this point, that means the user overflowed the decimal datatype and needs to re-enter number. Try Catch above cleared stList and display
                }
                else if (decResList.Count == 1)
                {
                    decResult = decResList[0];
                }
                else // decResList count is greater than one
                {
                    //Checking result does not overflow decimal variable. If overflow detected, messagebox will popup displaying oex message
                    try
                    {
                        checked
                        {
                            foreach (char element in chList)
                            {

                                if (element == '+')
                                {
                                    if (intListTracker == 1)
                                    {
                                        decResult = decResList[0] + decResList[intListTracker];
                                        intListTracker++;
                                    }
                                    else
                                    {
                                        decResult = decResult + decResList[intListTracker];
                                        intListTracker++;
                                    }
                                }
                                else if (element == '-')
                                {
                                    if (intListTracker == 1)
                                    {
                                        decResult = decResList[0] - decResList[intListTracker];
                                        intListTracker++;
                                    }
                                    else
                                    {
                                        decResult = decResult - decResList[intListTracker];
                                        intListTracker++;
                                    }
                                }
                                else if (element == '*')
                                {
                                    if (intListTracker == 1)
                                    {
                                        decResult = decResList[0] * decResList[intListTracker];
                                        intListTracker++;
                                    }
                                    else
                                    {
                                        decResult = decResult * decResList[intListTracker];
                                        intListTracker++;
                                    }
                                }
                                else if (element == '/')
                                {
                                    // Cannot divide by zero so if user tries, the result will just show 0
                                    if (intListTracker == 1)
                                    {
                                        //Checking if index 0 in decResList is zero or if the next number being divided by is a zero
                                        if ((decResList[0] == 0) || (decResList[intListTracker] == 0))
                                        {
                                            decResult = 0;
                                            intListTracker++;
                                        }
                                        else //Neither number is being divided by zero so proceed as normal
                                        {
                                            decResult = decResList[0] / decResList[intListTracker];
                                            intListTracker++;
                                        }

                                    }
                                    else
                                    {
                                        //Checking if the next number in decResList is a zero, if so decResult = 0
                                        if (decResList[intListTracker] == 0)
                                        {
                                            decResult = 0;
                                            intListTracker++;
                                        }
                                        else //Neither number is being divided by zero so proceed as normal
                                        {
                                            decResult = decResult / decResList[intListTracker];
                                            intListTracker++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (OverflowException oex)
                    {
                        stList.Clear();
                        rtbTop.Text = "";
                        MessageBox.Show(oex.Message);
                    }
                }
                stList.Clear();
                chList.Clear();
                decResList.Clear();
                rtbTop.Text = decResult.ToString();
                rtbBottom.Text = decResult.ToString();

                //Adding decResult to stList so user can manipulate numbers if needed after press equals sign (if it's only 1 integer variable like "101" user can't change any single integer)
                //Converting decResult to a string so can go through each character to add each individual to stList
                string strTempList = Convert.ToString(decResult);
                foreach (char element in strTempList)
                {
                    string strNewVar = element.ToString();

                    //decimal intTempInt = Convert.ToDecimal(strNewVar);
                    stList.Add(strNewVar);
                }
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('+');

            //Catching if decimal dataype is overflowed
            try
            {
                checked
                {
                    //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
                    if ((stList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
                    {
                        //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";
                    }
                    else if ((stList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
                    {
                        //Clearing screens and re-displaying all users previously entered information as the user cannot enter double operators in middle of calculations.
                        //Double operators includes +,*,/. Subtract will turn integer negative
                        rtbTop.Text = "";
                        int intCounter = 0;
                        foreach (char element in chList)
                        {
                            rtbTop.Text += decResList[intCounter].ToString();
                            rtbTop.Text += " " + element + " ".ToString();
                            intCounter++;
                        }
                    }
                    else if ((stList.Count == 1) && (stList[0] == "-"))
                    {
                        ; //Do nothing because cannot only have a negative sign. Need a number to calculate otherwise an error will be thrown
                    }
                    else // All 3 lists count do not equal 0, resume as normal
                    {

                        //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                        rtbTop.Text += " " + button.Operators + " ";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";

                        //Joining all indexes in stList into one then converting that into a decimal for later calculation
                        string strNewList = string.Join("", stList);
                        decimal intNewVar = Convert.ToDecimal(strNewList);
                        decResList.Add(intNewVar);

                        //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                        chList.Add(button.Operators);

                        //Clearing stList so user can enter the second, third, fourth numbers
                        stList.Clear();

                        //Loop that displays operator user clicked on side displays
                        for (int i = 1; i <= 10; i++)
                        {
                            rtbLeft.Text += button.Operators + "\n";
                            rtbRight.Text += button.Operators + "\n";
                            await Task.Delay(60); //Cool trick here
                        }
                    }
                }
            }
            catch (OverflowException oex)
            {
                stList.Clear();
                rtbTop.Text = "";
                MessageBox.Show(oex.Message);
            }
        }
        private async void btnSubtract_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('-');

            //Catching if decimal dataype is overflowed
            try
            {
                checked
                {
                    //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
                    if ((stList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
                    {
                        //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";
                    }
                    else if ((stList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
                    {
                        //Clearing screens and re-displaying all users previously entered information as the user cannot enter double operators in middle of calculations.
                        //Double operators includes +,*,/. Subtract will turn integer negative
                        rtbTop.Text = "";
                        int intCounter = 0;
                        foreach (char element in chList)
                        {
                            rtbTop.Text += decResList[intCounter].ToString();
                            rtbTop.Text += " " + element + " ".ToString();
                            intCounter++;
                        }
                    }
                    else if ((stList.Count == 1) && (stList[0] == "-"))
                    {
                        ; //Do nothing because cannot only have a negative sign. Need a number to calculate otherwise an error will be thrown
                    }
                    else // All 3 lists count do not equal 0, resume as normal
                    {

                        //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                        rtbTop.Text += " " + button.Operators + " ";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";

                        //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                        string strNewList = string.Join("", stList);
                        decimal intNewVar = Convert.ToDecimal(strNewList);
                        decResList.Add(intNewVar);

                        //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                        chList.Add(button.Operators);

                        //Clearing stList so user can enter the second, third, fourth numbers
                        stList.Clear();

                        //Loop that displays operator user clicked on side displays
                        for (int i = 1; i <= 10; i++)
                        {
                            rtbLeft.Text += button.Operators + "\n";
                            rtbRight.Text += button.Operators + "\n";
                            await Task.Delay(60); //Cool trick here
                        }
                    }
                }
            }
            catch (OverflowException oex)
            {
                stList.Clear();
                rtbTop.Text = "";
                MessageBox.Show(oex.Message);
            }
        }
        private async void btnMultiply_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('*');

            //Catching if decimal dataype is overflowed
            try
            {
                checked
                {
                    //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
                    if ((stList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
                    {
                        //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";
                    }
                    else if ((stList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
                    {
                        //Clearing screens and re-displaying all users previously entered information as the user cannot enter double operators in middle of calculations.
                        //Double operators includes +,*,/. Subtract will turn integer negative
                        rtbTop.Text = "";
                        int intCounter = 0;
                        foreach (char element in chList)
                        {
                            rtbTop.Text += decResList[intCounter].ToString();
                            rtbTop.Text += " " + element + " ".ToString();
                            intCounter++;
                        }
                    }
                    else if ((stList.Count == 1) && (stList[0] == "-"))
                    {
                        ; //Do nothing because cannot only have a negative sign. Need a number to calculate otherwise an error will be thrown
                    }
                    else // All 3 lists count do not equal 0, resume as normal
                    {

                        //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                        rtbTop.Text += " " + button.Operators + " ";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";

                        //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                        string strNewList = string.Join("", stList);
                        decimal intNewVar = Convert.ToDecimal(strNewList);
                        decResList.Add(intNewVar);

                        //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                        chList.Add(button.Operators);

                        //Clearing stList so user can enter the second, third, fourth numbers
                        stList.Clear();

                        //Loop that displays operator user clicked on side displays
                        for (int i = 1; i <= 10; i++)
                        {
                            rtbLeft.Text += button.Operators + "\n";
                            rtbRight.Text += button.Operators + "\n";
                            await Task.Delay(60); //Cool trick here
                        }
                    }
                }
            }
            catch (OverflowException oex)
            {
                stList.Clear();
                rtbTop.Text = "";
                MessageBox.Show(oex.Message);
            }
        }
        private async void btnDivide_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('/');

            //Catching if decimal dataype is overflowed
            try
            {
                checked
                {
                    //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
                    if ((stList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
                    {
                        //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";
                    }
                    else if ((stList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
                    {
                        //Clearing screens and re-displaying all users previously entered information as the user cannot enter double operators in middle of calculations.
                        //Double operators includes +,*,/
                        rtbTop.Text = "";
                        int intCounter = 0;
                        foreach (char element in chList)
                        {
                            rtbTop.Text += decResList[intCounter].ToString();
                            rtbTop.Text += " " + element + " ".ToString();
                            intCounter++;
                        }
                    }
                    else if ((stList.Count == 1) && (stList[0] == "-"))
                    {
                        ; //Do nothing because cannot only have a negative sign. Need a number to calculate otherwise an error will be thrown
                    }
                    else // All 3 lists count do not equal 0, resume as normal
                    {

                        //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                        rtbTop.Text += " " + button.Operators + " ";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";

                        //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                        string strNewList = string.Join("", stList);
                        decimal intNewVar = Convert.ToDecimal(strNewList);
                        decResList.Add(intNewVar);

                        //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                        chList.Add(button.Operators);

                        //Clearing stList so user can enter the second, third, fourth numbers
                        stList.Clear();

                        //Loop that displays operator user clicked on side displays
                        for (int i = 1; i <= 10; i++)
                        {
                            rtbLeft.Text += button.Operators + "\n";
                            rtbRight.Text += button.Operators + "\n";
                            await Task.Delay(60); //Cool trick here
                        }
                    }
                }
            }
            catch (OverflowException oex)
            {
                stList.Clear();
                rtbTop.Text = "";
                MessageBox.Show(oex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            if (chList.Count > 0)
            {
                if (stList.Count > 0)
                {
                    //Finding how many indexes are in numbers list, then deleting the last index
                    int i = (stList.Count) - 1;//minusing 1 to get correct index
                    stList.RemoveAt(i);

                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";

                    // Looping through decResList and chList to enter all numbers and characters (operations) user previously entered
                    int intAddCh = 0, intStop = (decResList.Count), intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                    foreach (decimal element in decResList)
                    {
                        rtbTop.Text += element.ToString();
                        if (intCurrentIndex == intStop)
                        {
                            ; //do nothing here as there are no more characters to add becuase the last number was added to display and chList is empty
                        }
                        else //(intCurrentIndex != intStop)
                        {
                            rtbTop.Text += " " + chList[intAddCh] + " ";
                            intAddCh++;
                            intCurrentIndex++;
                        }  
                    }

                    //Looping through stList to display all integers back on display less the integer user wanted removed
                    foreach (string element in stList)
                    {
                        rtbTop.Text += element.ToString();
                    }

                }
                else // (stList.Count <= 0)
                {
                    //Finding how many indexes are in character list, then deleting the last index
                    int i = (chList.Count) - 1;
                    chList.RemoveAt(i);
                    if (chList.Count == 0)
                    {
                        //Clearing screen
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";

                        //Redisplaying all numbers user entered 
                        foreach(decimal element in decResList)
                        {
                            rtbTop.Text += element.ToString();
                        }

                        //Converting the last decResList number into stList (user's temporary numbers). Need this in case user adds or deletes more numbers
                        int j = (decResList.Count) - 1;//minusing 1 to get correct index

                        //Converting last number in decResList to a string so can go through each character to add each individual to stList
                        string strNewList = Convert.ToString(decResList[j]);
                        foreach (char element in strNewList)
                        {
                            string strNewVar = element.ToString();
                            stList.Add(strNewVar);
                        }

                        //Removing last number in decResList as just added it to stList
                        decResList.RemoveAt(j);
                    }
                    else //(chList.Count > 0)
                    {
                        //Clearing screen
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";

                        //Redisplaying all numbers in decResList and all characters user previously entered less the last character (operator)
                        int intAddCh = 0, intStop = (decResList.Count) - 1, intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                        foreach (decimal element in decResList)
                        {
                            rtbTop.Text += element.ToString();
                            if (intCurrentIndex == intStop)
                            {
                                ; //do nothing here as there are no more characters to add becuase the last number was added to display and chList is empty
                            }
                            else //(intCurrentIndex != intStop)
                            {
                                rtbTop.Text += " " + chList[intAddCh] + " ";
                                intAddCh++;
                                intCurrentIndex++;
                            }
                        }

                        //Converting the last decResList number into stList (user's temporary numbers). Need this in case user adds or deletes more numbers
                        int j = (decResList.Count) - 1;//minusing 1 to get correct index

                        //Converting last number in decResList to a string so can go through each character to add each individual to stList
                        string strNewList = Convert.ToString(decResList[j]);
                        foreach(char element in strNewList)
                        {
                            string strNewVar = element.ToString();

                            //decimal intNewVar = Convert.ToDecimal(strNewVar);
                            stList.Add(strNewVar);
                        }

                        //Removing last number in decResList as just added it to stList
                        decResList.RemoveAt(j);
                    }
                }
            } 
            else // if (chList.Count <= 0)
            {
                if (stList.Count > 0)
                {
                    //Finding how many indexes are in numbers list, then deleting the last index
                    int i = (stList.Count) - 1;//minusing 1 to get correct index
                    stList.RemoveAt(i);

                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";

                    //Looping through stList to display all integers back on display less the integer user wanted removed
                    foreach (string element in stList)
                    {
                        rtbTop.Text += element.ToString();
                    }
                }
                else // if (stList.Count < = 0)
                {
                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";
                }
            }
        } // backspace end
         
        private void btnNegative_Click(object sender, EventArgs e)
        {
            //In case user tries pushing negative button more than once
            if ((stList.Count > 0) && (stList[0].Contains("-")))
            {
                ; //Do nothing as a negative sign already exists. Can't have more than one negative sign
            }
            else if (decResList.Count == 0)
            {
                //Clearing the screen to insert negative sign
                rtbTop.Text = "";

                //Inserting negative sign in index 0 meaning at the beginning of the number. Also re-displaying all numbers
                stList.Insert(0, "-");
                foreach (string element in stList)
                {
                    rtbTop.Text += element;
                }
            }
            else //decResList > 0
            {
                //Clearing the screen to insert negative sign
                rtbTop.Text = "";

                //Inserting negative sign in index 0 meaning at the beginning of the number. Also re-displaying all numbers
                stList.Insert(0, "-");

                // Looping through decResList and chList to enter all numbers and characters (operations) user previously entered
                int intAddCh = 0, intStop = (decResList.Count), intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                foreach (decimal element in decResList)
                {
                    rtbTop.Text += element.ToString();
                    if (intCurrentIndex == intStop)
                    {
                        ; //do nothing here as there are no more characters to add becuase the last number was added to display and chList is empty
                    }
                    else //(intCurrentIndex != intStop)
                    {
                        rtbTop.Text += " " + chList[intAddCh] + " ";
                        intAddCh++;
                        intCurrentIndex++;
                    }
                }
                //Looping through stList to display all integers back on display less the integer user wanted removed
                foreach (string element in stList)
                {
                    rtbTop.Text += element.ToString();
                }
            }
        }
        private void btnMemory_MouseHover(object sender, EventArgs e)
        {
            //Tells user to hold the memory button to clear memory
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(btnMemory, "Hold for 2 seconds and release to clear memory");
        }
        private void btnMemory_MouseDown(object sender, MouseEventArgs e)
        {
            //Capturing the current time when the user presses the mem button down and if the button is held down for longer than 1.5 seconds, the memory list is cleared
            dateMouseDownTime = DateTime.Now;
        }
        private async void btnMemory_MouseUp(object sender, MouseEventArgs e)
        {
            //Capturing the current time when the user presses the mem button down and if the button is held down for longer than 1.5 seconds, the memory list is cleared
            var clickDuration = DateTime.Now - dateMouseDownTime;
            if(clickDuration > TimeSpan.FromSeconds(1.5))
            {
                stMemList.Clear();
                rtbTop.Text = "***Memory Cleared***";
                await Task.Delay(800);
                rtbTop.Text = "";
            }
            else //Normal button click so do nothing and resume as normal
            {
                ; //Do nothing, resume as normal
            }
        }
        private void btnMemory_Click(object sender, EventArgs e)
        {
            //If there is nothing in memory put everything on display in this string list
            if (stMemList.Count == 0)
            {
                //Putting user's temporary string list into decResList so only have to work with one list (decResList). I'll need to convert the entire decimal list (decResList) into string
                if (stList.Count > 0)
                {
                    if ((stList.Count == 1) && (stList[0] == "-"))
                    {
                        ; //Do nothing becuase if there is only a negative sign do not need to put that into memory
                    }
                    else // There is not only a negative sign so resume as normal
                    {
                    string strNewList = string.Join("", stList);
                    decimal intNewVar = Convert.ToDecimal(strNewList);
                    decResList.Add(intNewVar);

                    //Adding all numbers in decResList and all characters user previously entered into stMemList
                    int intAddCh = 0, intStop = (decResList.Count) - 1, intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                    foreach (decimal element in decResList)
                    {
                        stMemList.Add(element.ToString());
                        if (intCurrentIndex == intStop)
                        {
                            ; //do nothing here as there are no more characters to add becuase the last number was added to display and chList is empty
                        }
                        else //(intCurrentIndex != intStop)
                        {
                            stMemList.Add(chList[intAddCh].ToString());
                            intAddCh++;
                            intCurrentIndex++;
                        }
                    }

                    //No longer need the last number in decResList, only needed that so I could work with one list. User's stList still has the numbers there
                    int intTempRemove = decResList.Count - 1;
                    decResList.RemoveAt(intTempRemove);
                    }
                }
                else //stList.Count == 0 / User did not enter anything into stList (temporary list). Only need to add decResList and any characters
                {
                    //Adding all numbers in decResList and all characters user previously entered into stMemList
                    int intAddCh = 0, intStop = (decResList.Count) - 1, intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                    foreach (decimal element in decResList)
                    {
                        stMemList.Add(element.ToString());
                        if (intCurrentIndex == intStop)
                        {
                            ; //do nothing here as there are no more characters to add because the last number was added to display
                        }
                        else //(intCurrentIndex != intStop)
                        {
                            stMemList.Add(chList[intAddCh].ToString());
                            intAddCh++;
                            intCurrentIndex++;
                        }
                    }
                    //In case user entered a character (operator) as the last input need to put that into stMemList 
                    if (decResList.Count == chList.Count) // If the count of characters equals count of decResList that means there is a character at the end that needs to be put into stMemList
                    {
                        intAddCh = chList.Count - 1;
                        if (chList.Count == 0)
                        {
                            ; // Do nothing as user clicked ??? button, not capturing that into memory
                        }
                        else
                        {
                            stMemList.Add(chList[intAddCh].ToString());
                        }
                    }
                }
            }
            else // stMemList has something stored in it so re-display on top screen and clear side screens
            {
                //Need to clear all lists and add what user stored in stMemList to those lists
                stList.Clear();
                decResList.Clear();
                chList.Clear();

                //Clearing text from all screens
                rtbBottom.Text = "";
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";

                //Adding stMemList to other lists. If foreach loop comes across a character (operator) converting that into a character before adding into chList
                foreach(string element in stMemList)
                {
                    if (element == "+")
                    {
                        chList.Add(Convert.ToChar(element));
                    }
                    else if (element == "-")
                    {
                        chList.Add(Convert.ToChar(element));
                    }
                    else if (element == "*")
                    {
                        chList.Add(Convert.ToChar(element));
                    }
                    else if (element == "/")
                    {
                        chList.Add(Convert.ToChar(element));
                    }
                    else //Current string element is not a character so it is a decimal that needs to be added to decResList
                    {
                        decResList.Add(Convert.ToDecimal(element));
                    }
                }
                if (chList.Count == 0)
                {
                    //Putting last number in decResList to stList so user can manipulate it. There is only one number becuase there is not any characters (operators)
                    int intTempIndex = decResList.Count - 1; //Subtracting one from count to get correct index of last decimal number
                    stList.Add(decResList[intTempIndex].ToString()); //Converting to string
                    decResList.RemoveAt(intTempIndex); //Removing last decimal number because it is now in stList
                    foreach(string element in stList)
                    {
                        rtbTop.Text += element;
                    }
                }
                else //there is atleast one character (operator) in chList 
                {
                    //Adding all numbers in decResList and all characters that is in memory to top display
                    int intAddCh = 0, intStop = (decResList.Count) - 1, intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                    foreach (decimal element in decResList)
                    {
                        rtbTop.Text += element.ToString();
                        if (intCurrentIndex == intStop)
                        {
                            ; //do nothing here as there are no more characters to add because the last number was added to display
                        }
                        else //(intCurrentIndex != intStop)
                        {
                            rtbTop.Text += " " + chList[intAddCh] + " ".ToString();
                            intAddCh++;
                            intCurrentIndex++;
                        }
                    }
                    //In case user entered a character (operator) as the last input need to display that too
                    if (decResList.Count == chList.Count) // If the count of characters equals count of decResList that means there is a character at the end that needs to be put into stMemList
                    {
                        intAddCh = chList.Count - 1;
                        rtbTop.Text += " " + chList[intAddCh] + " ".ToString();
                    }
                    else //There is not a character as last input so need to convert last number in decResList to string so user can manipulate that number
                    {
                        int intTempIndex = decResList.Count - 1; //Subtracting one from count to get correct index of last decimal number
                        stList.Add(decResList[intTempIndex].ToString()); //Converting to string
                        decResList.RemoveAt(intTempIndex); //Removing last decimal number because it is now in stList
                    }               
                }
            }
        }

        private async void btnQuestion_Click(object sender, EventArgs e)
        {
            //Changed this button to a ???. A surprise that shows operators on sides, top, and bottom of displays
            //Clearing all displays first
            rtbTop.Text = "";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            rtbBottom.Text = "";

            //Loop that displays operator user clicked on side displays
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += "/\n";
                rtbRight.Text += "*\n";
                rtbTop.Text += "   +";
                rtbBottom.Text += "  -";
                await Task.Delay(60); //Cool trick here
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            //Clearing text from all screens and removing all elements in all lists
            rtbBottom.Text = "";
            rtbTop.Text = "";
            rtbLeft.Text = "";
            rtbRight.Text = "";

            //Clearing all lists so user can start fresh
            stList.Clear();
            decResList.Clear();
            chList.Clear();
           
        }
    } //Form1 end bracket
} //namespace end bracket

///NOTES
/////Converting entire list into a string then displaying in rich text box
//      string newList = string.Join("", stList);
//In order to keep adding integers to displays, need to use += NOT just =
//EXAMPLE of converting a int in list to string, then subtracting one letter in that string, afterwards converting back to int
//      int i = (decResList.Count) - 1; //minusing 1 to get correct index
//      string strConvert = decResList[i].ToString();
//      int j = (strConvert.Length);
//      strConvert = strConvert.Remove(j);
//      decResList[i] = Convert.ToInt32(strConvert);

//strFormatChange = String.Format("{0:#,###0.#####}", decResult); //String formatting: 0's are a placeholder if nothing is there a zero will be entered. # is a placeholder, if nothing
// is there nothing will be entered.

// // Enter key is handled in the form level because key preview and key handlers cannot see all keys - escape, enter, arrow keys. In form level they are excecuted first
//KeyDown handlers do not see all keys.Specifically, "you can't see the kind of keystrokes that are used for navigation. Like 
//the cursor keys and Tab, Escape and Enter for a dialog."
//There are a few different ways to intercept key events, and they all happen in sequence.KeyDown is handled last. Hence, KeyPreview isn't
//much of a preview, and the event could be silenced at a few stops on the way.
//Need to override ProcessCmdKey at the Form level. That way, all keys are visible to the method, and the method is first in line to see the event.


//BUGS
//     Can't remove negative sign once clicked.

