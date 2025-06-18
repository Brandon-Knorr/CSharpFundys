namespace CSharpFundys.Questions.Loops_Conditions;

public class OddOrEven
{
    public static string EvenOrOdd(int num)
    {
        int x = num % 2;

        if (x > 0)
        {
            return "Odd";
        }

        return "Even";
    }
}