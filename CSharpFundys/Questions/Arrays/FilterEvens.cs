namespace CSharpFundys.Questions.Arrays;
// Write a function that returns a new array of only the even numbers from the input array

//Input array of ints
//Output array of ints

/*
 * 1. create a function that takes in a array of integers
 * 2. create a variable to hold the current index of the array
 * 3. create an empty array of ints to hold any even numbers from the og array
 * 4. create a loop that iterates over the input array
 * 5. create a condition to check if the current number is even
 * 6. if the current num is even then add it too the new array of ints
 * 7. create a loop that iterates over the new array of even integers
 * 8. return an array of integers containing only even numbers
 */
public class FilterEvens
{
    public static int[] Evens(int[] nums)
    {
        int currentNumber;
        List<int> evensList = new List<int>();

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            currentNumber = nums[i];

            if (currentNumber % 2 == 0)
            {
                evensList.Add(currentNumber);
            }
            
        }

        int[] rez = evensList.ToArray();
        
        return rez;
        
    }
}