using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calculator
{
    internal class CalculatorController
    {
        private CalculatorModel model;
        private CalculatorForm view;

        public CalculatorController(CalculatorModel model, CalculatorForm view)
        {
            this.model = model;
            this.view = view;

            this.view.Calculate += Calculate;
        }

        public void Calculate(object sender, EventArgs e)
        {
            double result = 0;
            try
            {
                model.Operand1 = double.Parse(view.FirstOperand);
                model.Operand2 = double.Parse(view.SecondOperand);
                model.Operator = view.Operator;

                result = model.PerformOperation();
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
                return;
            }

            view.DisplayResult(result);
        }
    }
}
