using System;

namespace CG_6_3_Alice_in_Wonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you know the first sentence of Alice in Wonderland?");

            //Ask user for a search word
            Console.WriteLine("Type a word, and I'll tell you whether or not it is in the first sentence.");

            //Store the search word in a string variable called userWord
            string userWord = Console.ReadLine();

            //Store the sentence in a string variable called alice
            string alice = ("Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice " +
                "‘without pictures or conversation?’");

            //Convert both the sentence and the search word to all caps.  
            //This will make the search case insensitive
            alice = alice.ToUpper();
            userWord = userWord.ToUpper();

            //Search for the user's word in the sentence and assign it to a boolean variable
            bool searchResult = alice.Contains(userWord);

            //if the boolean variable is true, write the following message.
            //otherwise write the other message.
            if (searchResult)
                Console.WriteLine("Yes! " + userWord + " is in the sentence!  Way to go!");
            else
                Console.WriteLine("Sorry " + userWord + " is not there.");

            Console.ReadLine();


        }
    }
}
