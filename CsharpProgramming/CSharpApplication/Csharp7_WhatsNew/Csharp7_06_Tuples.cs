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
            Program program = new Program();
            var p = program.GetPrice(1);
            WriteLine($"Price: ${p.Item1}/- \nDiscount: ${p.Item2}/-");
            (int price2, int discount) = program.GetPrice(1);
            WriteLine($"Price2: ${price2}/- \nDiscount: ${discount}/-");
            (int price3, _) = program.GetPrice(1);
            WriteLine($"Price3: ${price3}/- \n");
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
            Price2: $500/-
            Discount: $100/-
            Price3: $500/-
        */
    }
}
