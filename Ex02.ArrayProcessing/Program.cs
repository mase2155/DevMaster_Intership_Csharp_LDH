using System.Globalization;
using System.Text;
using Ex02.ArrayProcessing.Helpers;

namespace Ex02.ArrayProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            CultureInfo culture = new CultureInfo("vi-VN");

            Console.WriteLine("|==================================================|");
            Console.WriteLine("    CHƯƠNG TRÌNH XỬ LÍ MẢNG (DEVMASTER)   ");
            Console.WriteLine("|==================================================|\n");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------- Xử lí mảng một chiều  -----------");

            Console.WriteLine("---- 1. Hiển thị mảng  ");
            Console.Write("Hãy nhập số phần tử của mảng : ");
            int numberOfArray = int.Parse(Console.ReadLine());
            while (numberOfArray <= 0)
            {
                Console.WriteLine("Có lỗi với số lượng phần tử bạn vừa nhập.");
                Console.Write("Hãy nhập lại: ");
                numberOfArray = int.Parse(Console.ReadLine()); 
            }
            int[] array = new int[numberOfArray];
            for(int i = 0;i< array.Length;i++)
            {
                Console.Write("Phần tử của mảng là : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Vậy mảng hiện tại là : ");
            ArrayHelper arrayToUse = new ArrayHelper();
            arrayToUse.ShowArray(array);

            //Console.WriteLine();
            //Console.WriteLine("---- 2. Tính tổng các phần tử   ");
            //Console.Write("Tổng các phần tử của mảng đó là : " + arrayToUse.SumArray(array));

            //Console.WriteLine();
            //Console.WriteLine("---- 3. Tính trung bình cộng của các phần tử   ");
            //Console.Write("Trung bình cộng của các phần tử trong mảng là : " + arrayToUse.AverageArray(array));

            //Console.WriteLine();
            //Console.WriteLine("---- 4. Tìm phần tử lớn nhất và nhỏ nhất   ");
            //Console.Write("Phần tử lớn nhất trong mảng là : " + arrayToUse.MaxInArray(array));
            //Console.WriteLine();
            //Console.Write("Phần tử bé nhất trong mảng là: " + arrayToUse.MinInArray(array));

            //Console.WriteLine();
            //Console.WriteLine("---- 5. Đếm số chẵn và lẻ    ");
            //Console.Write("Số lượng phần tử là số chẵn là : " + arrayToUse.CountEven(array));
            //Console.WriteLine();
            //Console.Write("Số lượng phần tử là số lẻ là :  " + arrayToUse.CountOdd(array));

            //Console.WriteLine();
            //Console.WriteLine("---- 6. Liệt kê các số nguyên tố   ");
            //Console.Write("Các phần tử là số nguyên tố là : ");
            //arrayToUse.PrintPrimeNumbers(array);

            Console.WriteLine();
            Console.WriteLine("---- 7. Sắp xếp tăng dần    ");
        }
    }
}
