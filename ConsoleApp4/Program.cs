using System;

namespace lab1_3
{
    public static class Logic
    {
        public static int GetSum(string rowSum)
        {

            string[] rowSumMembers = rowSum.Split('+', '-');

            char[] separators = new char[] { ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] memberSign = rowSum.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int sum = int.Parse(rowSumMembers[0]);

            for (int i = 1; i < rowSumMembers.Length; i++)
            {
                if (memberSign[i - 1].Equals("-"))
                {
                    sum -= int.Parse(rowSumMembers[i]);
                    continue;
                }

                sum += int.Parse(rowSumMembers[i]);
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");

            string rowSum = Console.ReadLine();

            int sum = Logic.GetSum(rowSum);
            Console.WriteLine("Сумма в тексте = " + sum);
            Console.ReadLine();
        }
    }
}
