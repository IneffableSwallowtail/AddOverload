using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOverload;

public static class Class1
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static decimal Add(decimal x, decimal y)
    {
        return x + y;
    }
    public static string Add(decimal x, decimal y, bool dollars)
    {
        decimal sum = x + y;
        if (dollars == true)
        {
            if (sum == 1) return $"{sum} dollar";
            else return $"{sum} dollars";
        }
        else
            return $"{sum}";
    }

    //methods for cases
    public static void Case1()
    {
        Console.Write("\nEnter your first integer: ");
        int firstInt = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your second integer: ");
        int secondInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The sum of your integers is {Class1.Add(firstInt, secondInt)}.\n");
    }
    public static void Case2()
    {
        Console.Write("\nEnter your first decimal: ");
        decimal firstDec = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter your second decimal: ");
        decimal secondDec = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"The sum of your decimals is {Class1.Add(firstDec, secondDec)}\n");
    }

    public static void Case3()
    {
        Console.Write("\nEnter your first decimal: ");
        decimal firstMon = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter your second decimal: ");
        decimal secondMon = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Are you adding money? Yes/no: ");
        string money = Console.ReadLine().ToLower();
        bool isMoney = (money == "yes") ? true : false;
        Console.WriteLine($"The sum is {Class1.Add(firstMon, secondMon, isMoney)}.");
    }
}
