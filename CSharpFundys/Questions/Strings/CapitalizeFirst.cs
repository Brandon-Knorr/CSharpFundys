using System.Runtime.InteropServices.JavaScript;

namespace CSharpFundys.Questions.Strings;
//Write a function that takes the first letter of a string and capitalizes it

//input is a string
//output is a string

//1. create a function that takes in a string
//2. change the 0 index to uppercase
//3. convert array to new string
//4. return the new string

public class CapitalizeFirst
{
        public static string Capitalize(string word)
        {
                string capitalWord = char.ToUpper(word[0]) + word.Substring(1);
                return capitalWord;
        }
}