using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace WordFreq
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            //计时开始
            sw.Start();
            const int MAX_WORD_NUM = 1000000;
            const int BUFFER_SIZE = 100000;
            
            StreamReader sr = new StreamReader(new BufferedStream(new FileStream(
                        "sdxl.txt",FileMode.Open),BUFFER_SIZE));
            string data = sr.ReadToEnd();
            //匹配目标字符串中非a—z也非A—Z的字符以此分割
            string[] words = Regex.Split(data, "[^a-zA-Z]");
            Dictionary<string, int> dict = new Dictionary<string, int>((int)(MAX_WORD_NUM * 1.5));
            foreach(var word in words)
            {
                if (word == "") continue;
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            List<Tuple<int, string>> list = new List<Tuple<int, string>>(MAX_WORD_NUM);
            foreach(var item in dict)
            {
                list.Add(Tuple.Create(item.Value, item.Key));
            }
            list.Sort();
            int count = 0;
            for(int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i].Item2 + " " + list[i].Item1);
                count++;
                if (count > 10) break;
            }
            sr.Close();
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("程序总共用时{0}s",ts.TotalSeconds);
        }
    }
}
