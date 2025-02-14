// task 1.Create a method named GetMinMax that takes an array of integers and uses the out keyword to return both the minimum and maximum values in the array.
// task 2.Create a method called AverageNumbers that takes a variable number of doubles using the params keyword and returns their average.
// Handle the case where no arguments are passed by returning 0.
//3.Research about DateTime and TimeSpan types and solve this.
//Write a method called CalculateAgeInDays that takes a DateTime parameter representing a person's birthdate and returns their age.
//Use the current date (DateTime.Now) to calculate the difference.
// task 4. Write a method called FindEBOB that takes two integers as parameters and returns their greatest common divisor(EBOB).
// task 4.1: for bonus Use the Euclidean Algorithm to solve this problem.

namespace HomeWork4;
internal class Program
{
    static void Main(string[] args)
    {
        // task 1.
        //int[] numbers = { -3, 0, 10, 2, 8, 45 };
        //GetMinMax(numbers, out int min, out int max);
        //Console.WriteLine($"Min: {min}, Max: {max}");

        // task 2.
        //Console.WriteLine(AverageNumbers(3.0, 5.6, 3.4));

        // task 3.
        //DateTime birth = new DateTime(2007, 10, 11);
        //Console.WriteLine(CalculateAgeInDay(birth));

        // task 4.
        //Program tasks = new Program();
        //Console.WriteLine(tasks.Ebob(2,4));

        // task 4.1
        //Console.WriteLine(tasks.Evklid(6, 5));

    }
    // task 1.

    //public static void GetMinMax(int[] numbers, out int min, out int max)
    //{
    //    min = numbers[0];
    //    max = numbers[0];

    //    for (int i = 1; i < numbers.Length; i++)
    //    {
    //        if (numbers[i] < min)
    //            min = numbers[i];
    //        if (numbers[i] > max)
    //            max = numbers[i];
    //    }
    //}

    // task 2.
    //public static double AverageNumbers(params double[] numbers)
    //{
    //    double sum = 0;
    //    if (numbers.Length == 0)
    //    {
    //        return 0;
    //    }
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        sum += numbers[i];
    //    }
    //    double average = sum / numbers.Length;
    //    return average;
    //}

    // task 3.
    //public static int CalculateAgeInDay(DateTime birth)
    //{
    //    DateTime dt1 = DateTime.Now;
    //    DateTime dt2 = birth;
    //    TimeSpan ts = dt1 - dt2;
    //    return ts.Days / 365;
    //}

    // task 4.
    //public int Ebob(int a, int b)
    //{
    //    int min = a < b ? a : b;

    //    for (int i = min; ; i--)
    //    {
    //        if(a % i == 0 && b % i == 0)
    //        {
    //            return i;
    //        }
    //    }
    //}

    // task 4.1
    //public int Evklid(int a, int b)
    //{
    //    while (b != 0)
    //    {
    //        int tmp = b;
    //        b = a % b;
    //        a = tmp;
    //    }
    //    return a;
    //}
}




