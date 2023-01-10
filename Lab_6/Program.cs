

/*
 23.Дана матриця розміру m * n. Вивести номер її 1) першого; 2)
останнього рядка (стовпчика), що містить тільки додатні елементи.
Якщо таких рядків (стовпчиків) немає, то вивести 0.
 */

using System;

namespace ReverseFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(1234));
            Console.WriteLine(ReverseString("ABC"));
            Console.WriteLine(ReverseDecimal((decimal)123.456));
            Console.WriteLine(ReverseStringAfterDelimiter("ABC,DEF", ','));
            Console.WriteLine(ReverseArray(new int[] { 1, 2, 3, 4 }));
        }

        static int ReverseNumber(int num)
        {
            int result = 0;

            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }

        static decimal ReverseDecimal(decimal num)
        {
            string str = num.ToString();

            string reversed = ReverseString(str);

            return decimal.Parse(reversed);
        }

        static string ReverseStringAfterDelimiter(string str, char delimiter)
        {
            int delimiterIndex = str.IndexOf(delimiter);

            if (delimiterIndex == -1)
            {
                return ReverseString(str);
            }
            else
            {
                string part1 = str.Substring(0, delimiterIndex);

                string part2 = str.Substring(delimiterIndex + 1);

                return part1 + delimiter + ReverseString(part2);
            }
        }

        static int[] ReverseArray(int[] arr)
        {
            return ReverseArray(arr, 0, arr.Length - 1);
        }

        static int[] ReverseArray(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return arr;
            }
            int temp = arr[start];

            arr[start] = arr[end];

            arr[end] = temp;

            return ReverseArray(arr, start + 1, end - 1);
        }

        static int[] ReverseArray(int[] arr, ref int start, out int end)
        {
            end = arr.Length - 1;

            if (start >= end)
            {
                return arr;
            }
            int temp = arr[start];

            arr[start] = arr[end];

            arr[end] = temp;

            start++;

            end--;

            return ReverseArray(arr, ref start, out end);
        }
    }
}