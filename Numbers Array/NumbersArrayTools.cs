namespace Numbers_Array
{
    public class NumbersArrayTools
    {
        private readonly int _arraySize;
        private readonly int[,] _arr;
        private readonly int _padding;

        public NumbersArrayTools(int arraySize, int[,] arr, int padding)
        {
            _arraySize = arraySize;
            _arr = arr;
            _padding = padding;
        }

        public int FindMin()
        {
            if (_arr.Length == 0)
            {
                throw new Exception("Array is empty");
            }

            int min = int.MaxValue;
            for (int col = 0; col < _arraySize; col++)
            {
                for (int row = 0; row < _arraySize; row++)
                {
                    if (_arr[col, row] < min)
                    {
                        min = _arr[col, row];
                    }
                }
            }

            return min;
        }

        public int FindMax()
        {
            if (_arr.Length == 0)
            {
                throw new Exception("Array is empty");
            }

            int max = int.MinValue;
            for (int col = 0; col < _arraySize; col++)
            {
                for (int row = 0; row < _arraySize; row++)
                {
                    if (_arr[col, row] > max)
                    {
                        max = _arr[col, row];
                    }
                }
            }

            return max;
        }

        public List<List<int>> FindCordinates(int numberToCompare)
        {
            var list = new List<List<int>>();

            for (int col = 0; col < _arraySize; col++)
            {
                for (int row = 0; row < _arraySize; row++)
                {
                    if (_arr[col, row] == numberToCompare)
                    {
                        list.Add(new List<int>() { row, col });
                    }
                }
            }

            return list;
        }

        public void PrintArray(int[,] arr)
        {
            var theCols = "COLS........" + new String(' ', _arraySize -10);

            Console.Write("   ROWS........" + new String(' ', _arraySize - 10));
            for (int col = 0; col < _arraySize; col++)
            {
                Console.WriteLine();
                Console.Write($"{theCols[col]} ");
                for (int row = 0; row < _arraySize; row++)
                {
                    Console.Write(arr[col, row].ToString().PadLeft(_padding).PadRight(_padding));
                }
            }
        }

        public int[,] SortTwoDimensionalArray()
        {
            var listOfNumbers = new List<int>();

            for (int col = 0; col < _arraySize; col++)
            {
                for (int row = 0; row < _arraySize; row++)
                {
                    listOfNumbers.Add(_arr[col, row]);
                }
            }

            listOfNumbers.Sort();

            int[,] arrayOfNumbers = new int[_arraySize, _arraySize];
            var incrementNum = 0;
            
            for (int col = 0; col < _arraySize; col++)
            {
                for (int row = 0; row < _arraySize; row++)
                {
                    arrayOfNumbers[col, row] = listOfNumbers[incrementNum];
                    incrementNum++;
                }
            }

            return arrayOfNumbers;
        }

        public void PrintMinAndMaxNumberCoordinates(List<List<int>> minNumCords, List<List<int>> maxNumCords)
        {
            Console.WriteLine();
            Console.WriteLine("Min number coordinates! ([row, col])");
            foreach (var item in minNumCords)
            {
                Console.WriteLine("[" + String.Join(", ", item) + "]");
            }

            Console.WriteLine();
            Console.WriteLine("Max number coordinates! ([row, col])");
            foreach (var item in maxNumCords)
            {
                Console.WriteLine("[" + String.Join(", ", item) + "]");
            }
            Console.WriteLine();
        }
    }
}
