using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            char vow, word;
            bool exitLoop = false;
            bool cont = true; //left if needs to be rerun

            while (cont = true)
            {
                Console.WriteLine("Please enter a word that you would like translated into pig latin");
                string question = Console.ReadLine();
                int tempStore = 0; //using this to store var 
                for (int v = 0; v < question.Length; v++)
                {
                    word = question[v];
                    for (int i = 0; i < vowels.Length; i++)
                    {
                        vow = vowels[i];
                        if (vow.Equals(word) == true)
                        {
                            exitLoop = true;
                            break;
                        }
                    }
                    if (exitLoop == true)
                        break;
                    tempStore = tempStore + 1;
                }
                if (tempStore == 0) //incase the words begins with a vowel
                {
                    Console.WriteLine(question + "way");
                    Console.ReadKey();
                }
                int g = question.Length - tempStore;
                string firstLetters = question.Substring(0, tempStore); //using SubStrings to move the letters around.
                Console.WriteLine(question.Substring(tempStore, g)
                    + firstLetters + "ay");
                Console.ReadLine();
                Console.WriteLine("Would you like to translate another word? Y/N"); //hopefully this continues and doesn't break haha
                string ans = Console.ReadLine().ToLower();
                if (ans == "n")
                {
                    cont = false;
                    break;
                }
                if (ans == "y")
                {
                    cont = true;
                }

            }
        }
    }
}