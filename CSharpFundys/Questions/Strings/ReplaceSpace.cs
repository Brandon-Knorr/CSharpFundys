namespace CSharpFundys.Questions.Strings;
// write a function that replaces the spaces in a string with -

//input string
//output string

//1. create a function that takes in a string
//2. replace any " " with "-"
public class ReplaceSpace
{
    public static void LaDashA(string word)
    {
        string newWord = word.Replace(" ", "-");
        Console.WriteLine(newWord);
    }
}