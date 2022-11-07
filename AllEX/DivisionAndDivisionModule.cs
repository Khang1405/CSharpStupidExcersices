namespace AllEX
{
    public class Div
    {
        public void DivPrint()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{a/b}\n{a%b}");
        }
    }
}