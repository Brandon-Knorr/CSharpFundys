using System.Runtime.InteropServices.JavaScript;

namespace CSharpFundys.Questions.Strings;
//Write a function that returns true if a string reads the same backwards


//input a string
//output is a boolean of true or false

//1. create a function that takes in a string
//2. create a variable that holds the original string
//3. create a char[] of og word
//4. reverse the char[]
//5. rebuild the reversed char[] back to a new string
//6. compare the og string and reversed string 
//7. return true if == else false
public class CheckPalindrome
{
    public static Boolean IsPalindrome(string word)
    {
        string originalWord = word.ToUpper();
        char[] ogWordArray = word.ToUpper().ToCharArray(0, word.Length);
        
        Array.Reverse(ogWordArray);

        string newWord = new string(ogWordArray).ToUpper();

        if (originalWord == newWord)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}