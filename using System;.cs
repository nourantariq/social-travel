using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 25,99,6,3,7,1};
            int len = num.Length;
            Console.WriteLine("Before Merge sorted");
            foreach (int item in num)
            { Console.WriteLine(  item + "  "); }
            Console.WriteLine();
            Console.WriteLine("After Merge sorted");
            sortmethod(num, 0, len - 1);
            foreach (int item in num)
            { Console.WriteLine( item + "  "); }

            Console.ReadLine();

        }
        static public void sortmethod(int[] num, int right, int left)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortmethod(num, left, mid);
                sortmethod(num, (mid + 1), right);
                Merged(num, left, (mid + 1), right);
            }
        }


        private static void Merged(int[] num, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_element, temp_pos;
            left_end = (mid - 1);
            temp_pos = left;
            num_element = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (num[left] <= num[mid])
                    temp[temp_pos++] = num[left++];
                else
                    temp[temp_pos++] = num[mid++];
            }
                while (left <= left_end)
                    temp[temp_pos++] = num[left++];
                while (mid < right)
                    temp[temp_pos++] = num[mid++];
                for (i = 0; i < num_element; i++)
                {
                    num[right] = temp[right];
                    right--;
                }


            }
        }
    }

