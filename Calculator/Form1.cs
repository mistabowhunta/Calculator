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
        //MANUALLY ASSIGNING VARIABLEVariable for storing Buttons object and _button name is private b/c won't need it anywhere else
        //MANUALLY ASSIGNING VARIABLE private Buttons _button;
        //Creating list to store all user's numbers and characters to perform calculations. Need to make it an object list to accept different dataypes
        public List<int> iList = new List<int>();
        public List<int> iResList = new List<int>();
        public List<char> chList = new List<char>();
        public int i = 0;
        public int j = 1;
        public Form1()
        {
            //Constructor for form
            InitializeComponent();
            
            //Creating/instantiating new Buttons object then passing default value to Buttons Class 
            Buttons button = new Buttons(0);
            //iList.Add(0);
            //MANUALLY ASSIGNING VARIABLE Creating/instantiating new Buttons object then assigns it to _button variable
            //MANUALLY ASSIGNING VARIABLE _button = new Buttons();

            //MANUALLY ASSIGNING VARIABLE Assigning value to _button object
            //MANUALLY ASSIGNING VARIABLE _button.Numbers = 10;
            //Getting values of the properties from the button object and assigning to the rich text box on screen

            //Setting text alignment for top display to right
            rtbTop.SelectionAlignment = HorizontalAlignment.Right;
            //Setting text alignment for left and right displays to center
            rtbLeft.SelectionAlignment = HorizontalAlignment.Center;
            rtbRight.SelectionAlignment = HorizontalAlignment.Center;
            rtbBottom.SelectionAlignment = HorizontalAlignment.Center;
            //Setting all displays to default zero value
            //rtbTop.Text = button.Numbers.ToString();
            //rtbLeft.Text = button.Numbers.ToString();
            //rtbRight.Text = button.Numbers.ToString();
        }
       
        //ALL BUTTON EVENTS BELOW
            //THESE ARE THE NUMBERS
        private void btnZero_Click(object sender, EventArgs e)
        {
            //Creating new object by passing 0 and adding that number to list in Buttons class
            Buttons button = new Buttons(0);
            iList.Add(0);
            rtbTop.Text += button.Numbers;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(1);
            iList.Add(1);
            rtbTop.Text += button.Numbers;
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(2);
            iList.Add(2);
            rtbTop.Text += button.Numbers;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(3);
            iList.Add(3);
            rtbTop.Text += button.Numbers;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(4);
            iList.Add(4);
            rtbTop.Text += button.Numbers;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(5);
            iList.Add(5);
            rtbTop.Text += button.Numbers;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(6);
            iList.Add(6);
            rtbTop.Text += button.Numbers;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(7);
            iList.Add(7);
            rtbTop.Text += button.Numbers;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(8);
            iList.Add(8);
            rtbTop.Text += button.Numbers;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(9);
            iList.Add(9);
            rtbTop.Text += button.Numbers;
        }

        //THESE ARE THE OPERATORS/CHARACTERS
        private void btnPeriod_Click(object sender, EventArgs e)
        {
           // //In case user needs a fractional number, changing default zero in list to period so it will correctly calcalate in the future
           // iList[0] = '.';
           // //Clearing all screens to enter "0."
           // rtbTop.Text = "";
           // rtbLeft.Text = "";
           // rtbRight.Text = "";

           // rtbTop.Text += "0.";
           // rtbLeft.Text += "0" + "\n";
           // rtbLeft.Text += "." + "\n";
           // rtbRight.Text += "0" + "\n";
           // rtbRight.Text += "." + "\n";
        
            
           //else if(iList.Contains('.'))
           // {
           //     //Returning nothing basically so if user enters more than one period it will not display to screens or add to lists
           //     return;
           // }
           // else
           // {
                //If there are no periods in list, add one
                Buttons button = new Buttons('.');
                iList.Add('.');
                rtbTop.Text += button.Operators;
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
            //}
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //When user clicks equal button, need to capture the last number/s entered. Those #'s are placed in the iResList for calculation 
            string strNewList = string.Join("", iList);
            int intNewVar = Convert.ToInt32(strNewList);
            iResList.Add(intNewVar);
            int intListTracker = 1, intResult = 0;
            
            foreach (char element in chList)
            {
  
                if (element == '+')
                {
                    if (intListTracker == 1)
                    {
                        intResult = iResList[0] + iResList[intListTracker];
                        intListTracker++;
                    }
                    else
                    {
                        intResult = intResult + iResList[intListTracker];
                        intListTracker++;
                    }
                }
                else if (element == '-')
                {
                    if (intListTracker == 1)
                    {
                        intResult = iResList[0] - iResList[intListTracker];
                        intListTracker++;
                    }
                    else
                    {
                        intResult = intResult - iResList[intListTracker];
                        intListTracker++;
                    }
                }
                else if (element == '*')
                {
                    if (intListTracker == 1)
                    {
                        intResult = iResList[0] * iResList[intListTracker];
                        intListTracker++;
                    }
                    else
                    {
                        intResult = intResult * iResList[intListTracker];
                        intListTracker++;
                    }
                }
                else if (element == '/')
                {
                    if (intListTracker == 1)
                    {
                        intResult = iResList[0] / iResList[intListTracker];
                        intListTracker++;
                    }
                    else
                    {
                        intResult = intResult / iResList[intListTracker];
                        intListTracker++;
                    }
                }
            }
            iList.Clear();
            chList.Clear();
            iResList.Clear();
            iList.Add(intResult);
            rtbTop.Text = intResult.ToString();
            rtbBottom.Text = intResult.ToString();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('+');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            //Joining the integers together then storing users number into iResList (need to do this in case user enters multiple integers ex 124)
            string strNewList = string.Join("", iList);
            int intNewVar = Convert.ToInt32(strNewList);
            iResList.Add (intNewVar);
            //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on iResList
            chList.Add('+');
            //Clearing iList so user can enter the second, third, fourth numbers
            iList.Clear();
           
            //Loop that displays operator user clicked on side displays
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(75); //Cool trick here
            }
        }

        private async void btnSubtract_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('-');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";

            //If there is nothing in temporary iList, do not need to add any integers to iResList
            if (iList.Count == 0)
            {
                chList.Add('-');
            }
            else
            {
                //Joining the integers together then storing users number into iResList (need to do this in case user enters multiple integers ex 124)
                string strNewList = string.Join("", iList);
                int intNewVar = Convert.ToInt32(strNewList);
                iResList.Add(intNewVar);
                //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on iResList
                chList.Add('-');
                //Clearing iList so user can enter the second, third, fourth numbers
                iList.Clear();
            }
          
            //Loop that displays operator user clicked on side displays
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(75); //Cool trick here
            }
        }

        private async void btnMultiply_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('*');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            //Joining the integers together then storing users number into iResList (need to do this in case user enters multiple integers ex 124)
            string strNewList = string.Join("", iList);
            int intNewVar = Convert.ToInt32(strNewList);
            iResList.Add(intNewVar);
            //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on iResList
            chList.Add('*');
            //Clearing iList so user can enter the second, third, fourth numbers
            iList.Clear();

            //Loop that displays operator user clicked on side displays
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(75); //Cool trick here
            }
        }

        private async void btnDivide_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('/');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            //Joining the integers together then storing users number into iResList (need to do this in case user enters multiple integers ex 124)
            string strNewList = string.Join("", iList);
            int intNewVar = Convert.ToInt32(strNewList);
            iResList.Add(intNewVar);
            //Adding operator to chList so can perform calculation when user clicks equals. The algorithm in equals button keeps track of what operation to perform on iResList
            chList.Add('/');
            //Clearing iList so user can enter the second, third, fourth numbers
            iList.Clear();

            //Loop that displays operator user clicked on side displays
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(75); //Cool trick here
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (chList.Count > 0)
            {
                if (iList.Count > 0)
                {
                    //Finding how many indexes are in numbers list, then deleting the last index
                    int i = (iList.Count) - 1;//minusing 1 to get correct index
                    iList.RemoveAt(i);
                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";
                    // Looping through iResList and charlist to enter all numbers and characters (operations) user previously entered
                    int intAddCh = 0, intStop = (iResList.Count), intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in iResList
                    foreach (int element in iResList)
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
                    //Looping through iList to display all integers back on display less the integer user wanted removed
                    foreach (int element in iList)
                    {
                        rtbTop.Text += element.ToString();
                    }

                }
                else // (iList.Count <= 0)
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
                        foreach(int element in iResList)
                        {
                            rtbTop.Text += element.ToString();
                        }
                        //Converting the last iResList number into iList (user's temporary numbers). Need this in case user adds or deletes more numbers
                        int j = (iResList.Count) - 1;//minusing 1 to get correct index
                        //Converting last number in iResList to a string so can go through each character to add each individual to iList
                        string strNewList = Convert.ToString(iResList[j]);
                        foreach (char element in strNewList)
                        {
                            string strNewVar = element.ToString();
                            int intNewVar = Convert.ToInt32(strNewVar);
                            iList.Add(intNewVar);
                        }
                        //Removing last number in iResList as just added it to iList
                        iResList.RemoveAt(j);
                    }
                    else //(chList.Count > 0)
                    {
                        //Clearing screen
                        rtbTop.Text = "";
                        rtbLeft.Text = "";
                        rtbRight.Text = "";
                        //Redisplaying all numbers in iResList and all characters user previously entered less the last character (operator)
                        int intAddCh = 0, intStop = (iResList.Count) - 1, intCurrentIndex = 0; //intStop tells loop to stop adding characters to display as none need to be added after last # in iResList
                        foreach (int element in iResList)
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
                        //Converting the last iResList number into iList (user's temporary numbers). Need this in case user adds or deletes more numbers
                        int j = (iResList.Count) - 1;//minusing 1 to get correct index
                        //Converting last number in iResList to a string so can go through each character to add each individual to iList
                        string strNewList = Convert.ToString(iResList[j]);
                        foreach(char element in strNewList)
                        {
                            string strNewVar = element.ToString();
                            int intNewVar = Convert.ToInt32(strNewVar);
                            iList.Add(intNewVar);
                        }
                        //Removing last number in iResList as just added it to iList
                        iResList.RemoveAt(j);
                       
                    }
                }
            } 
            else // if (chList.Count <= 0)
            {
                if (iList.Count > 0)
                {
                    //Finding how many indexes are in numbers list, then deleting the last index
                    int i = (iList.Count) - 1;//minusing 1 to get correct index
                    iList.RemoveAt(i);
                    //Clearing screens
                    rtbTop.Text = "";
                    rtbLeft.Text = "";
                    rtbRight.Text = "";
                    //Looping through iList to display all integers back on display less the integer user wanted removed
                    foreach (int element in iList)
                    {
                        rtbTop.Text += element.ToString();
                    }
                }
                else // if (iList.Count < = 0)
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
            iList.Clear();
            iResList.Clear();
            chList.Clear();
           
        }
    } //Form1 bracket
} //namespace bracket
  ///NOTES
/////Converting entire list into a string then displaying in rich text box
//      string newList = string.Join("", iList);
//In order to keep adding integers to displays, need to use += NOT just =
//EXAMPLE of converting a int in list to string, then subtracting one letter in that string, afterwards converting back to int
//      int i = (iResList.Count) - 1; //minusing 1 to get correct index
//      string strConvert = iResList[i].ToString();
//      int j = (strConvert.Length);
//      strConvert = strConvert.Remove(j);
//      iResList[i] = Convert.ToInt32(strConvert);
