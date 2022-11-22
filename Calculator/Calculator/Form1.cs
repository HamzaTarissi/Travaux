using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Numbers
        private void dot_Click(object sender, EventArgs e)
        {
            Insertvalue(".");
            Focustext();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Insertvalue("0");
            Focustext();
        }

        private void three_Click(object sender, EventArgs e)
        {
            Insertvalue("3");
            Focustext();
        }

        private void two_Click(object sender, EventArgs e)
        {
            Insertvalue("2");
            Focustext();
        }

        private void one_Click(object sender, EventArgs e)
        {
            Insertvalue("1");
            Focustext();
        }

        private void six_Click(object sender, EventArgs e)
        {
            Insertvalue("6");
            Focustext();
        }

        private void five_Click(object sender, EventArgs e)
        {
            Insertvalue("5");
            Focustext();
        }

        private void four_Click(object sender, EventArgs e)
        {
            Insertvalue("4");
            Focustext();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Insertvalue("9");
            Focustext();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Insertvalue("8");
            Focustext();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Insertvalue("7");
            Focustext();
        }
        #endregion
        #region Delete and clearing
        private void CE_Click(object sender, EventArgs e)
        {
            this.UserTextInput.Text = string.Empty;
            Focustext();
        }
        private void Del_Click(object sender, EventArgs e)
        {
            this.UserTextInput.Text = string.Empty;
            Focustext();
        }
        #endregion
        #region Operators
        private void Pourcentage_Click(object sender, EventArgs e)
        {
            Insertvalue("%");
            Focustext();

        }
        private void equal_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            Focustext();
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            Insertvalue("*");
            Focustext();
        }
        private void minus_Click(object sender, EventArgs e)
        {
            Insertvalue("-");
            Focustext();
        }
        private void plus_Click(object sender, EventArgs e)
        {
            Insertvalue("+");
            Focustext();
        }
        #endregion
        #region textfocus
        private void Focustext()
        {
            this.UserTextInput.Focus();
        }
        #endregion
        #region insertion 
        private void Insertvalue(string value)
        {
            var selectionStart = this.UserTextInput.SelectionStart;

            //insert the value in the selection start 
            this.UserTextInput.Text = this.UserTextInput.Text.Insert(this.UserTextInput.SelectionStart, value);

            //the selection start
            this.UserTextInput.SelectionStart = selectionStart + value.Length;

            //after finishing we set the selection length to zero
            this.UserTextInput.SelectionLength = 0;
        }
        #endregion
        #region calculator
        private void CalculateEquation()
        {
            var userTextInput = this.UserTextInput.Text;
            this.Calculationresult.Text = Parseoperation();
            var resut = Parseoperation();

            Focustext();
        }

        private string Parseoperation()
        {
            try
            {
                var userinput = this.UserTextInput.Text;
                //to clear the spaces
                userinput = userinput.Replace(" ", "");
                //the new operation after the initial one
                var operation = new Operation();
                var leftSide = true;
                for (int i = 0; i < userinput.Length; i++)
                {
                    if ("0123456789.".Any(c => userinput[i] == c))
                    {
                        if (leftSide)
                            operation.leftside = AddNumberPart(operation.leftside, userinput[i]);
                        else
                            operation.rightside = AddNumberPart(operation.rightside, userinput[i]);
                    }
                    //if it is an operator ( + - * / ) set the operator type
                    else if ("+-*/".Any(c => userinput[i] == c))
                    {
                        if (!leftSide)
                        {
                            //get the operator type
                            var operatorType = getoperationtype(userinput[i]);

                            //check if we actually have a rightside number
                            if (operation.rightside.Length == 0)
                            {
                                //check if the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != operationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an left side number");

                                //the operator type is a minus, and there is no left number currently, so we add the minus to the number
                                operation.leftside += userinput[i];
                            }
                            else
                            {
                                //we have a left number and now an operator, we want to move to the right side
                                operation.operationType = operatorType;

                                //move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }
                return calculateoperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        private string AddNumberPart(string currentnumber, char newcharacter)
        {
            //checking if there is already a . in the number
            if (newcharacter == '.' && currentnumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentnumber} already contains a . and another cannot be added");

            return currentnumber + newcharacter;
        }
        //accept an operator + if the input is wrong the operator will be denied
        private operationType getoperationtype (char character)
        {
            switch (character)
            {
                case '+':
                    return operationType.Add;
                case '-':
                    return operationType.Minus;
                case '/':
                    return operationType.Divide;
                case '*':
                    return operationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }
        private string calculateoperation(Operation operation)
        {
            double left = 0;
            double right = 0;
            if (string.IsNullOrEmpty(operation.leftside) || !double.TryParse(operation.leftside, out left ))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.leftside}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.rightside) || !double.TryParse(operation.rightside, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.rightside}");

            try
            {
                switch (operation.operationType)
                {
                    case operationType.Add:
                        return (left + right).ToString();
                    case operationType.Minus:
                        return (left - right).ToString();
                    case operationType.Divide:
                        return (left / right).ToString();
                    case operationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. {operation.operationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.leftside} {operation.operationType} {operation.rightside}. {ex.Message}");
            }
        }
        #endregion
    }
}