namespace CSharpFundys.Questions.Loops_Conditions;
//write a function that prints the multiplication table from 1-10 for n number

// input is n number
// output is every answer to n * numbers 1-10

// first create a function that takes in a number
// using n number create a loop that iterates 10 times
// within the loop multiply the n number by the index(1-10)
//      - also within the loop write the results
public class MultiplicationTable
{
  public static void MultiTable(int num)
  {
    for(int i = 1; i <= 10; i++)
    {
      Console.WriteLine($"{num} * {i} = {num * i}");
    }
  }
}