using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private char[] operatorChars = { '+', '-', '*', '/' };
        private char separatorChar = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
        private bool afterResult = false;
        private string resultBuffer = "";
        public Form1()
        {
            InitializeComponent();
        }
        private bool textLengthCheck()
        {
            if ((displayBox.Text.Length) >= 16) return false;
            return true;
        }
        private void overwriteZero()
        {

            if (displayBox.Text == "0") { displayBox.Text = ""; }
        }
        private bool checkForNegatives()
        {
            for (int i = 1; i < displayBox.Text.Length - 1; i++)
            {
                foreach (char oper in operatorChars)
                {
                    if (displayBox.Text[i] == oper && displayBox.Text[i + 1] == '-')
                    {
                        return true;
                    }
                }
            }
            if (displayBox.Text[0] == '-') { return true; }
            return false;
        }
        private bool validToInsertSeparator()
        {
            char sep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            int eh;
            bool flag = true;
            char lastChar = displayBox.Text[displayBox.Text.Length - 1];
            if (int.TryParse(lastChar.ToString(), out eh))
            {

                for (int i = 1; i < displayBox.Text.Length - 1; i++)
                {

                    foreach (char oper in operatorChars)
                    {
                        if (displayBox.Text[i] == oper)
                        {
                            int x;
                            if (int.TryParse(displayBox.Text[i + 1].ToString(), out x)) { flag = true; }
                            else { flag = false; }
                        }
                    }
                    if (displayBox.Text[i] == sep) { flag = false; }

                }
            }
            if (displayBox.Text[displayBox.Text.Length - 1] == sep) { flag = false; }
            return flag;
        }
        private void calculate()
        {
            double x = 0;
            double y = 0;
            int option = 0;
            if (displayBox.Text.Contains("+")) { option = 1; }
            if (displayBox.Text.Contains("-") && !checkForNegatives()) { option = 2; }
            if (displayBox.Text.Contains("*")) { option = 3; }
            if (displayBox.Text.Contains("/")) { option = 4; }
            int minusCount = 0;
            for (int i = 0; i < displayBox.Text.Length; i++) { if (displayBox.Text[i] == '-') { minusCount++; } }
            if (minusCount > 1 && option == 0) { option = 5; }
            switch (option)
            {
                case 1:
                    {
                        string[] parts = displayBox.Text.Split('+');
                        x = double.Parse(parts[0]);
                        if (parts[1] == "") { y = x; }
                        else { y = double.Parse(parts[1]); }
                        displayBox.Text = (x + y).ToString();

                        break;
                    }

                case 2:
                    {
                        if (displayBox.Text[0] == '-') { displayBox.Text = displayBox.Text.Remove(0, 1); }
                        string[] parts = displayBox.Text.Split('-');
                        x = double.Parse(parts[0]);
                        if (parts[1] == "") { y = x; }
                        else { y = double.Parse(parts[1]); }
                        displayBox.Text = (x - y).ToString();
                        break;
                    }
                case 3:
                    {
                        string[] parts = displayBox.Text.Split('*');
                        x = double.Parse(parts[0]);
                        if (parts[1] == "") { y = x; }
                        else { y = double.Parse(parts[1]); }
                        displayBox.Text = (x * y).ToString();
                        break;
                    }
                case 4:
                    {
                        string[] parts = displayBox.Text.Split('/');

                        x = double.Parse(parts[0]);
                        if (parts[1] == "") { y = x; }
                        else { y = double.Parse(parts[1]); }
                        if (y == 0) { displayBox.Text = "Zero Division Error"; return; }

                        displayBox.Text = (x / y).ToString();
                        break;
                    }
                case 5:
                    {
                        string operand1 = "";
                        string operand2 = "";
                        bool appendToSecond = false;
                        operand1 += displayBox.Text[0];
                        for (int i = 1; i < displayBox.Text.Length; i++)
                        {
                            if (displayBox.Text[i] == '-' && appendToSecond == false) { appendToSecond = true; }
                            else
                            {
                                if (appendToSecond == false) { operand1 += displayBox.Text[i]; }
                                else { operand2 += displayBox.Text[i]; }
                            }
                        }
                        double.TryParse(operand1, out x);
                        double.TryParse(operand2, out y);
                        displayBox.Text = (x - y).ToString();
                        break;
                    }
            }
            decimal result;
            if (decimal.TryParse(displayBox.Text, out result))
            {
                displayBox.Text = Math.Round(result, 6).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberButtonClick(object sender, EventArgs e)
        {
            overwriteZero();
            if (afterResult) { afterResult = false; resultBuffer = ""; displayBox.Text = ""; }
            if (displayBox.Text.Length > 16) { displayBox.Text = ""; }
            if (displayBox.Text.Length > 2)
            {
                foreach (char oper in operatorChars)
                {
                    if (displayBox.Text[displayBox.Text.Length - 1] == '0' && displayBox.Text[displayBox.Text.Length - 2] == oper)
                    {
                        displayBox.Text = displayBox.Text.Remove(displayBox.Text.Length - 1, 1);
                    }
                }
            }

            if (textLengthCheck()) { displayBox.Text += (sender as Button).Text; }

        }

        private void resultClick(object sender, EventArgs e)
        {
            if (afterResult)
            {
                displayBox.Text += resultBuffer;
            }
            for (int i = 1; i < displayBox.Text.Length; i++)
            {
                foreach (char oper in operatorChars)
                {
                    if (displayBox.Text[i] == oper) { resultBuffer = displayBox.Text.Substring(i); }
                }
                if (displayBox.Text[displayBox.Text.Length - 1] == separatorChar) { displayBox.Text = displayBox.Text.Remove(displayBox.Text.Length - 1, 1); }
                calculate();
                afterResult = true;
            }
        }



        private void separatorClick(object sender, EventArgs e)
        {
            if (textLengthCheck())
            {
                if (validToInsertSeparator())
                {
                    bool plainSeparator = true;
                    int place = -1;
                    for (int i = 1; i < displayBox.Text.Length; i++)
                    {
                        foreach (char oper in operatorChars)
                        {
                            if (displayBox.Text[i] == oper && place == -1) { place = i; }
                        }
                    }
                    if (place == displayBox.Text.Length - 1 || (place == displayBox.Text.Length - 2 && displayBox.Text[place + 1] == '-')) { plainSeparator = false; }
                    if (plainSeparator) { displayBox.Text += (sender as Button).Text; }
                    else { displayBox.Text += "0" + (sender as Button).Text; }

                }
            }
        }

        private void signChangeClick(object sender, EventArgs e)
        {
            bool onSecond = false;
            int place = -1;
            if (textLengthCheck() && displayBox.Text != "0")
            {
                for (int i = 1; i <= displayBox.Text.Length - 1; i++)
                {
                    foreach (char oper in operatorChars)
                    {
                        if (displayBox.Text[i] == oper && place == -1) { onSecond = true; place = i; }
                    }
                }
                if (onSecond == false)
                {
                    if (displayBox.Text[0] != '-')
                    {
                        displayBox.Text = "-" + displayBox.Text;
                    }
                    else
                    {
                        displayBox.Text = displayBox.Text.Remove(0, 1);
                    }
                }
                else
                {
                    if (place == displayBox.Text.Length - 1)
                    {
                        string x = displayBox.Text;
                        x = x.Remove(x.Length - 1, 1);
                        double subst;
                        double.TryParse(x, out subst);
                        subst *= (-1.0);
                        displayBox.Text += subst.ToString();
                    }
                    else
                    {
                        if (displayBox.Text[place + 1] != '-')
                        {
                            string substring = displayBox.Text.Substring(place + 1);
                            displayBox.Text = displayBox.Text.Remove(place + 1, substring.Length);
                            substring = '-' + substring;
                            displayBox.Text += substring;
                        }
                        else
                        {
                            displayBox.Text = displayBox.Text.Remove(place + 1, 1);
                        }

                    }
                }


            }
        }


        private void operationsClick(object sender, EventArgs e)
        {
            if (textLengthCheck())
            {

                afterResult = false;
                resultBuffer = "";
                calculate();
                displayBox.Text += (sender as Button).Text;
            }
        }

        private void clearClick(object sender, EventArgs e)
        {
            displayBox.Text = "0";
        }

        private void backspaceClick(object sender, EventArgs e)
        {
            if (displayBox.Text.Length > 16) { displayBox.Text = "0"; }
            if (displayBox.Text.Length == 1) { displayBox.Text = "0"; }
            else { displayBox.Text = displayBox.Text.Remove((displayBox.Text.Length) - 1, 1); }
        }
    
}
}
