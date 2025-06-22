using System.Collections;

namespace CSharpFundys.Questions.Arrays;
// Write a function that counts the number of times a value x appears in an array.

//Input is an array of integers and and int of x
//Output is an int 

/*
 * 1.Create a function that takes in a hashtable of ints and a single int value
 * 2. create a variable to hold the count of appearances
 * 3. create a loop to iterate over the hashtable of ints
 * 4. if hashtable contains value x count increases 
 * 5. Return an int for the num of appearances of x value in hashtable array
 */
public class CountOccOfVal
{
    public static int NumOfOcc(int[] nums, int value)
    {
        int count = 0;
        int currentNumber;

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            currentNumber = nums[i];
            if (currentNumber == value)
            {
                count++;
            }
        }
        return count;
    }
}