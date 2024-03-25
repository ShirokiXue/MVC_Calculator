using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Calculator
{
    public partial class CalculatorForm
    {
        public event EventHandler Calculate;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        public string FirstOperand => txtFirstOperand.Text;
        public string SecondOperand => txtSecondOperand.Text;
        public char Operator => txtOperator.Text[0];
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void DisplayResult(double result)
        {
            Console.WriteLine("Display result.");
            txtResult.Text = result.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate?.Invoke(this, EventArgs.Empty);
        }
    }
}
