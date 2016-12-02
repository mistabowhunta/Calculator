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
        public List<string> sList = new List<string>();
        public List<char> chList = new List<char>();
        public int i = 0;
        public int j = 1;
        public Form1()
        {
            //Constructor for form
            InitializeComponent();
            
            //Creating/instantiating new Buttons object then passing default value to Buttons Class 
            Buttons button = new Buttons(0);
            iList.Add(0);
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
            //Setting all displays to default zero value
            rtbTop.Text = button.Numbers.ToString();
            rtbLeft.Text = button.Numbers.ToString();
            rtbRight.Text = button.Numbers.ToString();
        }
        //Removing default 0 in form display so it doesn't lead with a zero once user enters numbers. Also removing from list
        public void RemoveZero()
        {
            if(iList[0] == 0)
            {
                iList.RemoveAt(0);
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";
            }
        }
       
        //ALL BUTTON EVENTS BELOW
            //THESE ARE THE NUMBERS
        private void btnZero_Click(object sender, EventArgs e)
        {
            //Creating new object by passing 0 and adding that number to list in Buttons class
            Buttons button = new Buttons(0);
            RemoveZero();
            iList.Add(0);
            foreach (int element in iList)
            {
                MessageBox.Show(element.ToString());
            }
            //Converting entire list into a string then displaying in rich text box
            //string newList = string.Join("", iList);
            //In order to keep adding integers, need to use += NOT just =
            //For left and right displays need the numbers to go vertical so adding new line after each number
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            //Buttons button = new Buttons(1);
            //RemoveZero();
            //iList.Add(1);
            Buttons button = new Buttons("+");
            sList.Add("+");
            rtbTop.Text += button.Strings;
            
            //rtbTop.Text += button.Numbers;
            //rtbLeft.Text += button.Numbers + "\n";
            //rtbRight.Text += button.Numbers + "\n";
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            //Buttons button = new Buttons(2);
            //RemoveZero();
            //iList.Add(2);
            Buttons button = new Buttons("2");
            sList.Add("2");
            rtbTop.Text += button.Strings;

            //rtbTop.Text += button.Numbers;
            //rtbLeft.Text += button.Numbers + "\n";
            //rtbRight.Text += button.Numbers + "\n";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            //Buttons button = new Buttons(3);
            //RemoveZero();
            //iList.Add(3);
            Buttons button = new Buttons("3");
            sList.Add("3");
            rtbTop.Text += button.Strings;

            //rtbTop.Text += button.Numbers;
            //rtbLeft.Text += button.Numbers + "\n";
            //rtbRight.Text += button.Numbers + "\n";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(4);
            RemoveZero();
            iList.Add(4);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(5);
            //RemoveZero();
            iList.Add(5);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(6);
            RemoveZero();
            iList.Add(6);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(7);
            RemoveZero();
            iList.Add(7);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(8);
            //RemoveZero();
            iList.Add(8);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(9);
            RemoveZero();
            iList.Add(9);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

            //THESE ARE THE OPERATORS/CHARACTERS
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (iList[0] == 0)
            {
                //In case user needs a fractional number, changing default zero in list to period so it will correctly calcalate in the future
                iList[0] = '.';
                //Clearing all screens to enter "0."
                rtbTop.Text = "";
                rtbLeft.Text = "";
                rtbRight.Text = "";

                rtbTop.Text += "0.";
                rtbLeft.Text += "0" + "\n";
                rtbLeft.Text += "." + "\n";
                rtbRight.Text += "0" + "\n";
                rtbRight.Text += "." + "\n";
            }
           else if(iList.Contains('.'))
            {
                //Returning nothing basically so if user enters more than one period it will not display to screens or add to lists
                return;
            }
            else
            {
                //If there are no periods in list, add one
                Buttons button = new Buttons('.');
                iList.Add('.');
                rtbTop.Text += button.Operators;
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
            }
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string strNewList = string.Join("", iList);
            int intNewVar = Convert.ToInt32(strNewList);
            iResList.Add(intNewVar);
            int i = 0;
            int j = 1;

            foreach (char element in chList)
            {
                int intResult = 0;
                
                if (element == '+')
                {
                    if (i == 0)
                    {
                        intResult = iResList[i] + iResList[j];
                        rtbTop.Text = intResult.ToString();
                        i=i+2;
                        j=j+2;
                    }
                    else
                    {
                        intResult = intResult + iResList[j];
                        rtbTop.Text = intResult.ToString();
                        j++;
                    }
                  

                }
                iList.Clear();
                iList.Add(intResult);
           
            }
           
            

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('+');
            //Adding operator to list so can calculate correctly in future
            //iList.Add('+');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            string strNewList = string.Join("", iList);
            int intNewVar = Convert.ToInt32(strNewList);
            //newIntVar = newIntVar + 1;
            //rtbTop.Text += intNewVar.ToString();
            iResList.Add (intNewVar);
            chList.Add('+');
            iList.Clear();


            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(200); //Cool trick here
            }
        }

        private async void btnSubtract_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('-');
            //Adding operator to list so can calculate correctly in future
            iList.Add('-');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(200); //Cool trick here
            }
        }

        private async void btnMultiply_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('*');
            //Adding operator to list so can calculate correctly in future
            iList.Add('*');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(200); //Cool trick here
            }
        }

        private async void btnDivide_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons('/');
            //Adding operator to list so can calculate correctly in future
            iList.Add('/');
            //Clearing left and right displays then showing only the  operator in both displays. Cool trick to use ASYNC and AWAIT to pause the for loop iteration while form still running
            rtbTop.Text += " " + button.Operators + " ";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                rtbLeft.Text += button.Operators + "\n";
                rtbRight.Text += button.Operators + "\n";
                await Task.Delay(200); //Cool trick here
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Finding how many indexes are in numbers list, then deleting the last index then displaying list on screen
            int i = (iList.Count) - 1;//minusing 1 to get correct index
            iList.RemoveAt(i);
            //Clearing screens
            rtbTop.Text = "";
            rtbLeft.Text = "";
            rtbRight.Text = "";
            foreach (int element in iList)
            {
                //Keeping tabs of what index the loop is at so can change char string value into 
                i = 1;
                i++;
                if (element == 46)
                {
                    iList[i] = '.';
                    //Convert.ToChar(element);
                }
                
                rtbTop.Text += element.ToString();
                rtbLeft.Text += element.ToString() + "\n";
                rtbRight.Text += element.ToString() + "\n";
            }

        }

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
            iList.Clear();
            iResList.Clear();
            //ISAAC CLEAR ALL FUTURE LISTS HERE
            //Adding 0 back to first index so screens output the default zero. Also if list has nothing it will error when enter RemoveZero method
            iList.Add(0);
            rtbTop.Text += iList[0];
            rtbLeft.Text += iList[0] + "\n";
            rtbRight.Text += iList[0] + "\n";
        }
    } //Form1 bracket
} //namespace bracket
  ///NOTES
/////Converting entire list into a string then displaying in rich text box
//      string newList = string.Join("", iList);
//In order to keep adding integers to displays, need to use += NOT just =
