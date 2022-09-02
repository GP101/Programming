// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;
using static System.Text.Encoding;

class Program
{
    static T[] InitializeArray<T>(int length, T initialValue = default)
    {
        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Array length must be nonnegative.");
        }

        var array = new T[length];
        for (var i = 0; i < length; i++)
        {
            array[i] = initialValue;
        }
        return array;
    }

    static void Display<T>(T[] values) => Console.WriteLine($"[ {string.Join(", ", values)} ]");

    static void Main(string[] args)
    {
        Display(InitializeArray<int>(3));  // output: [ 0, 0, 0 ]
        Display(InitializeArray<bool>(4, default));  // output: [ False, False, False, False ]

        System.Numerics.Complex fillValue = default;
        Display(InitializeArray(3, fillValue));  // output: [ (0, 0), (0, 0), (0, 0) ]
    }
    /** output:
        [ 0, 0, 0 ]
        [ False, False, False, False ]
        [ (0, 0), (0, 0), (0, 0) ]
    */
}
