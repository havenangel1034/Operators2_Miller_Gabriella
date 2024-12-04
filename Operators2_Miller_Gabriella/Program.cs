namespace Operators2_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");

            //initializes an integer that multiplies two integers
            int intMult = 40 * 8;
            //initializes an integer that adds to integers
            int intAdd = 70 + 22;
            //prints the maximum and minimum of these two variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. The min of the two is {Math.Min(intMult, intAdd)}");
            //initalizes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            //prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd} {isIntGreater}.\n");

            Console.WriteLine("SHORT");
            //initializes a short that multiplies two shorts
            short shortMult = 40 * 8;
            //initializes a short that adds to a short
            short shortAdd = 70 + 22;
            //prshorts the maximum and minimum of these two variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. The min of the two is {Math.Min(shortMult, shortAdd)}");
            //initalizes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            //prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd} {isshortGreater}.\n");

            Console.WriteLine("LONG");
            //initializes a long that multiplies two longs
            long longMult = 5000 * 20;
            //initializes a long that adds to a long
            long longAdd = 1000 + 10000;
            //prints the maximum and minimum of these two variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. The min of the two is {Math.Min(longMult, longAdd)}");
            //initalizes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            //prrints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd} {islongGreater}.\n");

            Console.WriteLine("FLOAT");
            //initializes a float that multiplies two floats
            float floatMult = 40.67f * 8.23f;
            //initializes a float that adds to a float
            float floatAdd = 70.17f + 22.78f;
            //prfloats the maximum and minimum of these two variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. The min of the two is {Math.Min(floatMult, floatAdd)}");
            //initalizes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            //prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd} {isfloatGreater}.\n");

            Console.WriteLine("DOUBLE");
            //initializes a double that multiplies two doubles
            double doubleMult = 40 * 8;
            //initializes an double that adds to double
            double doubleAdd = 70 + 22;
            //prdoubles the maximum and minimum of these two variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. The min of the two is {Math.Min(doubleMult, doubleAdd)}");
            //initalizes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            //prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd} {isdoubleGreater}.\n");

            Console.WriteLine("DECIMAL");
            //initializes a decimal that multiplies two decimals
            decimal decimalMult = (decimal)(40.34 * 8.23);
            //initializes an decimal that adds to decimal
            decimal decimalAdd = (decimal)(70.86 + 22.54);
            //prints the maximum and minimum of these two variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. The min of the two is {Math.Min(decimalMult, decimalAdd)}");
            //initalizes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            //prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd} {isdecimalGreater}.");
        }
    }
}