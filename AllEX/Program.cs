namespace AllEX 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Square");
            // Cach 1
            // SumSq sq = new SumSq();
            // sq.a  = Int32.Parse(Console.ReadLine());
            // Console.WriteLine($"Sum of Square is : {sq.Square(sq.a)}");
            // Cach 2
            SumSq sq  = new SumSq();
            sq.Square();
            // Multiplication of three factors
            Console.WriteLine("Multiplication of three factors");
            TimesMultiplier tm = new TimesMultiplier(); 
            tm.Cal();
            //Division and division module
            Console.WriteLine("Division and division module");
            Div div = new Div();
            div.DivPrint();
            // Division by zero
            Console.WriteLine("Division by zero");
            DivByZ divz = new DivByZ();
            divz.DivZ();
        }
    }
}