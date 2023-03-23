using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdeaada";
            FindMostApperCharacter(str);
            //FindMostApperCharacterV2(str);
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void FindMostApperCharacterV2(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;
            List<char> c = new List<char>();
            List<int> count = new List<int>();
            c = str.Distinct().ToList();
            string result = "";
            int max = 0;
            foreach(char s in c)
            {
                var tmp = 0;
                foreach(char i in str)
                {
                    if (i == s)
                        tmp++;
                }

                if (max < tmp)
                {
                    max = tmp;
                    result = "";
                    result +=  s;
                }
                else if(max == tmp)
                    result += " " + s;
                
            }

            Console.Write(result);
        }

        public static void FindMostApperCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;
            List<char> c = new List<char>();
            List<int> count = new List<int>();
            foreach (char s in str)
            {
                int tmp = 0;
                for (var i = 0; i < c.Count; i++)
                {
                    if (s == c[i])
                    {
                        tmp = 1;
                        break;
                    }
                    else
                        tmp = 0;
                }

                if (tmp == 0)
                    c.Add(s);
            }

            foreach (char i in c)
            {
                int tmp = 0;
                foreach (char s in str)
                {
                    if (s == i)
                        tmp++;
                }
                count.Add(tmp);
            }

            int temp = count[0];
            foreach (var i in count)
            {
                if (temp < i)
                    temp = i;
            }

            Console.WriteLine("Input: " + str);
            Console.Write("Output: ");
            for (int i = 0; i < count.Count; i++)
            {
                if (count[i] == temp)
                    Console.Write(c[i] + " ");
            }
        }
    }
}
