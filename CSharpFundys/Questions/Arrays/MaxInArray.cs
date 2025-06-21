namespace CSharpFundys.Questions.Arrays;
//Write a function that returns the max value of an array of integers

//input array of ints
//output int

//1. create the function that takes in the array of ints
//2. create a variable to hold the max number
//3. create a variable to hold the current number
//4. create a variable for swapping values
//5. create a loop that iterates through the int[]
//6. save the first index as the max number
//7. compare the next index with with the initial max number
//8. if the current number is bigger than the max number then make the max number = current number
//9. return the max number in the array.
public class MaxInArray
{
    public static int MaxArrayValue(int[] nums)
    {
        int maxNumber = nums[0];
        int currentNumber;
        int tempNumber = 0;
       

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            currentNumber = nums[i];
            if (currentNumber >= maxNumber)
            {
                tempNumber = currentNumber;
            }

            maxNumber = tempNumber;
        }

        return maxNumber;
    }
}