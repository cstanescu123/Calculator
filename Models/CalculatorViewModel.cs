namespace Calculator.Models
{
    public class CalculatorViewModel
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }
        public CalculationMethod calculationMethod { get; set; }
    }
    public enum CalculationMethod
    {
        Addition = '+',
        Subtraction = '-',
        Multiplication = '*',
        Division = '/'
    }
}