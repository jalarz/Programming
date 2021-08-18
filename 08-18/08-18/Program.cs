using System;

namespace _08_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Salam";
            Console.WriteLine(reverse(word));
        }
        static string reverse(string word)
        {

            string reversed = "";
            int length;

            length = word.Length - 1;

            while (length >= 0)
            {
                reversed = reversed + word[length];
                length--;
            }
            return reversed;
        }
        
     
  
}  
    }

