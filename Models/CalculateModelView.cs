namespace Calculator.Models
{
    public class CalculateModelView
    {
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public decimal Result { get; set; }
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
