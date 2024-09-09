using System.Security.Cryptography.X509Certificates;

namespace _0909
{
    internal class Program
    {
        static void Main()
        {
            ElsoFeladat();

            MasodikFeladat();

            HarmadikFeladat();

            NegyedikFeladat();
        }

        private static void ElsoFeladat() //Számok bekérése
        {
            Console.Clear();
            Console.WriteLine("1. feladat");

            Console.WriteLine("Adj meg egy számot:");

            var inputNumberText = Console.ReadLine();

            var conversionSuccessful = int.TryParse(inputNumberText, out var inputNumber);
            if (!conversionSuccessful)
            {
                Console.WriteLine("Gonosz voltál, mert nem számot adtál meg! :(");
            }

            if (inputNumber % 9 == 0)
            {
                Console.WriteLine("Kilenccel osztható a megadott szám!");
            }
            else if (inputNumber % 4 == 0)
            {
                Console.WriteLine("Néggyel osztható a megadott szám!");
            }
            else if (inputNumber % 3 == 0)
            {
                Console.WriteLine("Hárommal osztható a megadott szám!");
            }
            else
            {
                Console.WriteLine("Nem osztható hárommal, néggyel, vagy kilenccel a megadott szám!");
            }
        }

        private static void MasodikFeladat() // Átváltások
        {
            Console.Clear();
            Console.WriteLine("2. feladat");

            const string celsiusText = "Celsius";
            const string fahrenheitText = "Fahrenheit";

            Console.WriteLine($"Add meg, hogy mire akarsz átváltani! ({celsiusText}, {fahrenheitText})");

            var typeText = Console.ReadLine();

            if (typeText != celsiusText && typeText != fahrenheitText)
            {
                Console.WriteLine("Te tényleg nagyon gonosz, vagy mert nincs ilyen típus!");

                return;
            }

            var otherTypeText = typeText == celsiusText ? fahrenheitText : celsiusText;

            Console.WriteLine($"Add meg az értéket! ({otherTypeText})");

            var inputText = Console.ReadLine();

            if (!double.TryParse(inputText, out var inputNumber))
            {
                Console.WriteLine("Gonosz voltál, mert nem számot adtál meg!");
            }

            double result = typeText == celsiusText
                                    ? (inputNumber - 32) * 5 / 9
                                    : (inputNumber * 9 / 5) + 32;

            Console.WriteLine($"{result} {typeText} fok");
        }

        private static void HarmadikFeladat() //Testtömeg indexek
        {
            Console.Clear();
            Console.WriteLine("3. feladat");

            Console.WriteLine("Adja meg a súlyt! (kg)");

            var sulyText = Console.ReadLine();
            if (!double.TryParse(sulyText, out var sulyDouble))
            {
                Console.WriteLine("Nem megfelelő formátumban volt a súly!");
            }
            
            Console.WriteLine("Adja meg a magasságot! (cm)");

            var magassagText = Console.ReadLine();
            if (!double.TryParse(magassagText, out var magassagDouble))
            {
                Console.WriteLine("Nem megfelelő formátumban volt a magasság!");
            }

            var magassagInMetres = magassagDouble / 100;

            var tti = sulyDouble / Math.Pow(magassagInMetres, 2);

            var osztaly = tti switch
            {
                >= 40 => "III. fokú (súlyos) elhízás",
                > 39.99 => "II. fokú elhízás",
                > 34.99 => "I. fokú elhízás",
                > 29.99 => "túlsúlyos",
                > 24.99 => "normális testsúly",
                > 18.49 => "enyhe soványság",
                > 16.99 => "mérsékelt soványság",
                > 16 => "súlyos soványság",
                _ => "Ismeretlen érték."
            };

            Console.WriteLine(osztaly);
        }

        private static void NegyedikFeladat() //Víz-gőz-jég
        {
            Console.Clear();
            Console.WriteLine("4. feladat");

            Console.WriteLine("Adja meg a víz hőmérsékletét!");
            var tempText = Console.ReadLine();

            if (!double.TryParse(tempText, out var tempDouble))
            {
                Console.WriteLine("Nem megfelelő érték!");
            }

            var halmazallapot = tempDouble switch
            {
                <= 0 => "szilárd",
                < 100 => "folyékony",
                _ => "gáz"
            };

            Console.WriteLine(halmazallapot);
        }
    }
}
