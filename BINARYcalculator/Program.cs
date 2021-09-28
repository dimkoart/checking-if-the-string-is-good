using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BINARYcalculator
{
    class Program
    {
        static void Main(string[] args)
        {      
            while (true)
            {  
                string b = Console.ReadLine();
                int countZero = 0;
                int countOnes = 0;
                string pattern = "([0-1]{" + b.Length + "})";
                if (Regex.IsMatch(b, pattern)){
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == '1')
                            countOnes++;
                        else if (b[i] == '0')
                            countZero++;
                        else
                            break;
                    }
                    if (countOnes == countZero)
                    {
                        b = b.Remove(b.Length - 1);
                        while (b.Length >= 1)
                        {
                            countZero = 0;
                            countOnes = 0;
                            for (int i = 0; i < b.Length; i++)
                            {
                                if (b[i] == '1')
                                {
                                    countOnes++;
                                }
                                else if (b[i] == '0')
                                {
                                    countZero++;
                                }
                            }
                            if (countOnes >= countZero & b.Length > 1)
                            {
                                b = b.Remove(b.Length - 1);                       
                                continue;
                            }
                            else if (b.Length == 1)
                            {
                                Console.WriteLine("строка нормальная");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("строка говнище собачье");
                                break;
                            }
                        }
                    }
                    else  
                        Console.WriteLine("нулей больше чем единиц либо ты ввел только единицы");
                }
                else
                    Console.WriteLine("ввод только единиц и нулей");               
            }
        }
    }
}
