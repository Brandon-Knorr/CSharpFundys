namespace CSharpFundys.Questions.Arrays;
// Write a function that returns the sum of all elements in an array.

// Input is an array of ints
// Output is an int

/*
  1. create a function that takes in an array of ints
  2. create a variable to hold the total
  3. create a variable to hold the current number
  4. create a variable to track the running total
  5. create a loop to iterate through the array of ints
  6. inside the loop set the current number to the current index
  7. add the current number to the running total
  8. after the loop ends set the total to the running total
  9. return the sum of elements 
 */
public class SumOfElems
{
    public static int SumOfErrrThang(int[] nums)
    {
        int total;
        int currentNumber;
        int runningTotal = 0;

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            currentNumber = nums[i];
            runningTotal += currentNumber;
        }

        total = runningTotal;

        return total;
    } 
}