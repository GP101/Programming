// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;
using static System.Text.Encoding;

namespace TupleExampleBy
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = UTF8;
            Program p = new Program();
            var price = p.GetPrice(1);
            WriteLine($"Price: ${price.Item1}/- \nDiscount: ${price.Item2}/-");
        }
        //returning price & discount  
        (int, int) GetPrice(int itemId)
        {
            var product = (500, 100);
            return product;
        }
        /** output:
            Price: $500/-
            Discount: $100/-
        */
    }
}