using System;
using System.Linq;

namespace XoaPhanTuKhoiMang
{
    class Program
       
    {
        public static int[] XoaPhanTu(int x, int[] arr)
        {
            bool found = false;
            int[] newArr = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x && !found)
                {
                    found = true;
                }
                else
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            if (found)
            {
                Console.WriteLine("Phan tu {0} da duoc xoa khoi mang", x);
                return newArr;
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu {0} trong mang", x);
                return arr;
            }
        }

                public static void Main(String[] args)
        {
            Console.WriteLine("Moi nhap phan tu cua mang");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
           
            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("Nhap vao phan tu thu {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        
            
            Console.WriteLine("Phan tu can xoa la : " );
            int x = Convert.ToInt32(Console.ReadLine());

            arr = XoaPhanTu(x, arr);
            Console.WriteLine("Mang sau khi xoa:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        
}

       

    }
