namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[20], mas2 = new int[30];
            int a = 300, b = 1;
            bool flag = true;
            for (int i = 0; i < mas1.Length; i++)
            {
                while (flag)
                {
                    a += 1;
                    if (a % 17 == 0 || a % 13 == 0)
                    {
                        mas1[i] = a; 
                        flag = false;
                    }
                }
                flag = true;
                Console.Write($"{a} ");
            }
            Console.WriteLine();
            for (int i = 0, k = 0; i < mas2.Length; i++)
            {
                while (flag)
                {
                    b++;
                    for (int j = 1; j < b; j++)
                    {
                        if (b % j == 0)
                        {
                            k++;
                        }
                    }
                    if (k <= 1)
                    {
                        mas2[i] = b;
                        flag = false;
                        Console.Write($"{b} ");
                    }
                    k = 0;
                }
                flag = true;
            }
        }
    }
}
