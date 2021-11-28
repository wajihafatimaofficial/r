
using System;
class Calculator
{

    public int ans;
    

    public int add(int n1, int n2)
    {
        ans = n1 + n2;
        return ans;
    }

    public int sub(int n1, int n2)
    {
        ans = n1 - n2;
        return ans; }

    public int divide(int n1, int n2)
    {
        try
        {
            ans = n1 / n2;
            return ans;
        }
        
        catch (DivideByZeroException)
        {

            ans = 0;
            return ans;
        }
        }

    public int multiply(int n1, int n2)
    {
        ans = n1 * n2;
        return ans; }
   
  
   static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        Console.WriteLine("Enter first number : ");
       int n1 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Enter second number : ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Choose operation: ");
        Console.WriteLine(" ");
        Console.WriteLine("Addition (add) ");
        Console.WriteLine("Subtraction (sub) ");
        Console.WriteLine("Multiplication (mul) ");
        Console.WriteLine("Division (div) ");
        string op=Console.ReadLine();
        Console.WriteLine(" ");

        if (op == "add") {
            cal.add(n1, n2);
        }

      if (op == "sub")
        {
            cal.sub(n1, n2);
        }

        if (op == "div")
        {
            cal.divide(n1,n2);

          }

        if (op == "mul")
        {
            cal.multiply(n1, n2);
        }

        Console.WriteLine(n1+" " + op + " " + n2 + " = " + cal.ans);
    }
   
}

