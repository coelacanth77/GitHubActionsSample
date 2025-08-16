namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Addメソッドの呼び出し
            int sum = Culc.Add(10, 5);
            Console.WriteLine($"10 + 5 = {sum}");

            // Subtractメソッドの呼び出し
            int difference = Culc.Subtract(10, 5);
            Console.WriteLine($"10 - 5 = {difference}");

            // Multiplyメソッドの呼び出し
            int product = Culc.Multiply(10, 5);
            Console.WriteLine($"10 * 5 = {product}");

            // Divideメソッドの呼び出し
            try
            {
                double quotient = Culc.Divide(10, 5);
                Console.WriteLine($"10 / 5 = {quotient}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"エラー: {ex.Message}");
            }
        }
    }
}
