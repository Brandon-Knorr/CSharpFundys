namespace CSharpFundys.Questions.Strings;

public class PrintString
{
    public static void CopyString(string word)
    {
        char[] rez = word.ToCharArray(0, word.Length);

        foreach (char i in rez)
        { 
            Console.WriteLine(i);
        }
    }
}