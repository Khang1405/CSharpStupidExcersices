namespace EX1
{
    class Program
    {
        public static float AddAndMultiply(float a, float b, float c)
        {
            return (a + b) * c;
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine(AddAndMultiply(2,4,5));
        }
    }
}