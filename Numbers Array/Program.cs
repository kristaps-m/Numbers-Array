using Numbers_Array;

const int ARRAY_SIZE = 20;
const int MAX_NUMBER = 100;
int PADDING = MAX_NUMBER.ToString().Length + 1;

Console.WriteLine("Creating 2D array...");
int[,] array = CreateTwoDimensionalArray();

var arrayTools = new NumbersArrayTools(ARRAY_SIZE, array, PADDING);

Console.WriteLine($"2D array {ARRAY_SIZE}x{ARRAY_SIZE} with random numbers from 0 to {MAX_NUMBER}");

arrayTools.PrintArray(array);

var minValue = arrayTools.FindMin();
var maxValue = arrayTools.FindMax();
var minNumCords = arrayTools.FindCordinates(minValue);
var maxNumCords = arrayTools.FindCordinates(maxValue);
var sortedArray = arrayTools.SortTwoDimensionalArray();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Min and Max value in array is {minValue} and {maxValue}");
Console.WriteLine();

arrayTools.PrintMinAndMaxNumberCoordinates(minNumCords, maxNumCords);

Console.WriteLine("Sorted 2D array");
arrayTools.PrintArray(sortedArray);
Console.WriteLine("\n\n");

int[,] CreateTwoDimensionalArray()
{
    var rnd = new Random();
    int[,] arrayCreated = new int[ARRAY_SIZE, ARRAY_SIZE];

    for (int col = 0; col < ARRAY_SIZE; col++)
    {
        for (int row = 0; row < ARRAY_SIZE; row++)
        {
            var randomNumber = rnd.Next(MAX_NUMBER + 1);
            arrayCreated[col, row] = randomNumber;
        }
    }

    return arrayCreated;
}