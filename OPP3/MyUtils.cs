using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3
{
    public static class MyUtils
    {
        public static int TongTu1toiN(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int Cong(this int a, int b)
        {
            return a + b;
        }
        public static void Taomang(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1000);
            }
        }
        public static void XuatMang(this int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i + "\t");
            }
            Console.WriteLine();
        }
        public static void Sapxepmangtangdan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i]) { arr[i] = arr[j]; break; }

                }
            }
        }
        public static void Sapxepmaugiamdan(this int[] arr)
        {
          return arr.Order
        }

    }
}

