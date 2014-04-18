using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {

        /// <summary>
        /// This is HangMan!
        /// A classic hangman game (that i will base words on animals)
        /// BUT IN CODE FORM!!!
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
        }
        static void HangMan()
        {
            var random = new Random(); //Random generator
            Console.WriteLine("Welcome to HangMan! The theme of this HangMan game will be Animals! Try and guess what the animal is!");
            Console.WriteLine("But 1st, whats your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the game, " + playerName + "!");
            Console.WriteLine(" ");
            var Animals = new List<string>();
            string[] temp = {"Fox", "Wolf", "Snow Leopard", "Cheetah", "Tiger", "Lion", "Panther", "Hyena", "Zebra", "Horse", "Kangaroo", "Bear", "Snake"};
            Animals = temp.ToList();

            var cpuChoice = random.Next(Animals.);//This will select the word at random.
        }
        static void DisplayMaskedWord()
        {           
            List<>
        }
    }
}
