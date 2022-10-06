/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondValue = double.Parse(Console.ReadLine());
            if (firstValue > secondValue) {
                Console.WriteLine(firstValue);
                    }
            else {
                Console.WriteLine(secondValue);
}
  }
 
}

}
