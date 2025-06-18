using CSharpFundys.Questions.Arrays;
using CSharpFundys.Questions.Functions_Logic;
using CSharpFundys.Questions.Loops_Conditions;
using CSharpFundys.Questions.Strings;

//Q1 write numbers from 1 to n using a for loop
Print1ToN.OneToN(15);


//Q2 write a function that adds 2 numbers
int result = SumOfTwoNumbers.AddNumbers(123,10);
Console.WriteLine(result);


//Q3 write a function to see if a number is even or odd
string evenOrOdd = OddOrEven.EvenOrOdd(2134);
Console.WriteLine(evenOrOdd);


//Q4 write a function that writes each character of a string on a new line
PrintString.CopyString("brandon");


//Q5 write a function that takes a string and reverses it
string answer = ReverseString.Reverse("uno");
Console.WriteLine(answer);


//Q6 write a function that counts down from n to 0
CountDown.Timer(7);


//Q7 write a function that counts the number of vowels in a string
CountingVowels.Vowels("Wisconsin");


//Q8 write a function that returns the total sum of all numbers from 1-n
Console.WriteLine(SumOfNNumbers.SumOfAllNumbers(10));


//Q9 write a function that returns a multiplication table of n number from 1-10
MultiplicationTable.MultiTable(10);


//Q10 write a function that counts the characters in a string 
Console.WriteLine(CountingChars.NumberOfCharacters("Kutscenreuter"));


//Q11 write a function to check for a palindrome
Console.WriteLine(CheckPalindrome.IsPalindrome("nascar"));
Console.WriteLine(CheckPalindrome.IsPalindrome("dad"));