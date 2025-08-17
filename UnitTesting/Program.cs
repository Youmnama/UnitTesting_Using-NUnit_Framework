namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine( calculator.Add(2,3));
            Console.WriteLine(calculator.Subtract(5, 2));
            Console.WriteLine(calculator.Multiply(4, 3));
            try
            {
                Console.WriteLine(calculator.Divide(10, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
