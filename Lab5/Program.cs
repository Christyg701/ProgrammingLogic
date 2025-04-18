using System.Diagnostics;
using System.Globalization;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 1: Seasons of the Year:");
Console.ResetColor();
String []seasons= new string[4] {"Spring","Summer","Fall", "Winter"};
for (int i=0; i <= 3; i++)
{
Console.WriteLine("Season: "+(seasons[i]));
}



Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 2: Days of the Week:");
Console.ResetColor();

String[]daysofweek={"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
Console.Write("Enter day of the week (1-7)");
int day=Convert.ToInt32(Console.ReadLine());
if (day>=1&&day<=7)
{
Console.WriteLine("That day is: "+ daysofweek[day-1]);
}
else
{
 Console.WriteLine("Invalid Input, please enter a number from 1-7");
}
{
    
    
    {

Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 3: Favorite Books and Authors:");
Console.ResetColor();

string[] books={"Grapes of Wrath","Where the Crawdads Sing","The Motivation Code" };
string[] authors={"John Steinbeck","Delia Owens","Todd Henry"};
for (int b=0; b<3;b++)
{ Console.WriteLine((books[b])+" by "+(authors[b]));
}}}
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 4: Temperature Tracker:");
Console.ResetColor();  

int[] temperatures= new int[5] {65,72,78,70,68};
Array.Sort(temperatures);
Console.WriteLine("Sorted Temperatures: ");
foreach (int temp in temperatures)
{
Console.WriteLine(temp+" ");
}
{
Console.WriteLine("Highest Temperature: " + (temperatures.Max()));
}
{
Console.WriteLine("Lowest Temperature: " + (temperatures.Min()));
}
{Console.ForegroundColor= ConsoleColor.DarkMagenta;   
Console.WriteLine("Problem 5: Reverse Countdown:");
Console.ResetColor();  
int[] countdown={5,4,3,2,1};
Array.Reverse(countdown);
Console.WriteLine("Countdown: ");
foreach(int num in countdown)
{
Console.WriteLine(num+" ");
}

}
}
}
  