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
        //public List<int> decList = new List<int>();
        public List<decimal> decList = new List<decimal>();
        //public List<int> decResList = new List<int>();
        public List<decimal> decResList = new List<decimal>();
        public List<char> chList = new List<char>();
        public List<string> stList = new List<string>();
        public Form1()
        {
            //Constructor for form
            InitializeComponent();
            
            //Creating/instantiating new Buttons object then passing default value to Buttons Class 
            Buttons button = new Buttons(0);
            
            //Setting text alignment for top display to right
            rtbTop.SelectionAlignment = HorizontalAlignment.Right;
            //Setting text alignment for left and right displays to center
            rtbLeft.SelectionAlignment = HorizontalAlignment.Center;
            rtbRight.SelectionAlignment = HorizontalAlignment.Center;
            rtbBottom.SelectionAlignment = HorizontalAlignment.Center;
          
        }
       
        //ALL BUTTON EVENTS BELOW
            //THESE ARE THE NUMBERS
        private void btnZero_Click(object sender, EventArgs e)
        {
            //Creating new object by passing 0 and adding that number to list in Buttons class
            Buttons button = new Buttons(0);
            decList.Add(0);
            rtbTop.Text += button.Decimals;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(1);
            decList.Add(1);
            rtbTop.Text += button.Decimals;
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(2);
            decList.Add(2);
            rtbTop.Text += button.Decimals;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(3);
            decList.Add(3);
            rtbTop.Text += button.Decimals;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(4);
            decList.Add(4);
            rtbTop.Text += button.Decimals;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(5);
            decList.Add(5);
            stList.Add("5");
            rtbTop.Text += button.Decimals;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(6);
            decList.Add(6);
            rtbTop.Text += button.Decimals;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(7);
            decList.Add(7);
            rtbTop.Text += button.Decimals;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(8);
            decList.Add(8);
            rtbTop.Text += button.Decimals;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(9);
            decList.Add(9);
            rtbTop.Text += button.Decimals;
        }

        //THESE ARE THE OPERATORS/CHARACTERS
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            //In case user wants a decimal number < 1, adding a zero = 0.1 for easy readability
            if (decList.Count == 0)
            {
                //Clearing top screen and putting "0."
                rtbTop.Text = "";
                rtbTop.Text += "0";
            }
            Buttons button = new Buttons('.');
            // chList.Add(button.Operators);
            stList.Add(button.Operators.ToString());
            rtbTop.Text += button.Operators;
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //When user clicks equal button, need to capture the last number/s entered. Those #'s are placed in the decResList for calculation. BUT if user clicks equals when there's a hanging
            //operator like +, -, *, or / the calculator will delete last character entered and perform normal calculation
            if ((decList.Count == 0) && (decResList.Count > 0) && (chList.Count > 1))
            {
                int intCount = (chList.Count) - 1; // minusing one to get correct index location
                chList.RemoveAt(intCount);

                //Converting the last decResList number into decList (user's temporary numbers). Need this in case user adds or deletes more numbers
                int j = (decResList.Count) - 1;//minusing 1 to get correct index
                //Converting last number in decResList to a string so can go through each character to add each individual to decList
                string strNewTempList = Convert.ToString(decResList[j]);
                foreach (char element in strNewTempList)
                {
                    string strNewVar = element.ToString();
                    decimal intNewTempVar = Convert.ToDecimal(strNewVar);
                    decList.Add(intNewTempVar);
                }
                //Removing last number in decResList as just added it to decList
                decResList.RemoveAt(j);
            }
            else if ((decList.Count == 0) && (decResList.Count > 0) && (chList.Count == 1))
            {
                int intCount = (chList.Count) - 1; // minusing one to get correct index location
                chList.RemoveAt(intCount);
                foreach (int element in decResList)
                {
                    rtbTop.Text = element.ToString();
                    rtbBottom.Text = element.ToString();
                }
                //Converting the last decResList number into decList (user's temporary numbers). Need this in case user adds or deletes more numbers
                int j = (decResList.Count) - 1;//minusing 1 to get correct index
                //Converting last number in decResList to a string so can go through each character to add each individual to decList
                string strNewTempList = Convert.ToString(decResList[j]);
                foreach (char element in strNewTempList)
                {
                    string strNewVar = element.ToString();
                    decimal intNewTempVar = Convert.ToDecimal(strNewVar);
                    decList.Add(intNewTempVar);
                }
                //Removing last number in decResList as just added it to decList
                decResList.RemoveAt(j);
            }
            string strNewList = string.Join("", stList); // <<<< ISAAC I changed this to stList from decList to try out string calculating
            decimal intNewVar = Convert.ToDecimal(strNewList);
            decResList.Add(intNewVar);
            int intListTracker = 1;
            decimal decResult = 0;

            if (decResList.Count <= 1) 
            {
                decResult = decResList[0];
            }
            else // decResList count is greater than one
                
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
                    if (intListTracker == 1)
                    {
                        decResult = decResList[0] / decResList[intListTracker];
                        intListTracker++;
                    }
                    else
                    {
                        decResult = decResult / decResList[intListTracker];
                        intListTracker++;
                    }
                }

            }


            //decList.Clear();
            stList.Clear(); // <<<<<ISAAC delete this if not going stList route
            chList.Clear();
            decResList.Clear();
            rtbTop.Text = decResult.ToString();
            rtbBottom.Text = decResult.ToString();
            //Adding decResult to decList so user can manipulate numbers if needed after press equals sign (if it's only 1 integer variable like "101" user can't change any single integer)
            //Converting decResult to a string so can go through each character to add each individual to decList
            string strTempList = Convert.ToString(decResult);
            foreach (char element in strTempList)
            {
                string strNewVar = element.ToString();
                decimal intTempInt = Convert.ToDecimal(strNewVar);
                decList.Add(intTempInt);
            }
            
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('+');
            //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
            if ((decList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
            {
                //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";
            }
            else if ((decList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
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
            else // All 3 lists count do not equal 0, resume as normal
            {
         
                //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                rtbTop.Text += " " + button.Operators + " ";
                rtbLeft.Text = "";
                rtbRight.Text = "";
                //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                //if (stList.Contains("."))
                //{
                //    //foreach (string element in stList)
                //    //{
                //        decResList.Add(Convert.ToDecimal(element));
                //    //}
                    
                //}
                string strNewList = string.Join("", stList); // ISAAC I changed this to stList from decList <<<<<
                decimal intNewVar = Convert.ToDecimal(strNewList);
                decResList.Add(intNewVar);
                //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                chList.Add(button.Operators);
                //Clearing decList so user can enter the second, third, fourth numbers

                //decList.Clear();
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

        private async void btnSubtract_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('-');
            //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
            if ((decList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
            {
                //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";
            }
            else if ((decList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
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
            else // All 3 lists count do not equal 0, resume as normal
            {

                //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                rtbTop.Text += " " + button.Operators + " ";
                rtbLeft.Text = "";
                rtbRight.Text = "";
                //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                string strNewList = string.Join("", decList);
                decimal intNewVar = Convert.ToDecimal(strNewList);
                decResList.Add(intNewVar);
                //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                chList.Add(button.Operators);
                //Clearing decList so user can enter the second, third, fourth numbers
                decList.Clear();

                //Loop that displays operator user clicked on side displays
                for (int i = 1; i <= 10; i++)
                {
                    rtbLeft.Text += button.Operators + "\n";
                    rtbRight.Text += button.Operators + "\n";
                    await Task.Delay(60); //Cool trick here
                }
            }

        }

        private async void btnMultiply_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('*');
            //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
            if ((decList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
            {
                //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";
            }
            else if ((decList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
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
            else // All 3 lists count do not equal 0, resume as normal
            {

                //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                rtbTop.Text += " " + button.Operators + " ";
                rtbLeft.Text = "";
                rtbRight.Text = "";
                //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                string strNewList = string.Join("", decList);
                decimal intNewVar = Convert.ToDecimal(strNewList);
                decResList.Add(intNewVar);
                //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                chList.Add(button.Operators);
                //Clearing decList so user can enter the second, third, fourth numbers
                decList.Clear();

                //Loop that displays operator user clicked on side displays
                for (int i = 1; i <= 10; i++)
                {
                    rtbLeft.Text += button.Operators + "\n";
                    rtbRight.Text += button.Operators + "\n";
                    await Task.Delay(60); //Cool trick here
                }
            }

        }

        private async void btnDivide_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('/');
            //Need to add numbers before operator otherwise this if statement will enter nothing until user selects a number
            if ((decList.Count == 0) && (decResList.Count == 0) && (chList.Count == 0))
            {
                //Clearing screens as all 3 lists count = 0 meaning an operator cannot be entered without integers before it. Includes +,*,/. Subtract will turn integer negative
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";
            }
            else if ((decList.Count == 0) && (decResList.Count > 0) && (chList.Count > 0))
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
            else // All 3 lists count do not equal 0, resume as normal
            {

                //Clearing left and right displays then showing only the operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
                rtbTop.Text += " " + button.Operators + " ";
                rtbLeft.Text = "";
                rtbRight.Text = "";
                //Joining the integers together then storing users number into decResList (need to do this in case user enters multiple integers ex 124)
                string strNewList = string.Join("", decList);
                decimal intNewVar = Convert.ToDecimal(strNewList);
                decResList.Add(intNewVar);
                //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on decResList
                chList.Add(button.Operators);
                //Clearing decList so user can enter the second, third, fourth numbers
                decList.Clear();

                //Loop that displays operator user clicked on side displays
                for (int i = 1; i <= 10; i++)
                {
                    rtbLeft.Text += button.Operators + "\n";
                    rtbRight.Text += button.Operators + "\n";
                    await Task.Delay(60); //Cool trick here
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (chList.Count > 0)
            {
                if (decList.Count > 0)
                {
                    //Finding how many indexes are in numbers list, then deleting the last index
                    int i = (decList.Count) - 1;//minusing 1 to get correct index
                    decList.RemoveAt(i);
                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";
                    // Looping through decResList and chList to enter all numbers and characters (operations) user previously entered
                    int intAddCh = 0, intStop = (decResList.Count), intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in decResList
                    foreach (int element in decResList)
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
                    //Looping through decList to display all integers back on display less the integer user wanted removed
                    foreach (int element in decList)
                    {
                        rtbTop.Text += element.ToString();
                    }

                }
                else // (decList.Count <= 0)
                {
                    //Finding how many indexes are in character list, then deleting the last index
                    int i = (chList.Count) - 1;
                    chList.RemoveAt(i);
                    //write something
                    if (chList.Count == 0)
                    {
                        //Clearing screen
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";
                        //Redisplaying all numbers user entered 
                        foreach(int element in decResList)
                        {
                            rtbTop.Text += element.ToString();
                        }
                        //Converting the last decResList number into decList (user's temporary numbers). Need this in case user adds or deletes more numbers
                        int j = (decResList.Count) - 1;//minusing 1 to get correct index
                        //Converting last number in decResList to a string so can go through each character to add each individual to decList
                        string strNewList = Convert.ToString(decResList[j]);
                        foreach (char element in strNewList)
                        {
                            string strNewVar = element.ToString();
                            decimal intNewVar = Convert.ToDecimal(strNewVar);
                            decList.Add(intNewVar);
                        }
                        //Removing last number in decResList as just added it to decList
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
                        foreach (int element in decResList)
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
                        //Converting the last decResList number into decList (user's temporary numbers). Need this in case user adds or deletes more numbers
                        int j = (decResList.Count) - 1;//minusing 1 to get correct index
                        //Converting last number in decResList to a string so can go through each character to add each individual to decList
                        string strNewList = Convert.ToString(decResList[j]);
                        foreach(char element in strNewList)
                        {
                            string strNewVar = element.ToString();
                            decimal intNewVar = Convert.ToDecimal(strNewVar);
                            decList.Add(intNewVar);
                        }
                        //Removing last number in decResList as just added it to decList
                        decResList.RemoveAt(j);
                       
                    }
                }
            } 
            else // if (chList.Count <= 0)
            {
                if (decList.Count > 0)
                {
                    //Finding how many indexes are in numbers list, then deleting the last index
                    int i = (decList.Count) - 1;//minusing 1 to get correct index
                    decList.RemoveAt(i);
                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";
                    //Looping through decList to display all integers back on display less the integer user wanted removed
                    foreach (int element in decList)
                    {
                        rtbTop.Text += element.ToString();
                    }
                }
                else // if (decList.Count < = 0)
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

        }

        private void btnMemory_Click(object sender, EventArgs e)
        {

        }

        private void btnClearRecent_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Clearing text from all screens and removing all elements in all lists
            rtbBottom.Text = "";
            rtbTop.Text = "";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            //Clearing all lists so user can start fresh
            decList.Clear();
            decResList.Clear();
            chList.Clear();
           
        }
    } //Form1 bracket
} //namespace bracket
  ///NOTES
/////Converting entire list into a string then displaying in rich text box
//      string newList = string.Join("", decList);
//In order to keep adding integers to displays, need to use += NOT just =
//EXAMPLE of converting a int in list to string, then subtracting one letter in that string, afterwards converting back to int
//      int i = (decResList.Count) - 1; //minusing 1 to get correct index
//      string strConvert = decResList[i].ToString();
//      int j = (strConvert.Length);
//      strConvert = strConvert.Remove(j);
//      decResList[i] = Convert.ToInt32(strConvert);
