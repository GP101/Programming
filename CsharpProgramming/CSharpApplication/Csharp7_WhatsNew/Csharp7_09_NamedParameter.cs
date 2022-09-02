// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;
using static System.Text.Encoding;

class Program
{
    public static int AddNumber(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static void Main(string[] args)
    {
        AddNumber(2, 3);
        AddNumber(firstNumber: 2, secondNumber: 3);
        AddNumber(2, secondNumber: 3);
        AddNumber(firstNumber: 2, 3);
        AddNumber(secondNumber: 3, firstNumber: 2);
    }
}
