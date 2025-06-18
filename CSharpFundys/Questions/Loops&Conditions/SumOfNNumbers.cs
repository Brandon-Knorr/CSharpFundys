namespace CSharpFundys.Questions.Loops_Conditions;
// write a function that adds all the numbers from 1 to n number

//input is a number
//output is sum of all numbers from 1 to n number

//take in a number
// create a variable to keep track of current total
//using a loop iterate over each index of the range from 1 to n
// after each iteration add the current index to the previous index

public class SumOfNNumbers
{
    public static int SumOfAllNumbers(int num)
    {
        int totalRangeSum = 0;

        for (int i = 0; i <= num; i++)
        {
            totalRangeSum += i;
        }

        return totalRangeSum;
    }
}