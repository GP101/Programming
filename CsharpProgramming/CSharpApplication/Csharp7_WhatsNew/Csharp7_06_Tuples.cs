// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;
using static System.Text.Encoding;

namespace TupleExampleBy
{
    class Program
    {
        class Vector3
        {
            float _x = 0;
            float _y = 0;
            float _z = 0;
            // constructor
            public Vector3(float x, float y, float z)
            {
                _x = x; _y = y; _z = z;
            }
            // special function for tuple deconstruction
            public void Deconstruct(out float x, out float y, out float z)
            {
                x = _x; y = _y; z = _z;
            }
        }

        //returning price & discount  
        (int, int) GetPrice(int itemId)
        {
            var product = (500, 100);
            return product;
        }

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

            // Deconstructor
            Vector3 v0 = new Vector3(1.0f, 2.0f, 3.0f);
            (float x, float y, float z) = v0;
            WriteLine($"{x},{y},{z}");
        }
        /** output:
            Price: $500/-
            Discount: $100/-
            Price2: $500/-
            Discount: $100/-
            Price3: $500/-

            1,2,3
        */
    }
}
