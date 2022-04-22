using System;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number");
            int n, m=0, i, flag=0;
            Console.WriteLine("Enter the Number to Ckeck Prime: ");
            n=int.Parse(Console.ReadLine());
            m=n/2;
            for(i=2; i<=m; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    flag=1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
            Console.ReadLine();
        }
    }
}
