namespace EX3
{
    class Program
    {
        static void ElementaryOperations(int a, int b)
        {
            if( b == 0)
            {
                Console.WriteLine("Deo chia duoc!!");
            }
            else
            {
                Console.WriteLine($"{a+b}, {a-b} , {a*b}, {(float)a/ (float)b}");
            }
        }
        static void Main(string[] args)
        {
            ElementaryOperations(3, 8);
        }
    }   
}