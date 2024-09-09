namespace _0909
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Adj meg egy számot:");

            var inputNumberText = Console.ReadLine();

            var conversionSuccessful = int.TryParse(inputNumberText, out var inputNumber);
            if (!conversionSuccessful)
            {
                Console.WriteLine("Gonosz voltál, mert nem számot adtál meg! :(");
            }

            if (inputNumber % 3 == 0)
            {
                Console.WriteLine("Hárommal osztható a megadott szám!");
            }
            else if (inputNumber % 4 == 0)
            {
                Console.WriteLine("Néggyel osztható a megadott szám!");
            }
            else if (inputNumber % 9 == 0)
            {
                Console.WriteLine("Kilenccel osztható a megadott szám!");
            }
            else
            {
                Console.WriteLine("Nem osztható hárommal, néggyel, vagy kilenccel a megadott szám!");
            }
        }
    }
}
