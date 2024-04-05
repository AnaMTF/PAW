using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form1 : Form
    {

        private double? _result;
        private double? _current;
        private delegate double Operation(double a, double b);
        private Operation _operation;
        public Form1()
        {
            InitializeComponent();

            _current = null;
        }

        private void AddDigit(int digit)
        {
            if (_current == null)
            {
                _current = 0;
            }
            _current = _current * 10 + digit;
            currentValueaTextBox.Text = _current.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigit(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigit(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigit(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigit(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigit(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddDigit(0);
        }

        private void executeOperation(Operation operation, string operationLabel)
        {
            if (_result == null)
            {
                _result = _current;

            }
            else if (_result != null && _current != null)
            {
                _result = _operation(_result.Value, _current.Value);
            }
            _current = null;
            _operation = operation;

            resultLabel.Text = _result.ToString() + operationLabel;
            currentValueaTextBox.Text = string.Empty;
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            executeOperation(Operations.Add, " +");
        }

        private void subtractOperationButton_Click(object sender, EventArgs e)
        {
            executeOperation(Operations.Subtract, " -");
        }

        private void divideOperationButton_Click(object sender, EventArgs e)
        {
            executeOperation(Operations.Divide, " /");
        }

        private void multiplyOperationButton_Click(object sender, EventArgs e)
        {
            executeOperation(Operations.Multiply, " *");
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (_operation != null && _current != null)
            {
                _result = _operation(_result.Value, _current.Value);
                resultLabel.Text = _result.ToString();
                _current = null;
                _operation = null;
            }

        }
    }
}
