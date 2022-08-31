// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;
using static System.Text.Encoding;

namespace ExpressionBodyExample
{
    class Product
    {
        public int ProductId
        {
            get;
        } = 1;
        public string ProductName
        {
            get;
        }
        public decimal Price => 3000;
        public Product() => ProductName = "Microsoft HoloLens";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            WriteLine($"Product name is {p.ProductName}");
        }
    }
    /** output:
        Product name is Microsoft HoloLens
    */
}