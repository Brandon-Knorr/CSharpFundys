namespace CSharpFundys.Questions.Functions_Logic;
// write a function that converts temperature from Celsius to Fahrenheit

// input double 
// output is a double

/*
 * 1. create a function that takes in an double
 * 2. create a var to hold a double
 * 3. convert int to double
 * 4. do arithmatic on the new double
 * 5. return a double
 * 
 */
public class TempConverter
{
    public static double CelsiusToFahrenheit(double cels)
    {
        double fahrenheit = cels * (9 / 5) + 32;

        return fahrenheit;
    }
}