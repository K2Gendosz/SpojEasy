using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] inputChar;
            string input = Console.ReadLine();
            inputChar = input.Split(' ');
            double[] doubleDatas = new double[inputChar.Length];
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    string[] a = inputChar[i].Split('.');
                    inputChar[i] = $"{a[0]},{a[1]}";
                }
                catch
                {


                }

                doubleDatas[i] = double.Parse(inputChar[i]);
            }
            if (doubleDatas[0] != 0)
            {

                double final = (doubleDatas[2] - doubleDatas[1]) / doubleDatas[0];
                if (final-(final%10)==0)
                {
                    final.ToString();
                    Console.WriteLine(String.Format("{0:0.00}", final));

                    

                }
                else
                {
                    Console.WriteLine($"{final:##.##}");
                }
            }
            else
            {
                if (doubleDatas[2] - doubleDatas[1] == 0)
                {
                    Console.WriteLine("NWR");
                }
                else if(doubleDatas[2] - doubleDatas[1] != 0)
                {
                    Console.WriteLine("BR");
                }

            }


        }
    }
}
