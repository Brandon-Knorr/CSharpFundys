namespace CSharpFundys.Questions.Loops_Conditions;

public class CountDown
{
    public static void Timer(int num)
    {
        for (int i = num; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}