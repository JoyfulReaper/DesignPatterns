using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class RandomName : IRandomWord
    {
        private static readonly RandomName _instance = new RandomName();

        private List<string> _words = new List<string> { "Sam", "Sally", "Fred", "Ethel", "Tim" };
        Random rand = new Random();

        private RandomName()
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