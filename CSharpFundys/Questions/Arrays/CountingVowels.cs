namespace CSharpFundys.Questions.Arrays;

//count how many vowels are in a given string. (a, e, i , o, u)
//takes in a string 
//returns x number of vowels

//1. create a variable to track the number of vowels
//2. loop over the characters in the string
//3. at each each index of the string check if it is a vowel
//4. if vowel x+1 else x+0
//5. return the number of vowels.

public class CountingVowels
{
    public static void Vowels(string word)
    {
        int numberOfVowels = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in word)
        {
            if (vowels.Contains(c))
            {
                numberOfVowels++;
            } 
        }
       Console.WriteLine(numberOfVowels);
    }
}