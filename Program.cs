/* 
File Name: Homework2Part2
Programmer: Nasi Bode
Problem Statement: Create a program that will convert degrees Fahrenheit to Celsius using : 

degreesC = 5(degreesF - 32)/9

Prompt user to enter temperature in F as an integer. Output C with the fractional input to one decimal. Use Math.Round(number, decimal) method. 

Overall Plan:
1. Print welcoming message to the screen
2. Prompt user to enter degrees in Fahrenheit
3. Create degreesF as an double value
4. Save user input as degreesF
5. Convert to Celsius
6. Save result as degreesC
7. Format answer to one decimal point
8. Output the result

*/


using System;

class Program
{
    public static void Main(string[] args)
    {

        //Print welcoming message
        Console.WriteLine("Hello! This program will convert Fahrenheit to Celsius.\n");
        //Prompt user to enter Fahrenheit value
        Console.WriteLine("Please enter the degrees of Fahrenheit as a whole number: ");
        //create integer variable
        double degreesF = 0;
        //get degreesF from user
        //convert input from user to double value
        degreesF = Convert.ToDouble(Console.ReadLine());

        //Convert to degrees Celsius
        //degreesC = 5(degreesF - 32)/9
        double degreesC = (degreesF - 32) * 5 / 9;

        //output the reuslt
        //format Celsius degree to one decimal using Math.Round method
        Console.WriteLine("\n" + degreesF + " degrees Fahrenheit = " + Math.Round(degreesC, 1) + " degrees Celsius");


        //Create extra space in program
        Console.WriteLine();

    }
}