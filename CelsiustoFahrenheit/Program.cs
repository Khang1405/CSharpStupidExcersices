namespace EX2
{
    class Program
    {
        static void CtoF (double c)
        {
            if (c < -271.15) 
            {
                Console.WriteLine("Temperature below absolute zero!");
            }
            else
            {
                Console.WriteLine($"T = {(c * 1.8) + 32}F");
            }
        }
        static void Main(string[] args)
        {
            CtoF(0);
            CtoF(100);
            CtoF(-300);
        } 
    }
}