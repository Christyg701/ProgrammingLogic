using System.Runtime.CompilerServices;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 1 Operator :");
   Console.ResetColor();  
    int a=10;
    int b=5;
    int c=15;
   Console.WriteLine("a>b: " + (a>b));
   Console.WriteLine("a<c: " + (a<c));
   Console.WriteLine("a>b && a > c: " + (a>b && a>c));
   Console.WriteLine("b || a>c: " + (a>b || a>c));
    
    
   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 2 Boolean:");
   Console.ResetColor();  
     bool isRaining = true;
     bool haveUmbrella = false;
        if (isRaining)
        {
        Console.WriteLine("Take an umbrella!");
        }
        else if (haveUmbrella)
        {
        Console.WriteLine("You're good to go!");
        }

   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 3 Conditiaonal Logic:");
   Console.ResetColor();  
//User input Enter  your age
Console.WriteLine("Enter your age");
int age=Convert.ToInt32(Console.ReadLine());

if (age < 5)
{
    Console.WriteLine("Ticket is free!");
 }
if (age>= 5 && age<=12)
{
Console.WriteLine("Child Ticket: $5");
}
if (age>= 13 && age<=64)
{
Console.WriteLine("Standard Ticket: $10");
}
if (age>= 65)
{
Console.WriteLine("Senior Ticket: $6");
}

   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 4 Swith Statement:");
   Console.ResetColor(); 
//User input day of the week
Console.WriteLine("Enter the day of the week (1-7)");
int day=Convert.ToInt32(Console.ReadLine());
switch (day)
{
case 1:
Console.WriteLine ("Monday");
break;
case 2:
Console.WriteLine ("Tuesday");
break;
case 3:
Console.WriteLine ("Wednesday");
break;
case 4:
Console.WriteLine ("Thursday");
break;
case 5:
Console.WriteLine ("Friday");
break;
case 6:
Console.WriteLine ("Saturday");
break;
case 7:
Console.WriteLine ("Sunday");
break;
default:
Console.WriteLine("Invalid Day!");
break;
}





    }
}






  