namespace _250203
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //초기화
            int[] array = InitializeOrderArray(10);
            int[,] array2D = InitializeOrderArray(10, 10);
            //출력
            Console.WriteLine("1차원 배열");
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine("2차원 배열");
            PrintArray(array2D);
        }
            
        #region Loop
        static int MultiplyFunc(int a, int b)
        {
            return a * b;
        }

        static int[] InitializeOrderArray(int lengthOne)
        {
            int[] data = new int[lengthOne];
            for (int i = 0; i < lengthOne; i++)
            {
                data[i] = i + 1;
            }
            return data;
        }

        static int[,] InitializeOrderArray(int lengthOne, int lengthTwo)
        {
            int[,] data = new int[lengthOne, lengthTwo];
            int count = 1;

            for (int i = 0; i < lengthOne; i++)
            {
                for (int j = 0; j < lengthTwo; j++)
                {
                    data[i, j] = count;
                    count++;
                }
            }
            return data;
        }

        static void PrintArray<T>(T[] array)
        {
            if(array == null || array.Length == 0)
            {
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + "\t");
            }
        }

        static void PrintArray<T>(T[,] array)
        {
            if(array == null || array.GetLength(0) == 0)
            {
                return;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString() + "\t");
                }
                Console.WriteLine();
            }
        }

        #endregion


        #region Star
        public const int SIZE = 10;
        public static void Create5Star()
        {
            for (int i = 0; i < SIZE; i++) 
            {
                Console.Write('*');
            }
        }

        public static void Create5x5Star()
        {
            for(int i = 0;i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        /*
         
        *
        **
        ***
        ****
        *****

         */
        public static void CreateTriangeStar()
        {
            for (int j = 1; j <= SIZE; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        /*
         
            *
           **
          ***
         ****
        *****

         */
        public static void CreateReverseXTriangleStar()
        {
            for (int j = 0; j < SIZE; j++)
            {
                for (int i = (SIZE -1); i > j; i--)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= j + 1; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        /*
        *****
        ****
        ***
        **
        *
        
        */
        public static void CreateReverseYTriangleStar() 
        {
            for (int j = SIZE; j >= 1; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        /*
        *****
         ****
          ***
           **
            *
        */
        public static void CreateReverseXYTriangeStar()
        {
            //작업 중
            for (int j = 1; j <= SIZE; j++)
            {
                for (int i = 0; i < 0; i++)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= j; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
