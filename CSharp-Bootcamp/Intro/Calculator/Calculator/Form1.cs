//The only import needed for the project. Imports all the code needed for a form application
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        /*
         * Creates all the global variables needed for the project
         * All given default values by the translator
         * isComplete is set to false
         */
        double inp1;
        double inp2;
        double answer;
        string operation;
        bool isComplete = false;

        //A method created automatically by Visual Studio to create the Form our project uses
        public Form1()
        {
            InitializeComponent();
        }

        //Event for button 0 being pressed
        private void btn0_Click(object sender, System.EventArgs e)
        {
            selectNumber("0");
        }

        //Event for button 1 being pressed
        private void btn1_Click(object sender, System.EventArgs e)
        {
            selectNumber("1");
        }

        //Event for button 2 being pressed
        private void btn2_Click(object sender, System.EventArgs e)
        {
            selectNumber("2");
        }

        //Event for button 3 being pressed
        private void btn3_Click(object sender, System.EventArgs e)
        {
            selectNumber("3");
        }

        //Event for button 4 being pressed
        private void btn4_Click(object sender, System.EventArgs e)
        {
            selectNumber("4");
        }

        //Event for button 5 being pressed
        private void btn5_Click(object sender, System.EventArgs e)
        {
            selectNumber("5");
        }

        //Event for button 6 being pressed
        private void btn6_Click(object sender, System.EventArgs e)
        {
            selectNumber("6");
        }

        //Event for button 7 being pressed
        private void btn7_Click(object sender, System.EventArgs e)
        {
            selectNumber("7");
        }

        //Event for button 8 being pressed
        private void btn8_Click(object sender, System.EventArgs e)
        {
            selectNumber("8");
        }

        //Event for button 9 being pressed
        private void btn9_Click(object sender, System.EventArgs e)
        {
            selectNumber("9");
        }

        //Event for the add button being pressed
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            setInp1AndOp("add");
        }

        //Event for the subtract button being pressed
        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            setInp1AndOp("subtract");
        }

        //Event for the multiply button being pressed
        private void btnTimes_Click(object sender, System.EventArgs e)
        {
            setInp1AndOp("times");
        }

        //Event for the divide button being pressed
        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            setInp1AndOp("divide");

        }

        //A method to store the first input and operations in global variables (declared at the top). The text in the text box is then reset
        private void setInp1AndOp(string op)
        {
            inp1 = System.Convert.ToDouble(txtBoxInput.Text);
            operation = op;
            txtBoxInput.Text = "";
        }

        /*
         * Set the value of the 2nd input
         * Calculate the answer based on the 2 inputs and the operation
         * Output the operation to the screen
         * Signal that an operation has been completed
         */
        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            inp2 = System.Convert.ToDouble(txtBoxInput.Text);
            answer = calculateOutput();
            txtBoxInput.Text = answer.ToString();
            isComplete = true;
        }

        /*
         * Based on the operation calculate the output
         * for multiplication:
         *      loop through from 1 to the 2nd input
         *      each time the code loops through, it will add the value of the first input to a total
         * incase the operation tag isn't recognised return 0 as a double
         */
        private double calculateOutput()
        {
            double returnAns = 0;

            if(operation == "add")
            {
                returnAns = inp1 + inp2;
            }
            else if (operation == "subtract")
            {
                returnAns = inp1 - inp2;
            }
            else if (operation == "divide")
            {
                returnAns = inp1 / inp2;
            }
            else if (operation == "times")
            {
                for(int i = 1; i <= inp2; i++)
                {
                    returnAns = returnAns + inp1;
                }
            }
            else
            {
                returnAns = 0d;
            }

            return returnAns;
        }

        // Reset all the global varialbes and clear the text box
        private void clearData()
        {
            isComplete = false;
            inp1 = 0;
            inp2 = 0;
            operation = null;
            answer = 0;
            txtBoxInput.Text = "";
        }

        // if a calculation has just been completed, reset the data. Regardless of whether one has been completed, append the number given to the method to the text box
        private void selectNumber(string num)
        {
            if(isComplete == true)
            {
                clearData();
            }

            txtBoxInput.AppendText(num);
        }

        // When the clear button is pressed, run the clearData() method
        private void btnClear_Click(object sender, System.EventArgs e)
        {
            clearData();
        }
    }
}