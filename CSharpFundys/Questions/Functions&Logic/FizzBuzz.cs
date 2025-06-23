namespace CSharpFundys.Questions.Functions_Logic;
/* Write a function that takes in an int return 'Fizz' if divisible by 3
 return 'Buzz' if divisible by 5, 'FizzBuzz' if divisible by both
 */

//Input int
//Output string

/*
 * 1. create a function that takes in an integer
 * 2. make a condition that checks if the integer is /3
 * 3. make a condition that checks if the integer is /5
 * 4. make a condition that checks if the integer is /5&3
 * 5. return a string 'Fizz', 'Buzz', or 'FizzBuzz'
 */
public class FizzBuzz
{
    public static string FBuzz(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "FizzBuzz";
        }

        if (num % 3 == 0)
        {
            return "Fizz";
        }

        if (num % 5 == 0)
        {
            return "Buzz";
        }

        return "Not divisible by 3 or 5";
    }
}