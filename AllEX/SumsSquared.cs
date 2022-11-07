namespace AllEX
{
    public class SumSq
    {
        // Cach 1
        // public int a {get; set;}
        // public int b{get; set;}
        // public int Square(int a)
        // {
        //     return a * a ;     
        // }


        // Cach 2
        public void Square()
        {
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of Square is : {a * a}");
        }
    }
}