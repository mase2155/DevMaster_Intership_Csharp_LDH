using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.ArrayProcessing.Helpers
{
     class ArrayHelper
    {
        public void PrintEachElement(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Phần tử của mảng là : ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ShowArray(int[] array)
        {
            Console.Write("Vậy mảng hiện tại là : ");
            foreach ( int number in array)
            {
                Console.Write(number + "  ");
            }
        }
        public int SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0;i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public int AverageArray(int[] array)
        {
            int step = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                step += i;
            }
            return SumArray(array) / step;
        }
        public int MaxInArray(int[] array)
        {
            int max = array[0];
            for(int i = 0; i < array.Length ; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int MinInArray(int[] array)
        {
            int min = array[0];
            for ( int i = 0; i < array.Length; i++)
            {
                if ( array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        // Hàm đếm số chẵn ( Count Even Numbers )
        public int CountEven(int[] array)
        {
            int even = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 ==0)
                {
                    even++;
                }
            }
            return even; 
        }
        // Hàm đếm số lẻ ( Count Odd Numbers )
        public int CountOdd(int[] array)
        {
            int odd = 0;
            for ( int j = 0; j < array.Length; j++)
            {
                if (array[j] % 2 != 0)
                {
                    odd++;
                }
            }
            return odd;
        }
        public bool CheckPrimeNumbers(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) // 
                {
                    return false; 
                }
            }
            return true;
        }
        public void PrintPrimeNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (CheckPrimeNumbers(array[i]) == true)
                {
                    Console.Write(array[i] + "  ");
                }
            }
            Console.WriteLine();
        }
        public void AscendArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public void PrintAscendArray(int[] array)
        {
            Console.Write("Vậy mảng sau khi sắp xếp tăng dần là : ");
           foreach(int element in array)
           {
                Console.Write(element + " ");
           }
        }
        public void DescendArray(int[]array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public void PrintDescendArray(int[]array)
        {
            Console.Write("Vậy mảng sau khi sắp xếp giảm dần là : ");
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
        }
        public void SearchElement(int[]array)
        {

        }
    }
}
