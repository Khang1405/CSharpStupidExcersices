namespace AllEX
{
    public class DivByZ
    {
        public void DivZ()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine($"{a} / {b} = {a/b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can not divide by zero");
            } 
        }
    }
}
