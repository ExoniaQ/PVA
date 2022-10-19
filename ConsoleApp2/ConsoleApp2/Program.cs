using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            
            {            
                /* sort */
                if (b > c)
                {
                    int temp = b;
                    b = c;
                    c = temp;
                }
                if (a > b)
                {
                    int temp = b;
                    b = a;
                    a = temp;
                }
                if (b > c)
                {
                    int temp = b;
                    b = c;
                    c = temp;
                }
                bool pravost = false;
                if (c*c == b*b + a*a)
                {
                    pravost = true;
                }
                

                if (pravost == true)
                {
                    Console.WriteLine("trojuhelnik je pravouhly");
                }
                else
                {
                    Console.WriteLine("trojuhelnik neni pravouhly");
                }

            }
            
        }
    }
}
