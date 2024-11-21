namespace Week3ChallengeLab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is a palindrome:");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"\nThe word {input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\nThe word {input} is not a palindrome.");
            }
        }

        static bool IsPalindrome(string str)
        {
            // Get the length of the string
            int length = str.Length;

            // Compare characters from the start and end
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
   
