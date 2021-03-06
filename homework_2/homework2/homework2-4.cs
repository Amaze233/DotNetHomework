using System;
//  如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵 。
//  给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。
//  ｜1 2 3 4｜
//  ｜5 1 2 3｜
//  ｜9 5 1 2｜


namespace homework2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input M of the matrix :");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input N of the matrix :");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the matrix :");
            int[,] array = inputMatrix(M, N);
            outputMatrix(array);
            Console.WriteLine(ifMatrix(array)); 
        }

        static int[,] inputMatrix(int m,int n)
        {
            int[,] array = new int[m,n]; //按照输入的M，N建立一个M×N大小的二维数组
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        static void outputMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool ifMatrix(int[,] arr)
        {           
            for(int i = 0; i+1 < arr.GetLength(0); i++)
            {
                for (int j = 0; j + 1 < arr.GetLength(1); j++)
                {
                    if(arr[i,j] != arr[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }            
            return true;
        }
    }
}
