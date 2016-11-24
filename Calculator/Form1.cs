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
        //Variable for storing Buttons object and _button name is private b/c won't need it anywhere else
        //MANUALLY ASSIGNING VARIABLE private Buttons _button;
        public List<int> iList = new List<int>();
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

        //ALL BUTTON EVENT BELOW
        private void btnZero_Click(object sender, EventArgs e)
        {
            //Creating new object by passing 0 and adding that number to list in Buttons class
            Buttons button = new Buttons(0);
            RemoveZero();
            iList.Add(0);
            //foreach (int element in iList)
            //{
            //    MessageBox.Show(element.ToString());
            //}
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
            Buttons button = new Buttons(1);
            RemoveZero();
            iList.Add(1);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(2);
            RemoveZero();
            iList.Add(2);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Buttons button = new Buttons(3);
            RemoveZero();
            iList.Add(3);
            rtbTop.Text += button.Numbers;
            rtbLeft.Text += button.Numbers + "\n";
            rtbRight.Text += button.Numbers + "\n";
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
            RemoveZero();
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
            RemoveZero();
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

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

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

        }
    } //Form1 bracket
} //namespace bracket
