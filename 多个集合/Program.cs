using System;
using System.Linq;

namespace 多个集合
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "hellloooooo";
            string word2 = "help";

            word1.Intersect(word2);
            word1.Union(word2);
            word1.Except(word2);
        }
    }
}