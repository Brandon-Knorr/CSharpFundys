namespace CSharpFundys.Questions.Arrays;
//Write a function that doubles all the values in an array of integers

//Input is an array of ints
//Output is an array of ints

/*
 * 1. create a function that takes in an array of ints
 * 2. create an empty array with the length of the ogArray that will hold our new values
 * 3. create a loop that iterates over each element in the array.
 * 4. inside the loop multiply the current index by 2
 * 5. add that new value to an array of ints
 * 6. Return an array of ints
 */
public class DoubleAllValues
{
    public static void DblAll(int[] nums)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            int val = nums[i] * 2;
            Console.WriteLine(val);
        }
    }
}