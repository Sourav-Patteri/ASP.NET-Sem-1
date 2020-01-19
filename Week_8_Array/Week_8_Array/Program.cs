using System;

namespace Week_8_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];
            int[,] array3 = new int[10, 10];
            Console.WriteLine("Enter no of rows =");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of columns =");
            int column = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first array elements =");
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                   
                }

            }
            Console.WriteLine(array1[0,0]);
            Console.ReadLine();

            int[] array = new int[10];
            int size = 5;
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("array[" + i + "]" + array[i]);
            }
            Console.WriteLine("Enter index of Array ELement you would like to view");
            int array_index = int.Parse(Console.ReadLine());
            Console.WriteLine("array[" + array_index + "]" + array[array_index]);


            //sort array
            Console.WriteLine("Sorted Array ELements");

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }


        }
    }
}
