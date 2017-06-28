using System;


    class Program
    {
        static void Main()
        {
        Console.Write("Enter the Number :");
        int n = int.Parse(Console.ReadLine());
        int m = n;
          for (int i=0;i<=n;i++)
        {
            for(int space=1;space<=n-i;space++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
        Console.Read();
        }
    }

