using System;

namespace StringHelpers
{
    class Program
    {   
        static void Main(string[] args)
        {
            string testString = "Testing";
            string reversedTestString = ReverseString(testString);
            string palindromeSentence = "a nut for a jar of tuna";

            Console.WriteLine(testString);
            Console.WriteLine(reversedTestString);

            Console.WriteLine("\n" + testString + " = Palindrome? : " + checkPalindrome(testString));
            Console.WriteLine(palindromeSentence + " = Palindrome? : " + checkPalindrome(palindromeSentence));
            // To keep checkPalindrome simple, I've chosen to write another helper that removes whitespace from a string. 
            // Running the same palindromic sentence without whitespace will return true.
            palindromeSentence = RemoveWhitespace(palindromeSentence);
            Console.WriteLine(palindromeSentence + " = Palindrome? : " + checkPalindrome(palindromeSentence));
        }

        internal static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            string reversedString = new string(charArray);

            return reversedString;
        }

        internal static bool checkPalindrome (string str)
        {
            bool flag = false;

            for(int i = 0, j = str.Length - 1; i < str.Length/2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            return flag;
        }

        internal static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }
    }
}