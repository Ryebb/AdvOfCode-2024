using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fgfghfghfvhgf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "balls.txt";
            List<string> num = new List<string>();
            List<int> numb1 = new List<int>();
            List<int> numb2 = new List<int>();
            int num1, num2, num3;
            using (StreamReader sr = new StreamReader("balls.txt"))
            {
                string line;
                while (sr.EndOfStream == false)
                {
                    line = sr.ReadLine();
                    num.Add(line);
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    if (Convert.ToString(num[i][j]) == " ")
                    {
                        Convert.ToString(num[i]).Remove(j);
                    }
                }
            }
            for (int i = 0;i < num.Count; i++)
            {
                numb1.Add(int.Parse(Convert.ToString(num[i]).Substring(0, 5)));
                numb2.Add(int.Parse(Convert.ToString(num[i]).Substring(5, 8)));
                numb1.Sort(); 
                numb2.Sort();
                //num3 = Math.Abs(num1 - num2);
                //Console.Write($"{num1}, {num2}, {num3}\n");
            }
            num3 = 0;
            for (int i = 0; i < numb1.Count; i++)
            {
                num2 = Math.Abs(numb1[i] - numb2[i]);
                Console.Write($"{numb1[i]}, {numb2[i]}, {num2}\n");
                num3 += num2;
            }
            num3 = 0;
            num2 = 0;
            for (int i = 0; i < numb1.Count; i++)
            {
                num1 = numb1[i];
                for (int j = 0; j < numb2.Count; j++)
                {
                    if (numb1[i] == numb2[j])
                    {
                        num3 += 1;
                    }
                }
                num2 += (num3 * numb1[i]);
                num3 = 0;
            }
            Console.Write($"{num2} mkfkmfgmkhf");
            Console.ReadKey();
        }
    }
}