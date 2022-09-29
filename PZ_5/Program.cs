namespace PZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char simvol = 'h';
            for (int i = -50; i <= 50; i += 10)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(simvol);
                simvol++;
            }
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    Console.WriteLine(i - j);
                }
            }
            for (int i = 0; i < 100; i++)
            {
                if (1 % 12 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 3, j = 50; j - i >= 14; i++, j--)
            {
                Console.WriteLine(i - j);
            }
        }
    }
}
