// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;

namespace DigitSeparators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using Digit Separators

            int binaryData = 0B0010_0111_0001_0000; // binary value of 10000   
            int hexaDecimalData = 0X2B_67; //HexaDecimal Value of 11,111   
            int decimalData = 104_567_789;
            int myCustomData = 1___________2__________3___4____5_____6;
            double realdata = 1_000.111_1e1_00;
            WriteLine($" binaryData :{binaryData} \n hexaDecimalData: {hexaDecimalData} \n decimalData: {decimalData} \n myCustomData: {myCustomData} \n realdata: {realdata}");
            #endregion
        }
        /** output:
             binaryData :10000
             hexaDecimalData: 11111
             decimalData: 104567789
             myCustomData: 123456
             realdata: 1.0001111E+103
        */
    }
}