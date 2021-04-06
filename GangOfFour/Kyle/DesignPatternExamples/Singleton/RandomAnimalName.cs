using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class RandomAnimalName : IRandomWord
    {
        private static readonly RandomAnimalName _instance = new RandomAnimalName();

        private List<string> _words = new List<string> { "Cat", "Dog", "Deer", "Panda", "Bat" };
        Random rand = new Random();

        private RandomAnimalName()
        {

        }

        public static IRandomWord GetInstance()
        {
            return _instance;
        }

        public string getRandomWord()
        {
            return _words[rand.Next(_words.Count())];
        }
    }
}
