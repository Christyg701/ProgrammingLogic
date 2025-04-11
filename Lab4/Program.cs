using System.Data;
using System.Globalization;
using System.Transactions;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
     
   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Problem 1: Simple for Loop:");
   Console.ResetColor(); 
   int Number =1;
   while (Number<=10)
   {
    Console.WriteLine(Number++);
   }

   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Problem 2: Even Numbers from 1 to 20:");
   Console.ResetColor(); 
   int i=1;
   while (i<=20)
   {
    if ((i % 2)==0)
    {
        Console.WriteLine(i);
   }
   i++;
}
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 3: While Loop Countdown:");
Console.ResetColor(); 
int x=5;
while (x>0)
{
Console.WriteLine(x);
x--;
}
{
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 4: Do/While User Input:");
Console.ResetColor(); 
int Nmbr;
do
{
Console.WriteLine("Enter a number greater than 100: ");
Nmbr=Convert.ToInt32(Console.ReadLine());

}
while (Nmbr<=100);
}
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 5: While Loop-Multiples of 10 from 10 to 1000:");
Console.ResetColor(); 
int Mlp=10;
while (Mlp<=1000)
{
Console.WriteLine(Mlp);
Mlp+=10;

}
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 6: Pattern Printer (Using Nested Loops:");
Console.ResetColor(); 
{
int n = 10; // Number of rows
     for (int c = 1; c <= n; c++)
        {
            for (int j = 1; j <= c; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
}
}
    }

 }   

