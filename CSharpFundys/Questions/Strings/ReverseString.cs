namespace CSharpFundys.Questions.Strings;

public class ReverseString
{
    public static string Reverse(string word)
    {
        char[] rez = word.ToCharArray(0, word.Length);
        
        Array.Reverse(rez);
        return new string(rez);
    }
}