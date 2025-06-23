namespace CSharpFundys.Questions.Functions_Logic;
// write a function that returns true if it is prime

// input is an integer 
// output is a boolean

/*
 * 1. create a function that takes in an integer
 * 2. create a result var for holding the int remaining after mod.
 * 3. modulus the num by 2
 * 4. create a condition that if the result == 1 return true
 * 5. else return false
 * . return a boolean value
 */
public class IsPrime
{
    public static Boolean PrimeTime(int num)
    {
        int result = num % 2;

        if (result == 1)
        {
            return true;
        }

        return false;
    }
}