using System.Security.Cryptography;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
           
  //Part 1 Variable Declarations// 
  Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Variable Declarations:");
   Console.ResetColor();
    int myNum=20;
    Console.WriteLine("integer: " +myNum);
    double myDoubleNum=8.999D;
    Console.WriteLine("double: " +myDoubleNum);
    float myFraction=1.2345F;
    Console.WriteLine("float: " + myFraction);
    bool myBool=true;
    Console.WriteLine("Boolean: "+ myBool);
    string name="John Smith";
    Console. WriteLine("string: "+ name);
    char chr='C';
Console.WriteLine("char: "+ chr);

//Part 2 Type Casting// 
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Type Casting:");
   Console.ResetColor();
   double myDoubleNum1=9.78D; 
   int myInt = (int) myDoubleNum1;
   Console.WriteLine("double value: "+ myDoubleNum1);//Output Double
   Console.WriteLine("double to integer: "+ myInt);//output integer
   Console.WriteLine("integer to String: "+ Convert.ToString(myInt));//integer to string
   bool myBoola=true;
   Console.WriteLine("bool to string: " + Convert.ToString(myBoola));

//Part 3 User Input and Type Conversion// 
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("User Input and Type Conversion:");
   Console.ResetColor();

      Console.Write("Please enter your name: ");
      string userName = Console.ReadLine();
      Console.Write("Please enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Hello " + userName + ", " + age + " years old! Age is nothing but a number!");
 
     
 //Part 4 Aritmetic Operators//  
 Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Aritmetic Operators:");
   Console.ResetColor();
   int num1= 36;
   int num2= 15;
   Console.WriteLine("Add Ten: " + (num1 + num2+10));
   Console.WriteLine("Subtract Two: " + (num1 + num2-2));
   Console.WriteLine("Multiply by Three: " + (num1 + num2)*3);
   Console.WriteLine("Divide by Two: " + (num1 + num2)/2);
   Console.WriteLine("Modulus 2: " + (num1 + num2)%2);

//Part 5 Floating Point Precision//  
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Floating Point Precision:");
   Console.ResetColor();
   float myfloat=1.123456789F;
   double mydoublevar=1.123456789D;
   Console.WriteLine("My double: "+ mydoublevar);
   Console.WriteLine("Float: "+ myfloat);
   string difference ="Difference is float has only 7 digits after the decimal and double has nine digits after the decimal.";
   Console.WriteLine(difference);


//Part 6 Increment and Decrement//  
Console.ForegroundColor= ConsoleColor.DarkMagenta;   
   Console.WriteLine("Increment and Decrement:");
   Console.ResetColor();   
   int vvar= 19;
   Console.WriteLine("Incremented number is: ");
   Console.WriteLine(++vvar);
   vvar=19;
   Console.WriteLine("Decremented number is: ");
   Console.WriteLine(--vvar);



     
  
        }   
} 
