using Numbers_Array;

const int ARRAY_SIZE = 20;
const int MAX_NUMBER = 100;
int PADDING = MAX_NUMBER.ToString().Length + 1;
Console.WriteLine("Creating 2D array!");
int[,] array = createTwoDimensionalArray();

var superDuper = new NumbersArrayTools(ARRAY_SIZE, array, PADDING);
Console.WriteLine($"2D array {ARRAY_SIZE}x{ARRAY_SIZE} with random numbers from 0 to {MAX_NUMBER}");
superDuper.printArray(array);
var minValue = superDuper.findMin();
var maxValue = superDuper.findMax();
var minNumCords = superDuper.findCordinates(minValue);
var maxNumCords = superDuper.findCordinates(maxValue);
var sortedArray = superDuper.sortTwoDimensionalArray();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Min and Max value in array is {minValue} and {maxValue}");
Console.WriteLine();

superDuper.printMinAndMaxNumberCordinates(minNumCords, maxNumCords);

Console.WriteLine("Sorted 2D array");
superDuper.printArray(sortedArray);

int[,] createTwoDimensionalArray()
{
    var rnd = new Random();
    int[,] array = new int[ARRAY_SIZE, ARRAY_SIZE];

    for (int col = 0; col < ARRAY_SIZE; col++)
    {
        for (int row = 0; row < ARRAY_SIZE; row++)
        {
            var randomNumber = rnd.Next(MAX_NUMBER + 1);
            array[col, row] = randomNumber;
        }
    }

    return array;
}