namespace Clalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cal = new Calculator();
            Console.WriteLine($"Add: {cal.Add(10,22)}");
            Console.WriteLine($"Substruct: {cal.Substruct(10,22)}");
            Console.WriteLine($"Multiply: {cal.Multiply(10,22)}");
        }
    }
}