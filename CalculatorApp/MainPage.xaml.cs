namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        private string _current = "";
        private string _operator = "";
        private double _firstNumber = 0, _secondNumber = 0;

        public MainPage()
        {
            InitializeComponent();
            lblResult.Text = "0";
        }

        private void btnCClick(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            _current = "";
            _firstNumber = 0;
            _secondNumber = 0;
            _operator = "";
        }
        private void btnSQRT(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDouble(_current);
            lblResult.Text = Math.Sqrt(_firstNumber).ToString();
            _current = "";

        }

        private void btnOperatorSelect(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _firstNumber = Convert.ToDouble(_current);
            _current = "";
            _operator = btn.Text;
        }
        private void btnNumberSelect(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _current += button.Text;
            lblResult.Text = _current;

        }
        private void btnCalculate(object sender, EventArgs e)
        {
            _secondNumber += Convert.ToDouble(_current);
            switch (_operator)
            {
                case "+":
                    lblResult.Text = (_firstNumber + _secondNumber).ToString();
                    break;
                case "-":
                    lblResult.Text = (_firstNumber - _secondNumber).ToString();
                    break;
                case "*":
                    lblResult.Text = (_firstNumber * _secondNumber).ToString();
                    break;
                case "/":
                    if (_firstNumber != 0 && _secondNumber != 0)
                    {
                        lblResult.Text = (_firstNumber / _secondNumber).ToString();
                        break;
                    }
                    else
                    {
                        lblResult.Text = "Invalid Operation";
                        break;
                    }
                case "%":
                    if (_firstNumber != 0 && _secondNumber != 0)
                    {
                        lblResult.Text = (_firstNumber % _secondNumber).ToString();
                        break;
                    }
                    else
                    {
                        lblResult.Text = "Invalid Operation";
                        break;
                    }
            }

        }



    }

}
