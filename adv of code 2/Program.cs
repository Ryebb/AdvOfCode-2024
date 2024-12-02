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
        static bool error;
        static int errorindex;
        static void Main(string[] args)
        {
            List<string> num = new List<string>();
            List<int> numb1 = new List<int>();
            List<int> numb2 = new List<int>();
            int num1, num2, num3;
            int dir = 0;
            int yes = 1;
            int found = 0;
            int damper = 0;
            using (StreamReader sr = new StreamReader("balls.txt"))
            {
                int i = -1;
                string line;
                while (sr.EndOfStream == false)
                {
                    i += 1;
                    numb2.Clear();
                    numb1.Clear();
                    damper = 0;
                    error = false;
                    line = sr.ReadLine();
                    num.Add(line);
                    line = num[i];
                    char[] whitespace = new char[] { ' ', '\t' };
                    string[] ssizes = line.Split(whitespace);
                    for (int j = 0; j < ssizes.Length; j++)
                    {
                        Console.WriteLine(ssizes[j]);
                        numb2.Add(int.Parse(ssizes[j]));
                        numb1.Add(int.Parse(ssizes[j]));
                    }
                    for (int k = 0; k < (numb1.Count); k++)
                    {
                        numb2.RemoveAt(k);
                        for (int j = 0; j < (numb2.Count) - 1; j++)
                        {
                            if ((numb2[j] + 1 == numb2[j + 1] || (numb2[j] + 2 == numb2[j + 1] || numb2[j] + 3 == numb2[j + 1])) && (dir == 0 || dir == 1))
                            {
                                dir = 1;
                            }
                            else if ((numb2[j] - 1 == numb2[j + 1] || (numb2[j] - 2 == numb2[j + 1] || numb2[j] - 3 == numb2[j + 1])) && (dir == 0 || dir == -1))
                            {
                                dir = -1;
                            }
                            else
                            {
                                dir = 0;
                                yes = 0;
                                break;
                            }
                            Console.Write($"found {numb2[j]}, {numb2[j + 1]}\n");
                        }
                        if (yes == 1)
                        {
                            found += 1;
                            Console.Write($"yes");
                            break;
                        }
                        yes = 1;
                        dir = 0;
                        numb2.Clear();
                        for (int l = 0; l < numb1.Count; l++)
                        {
                            numb2.Add(numb1[l]);
                        }
                        Console.WriteLine();
                    }
                }
                Console.Write($"found {found}");
            }
            Console.ReadKey();
        }
    }
}