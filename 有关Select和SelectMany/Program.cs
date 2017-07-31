using System;
using System.Linq;

namespace 有关Select和SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select看作是对每一个元素的映射
            //var numbers = Enumerable.Range(1, 4);
            //var squares = numbers.Select(x => x * x);
            //foreach(var item in squares)
            //    Console.WriteLine(item);


            //Select映射成一个数值
            //string sentence = "This is a lovely day";
            //var wordLengths = sentence.Split().Select(w => w.Length);
            //foreach(var item in wordLengths)
            //    Console.WriteLine(item);


            //Select映射成一个匿名对象
            //string sentence = "such a beautiful day";
            //var objs = sentence.Split()
            //    .Select(w => new { Word= w, Size= w.Length });
            //foreach(var item in objs)
            //    Console.WriteLine(item.Word + ", " + item.Size);


            //Select映射获得随机集合元素
            //Random r = new Random();
            //var randNumbers = Enumerable.Range(1, 10).Select(n => r.Next(10));
            //foreach(var item in randNumbers)
            //    Console.WriteLine(item);

            //var sequences = new[] { "red, green, blue", "orange","white,pink"};
            //var allWords = sequences.Select(s => s.Split(','));
            //foreach(var item in allWords)
            //    Console.WriteLine(item.Count()); //得到3个数组

            //如何获取到3个数组中的所有元素呢
            //SelectMany，将结果序列合并成一个序列
            //var sequences = new[] { "red, green, blue", "orange", "white,pink" };
            //var allWords = sequences.SelectMany(s => s.Split(','));
            //foreach (var item in allWords)
            //    Console.WriteLine(item); 


            //SelectMany合并两个集合
            string[] objects = { "house", "car", "bycycle" };
            string[] colors = { "red", "green", "gray"};
            var pairs = colors.SelectMany(
                    _ => objects,
                    (c, o) => $"{c}-{o}"
                );
            foreach(var item in pairs)
                Console.WriteLine(item);

        }
    }
}