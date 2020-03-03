using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        //     // unsigned integer means positive whole number including 0
        //    unint naturalNumber = 23;
        //     // integer means negative or positive whole number including 0
        //    int naturalNumber = -23;
        // //     float means single-precision floating point
        // // F suffix makes it a float literal
        //     float realNumber = 2.3F;
        //     // double means double-precision floating point
        //     double anotherRealNumber = 2.3;
        //     //  three variable that store the number 2 million
        //     int decimalNotation = 2_000_000;
        //     int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
        //     int hexaadecimalNotation = 0x_001E_8480;
            decimal c = 0.1M;
            decimal d = 0.2M;
            if(c + d == 0.3M){
                Console.WriteLine($"{c} + {d} equals 0.3");
            }else{
                Console.WriteLine($"{c} + {d} doest NOt equals 0.3");
            }
        }
    }
}
