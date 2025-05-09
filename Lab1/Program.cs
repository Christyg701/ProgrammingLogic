using System.Text.Encodings.Web;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
      //Step1
   Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 1 Basic Output:");
   Console.ResetColor();
   Console.WriteLine("Christy Briggs IT1050-Programming Logic");

    //Step2
     Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 2 Use Comments:");
   Console.ResetColor();
   Console.WriteLine("Christy Briggs");
   Console.WriteLine("IT 1050-Lab 1");

    //Step3
     Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 3 Declare and Use Variables:");
   Console.ResetColor();
   int myfavnumber=77;
   Console.WriteLine("My favoirte number is "+ myfavnumber);
   string myfavlang="C#";
   Console.WriteLine("My favorite programming language " + myfavlang);
   Double numofprog= 1.55d;
   Console.WriteLine("The number of programs I have written before this " + numofprog);
   bool myexp = true;
   string result = myexp ? "Yes": "no";
   Console.WriteLine(result + " ,I have some programming experience");

//Step5
     Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Step 5 Use Constants:");
   Console.ResetColor();
   const string College= "Cuyahoga Community College";
   Console.WriteLine(College);
    }
}
