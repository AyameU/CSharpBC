using System;

namespace RecipeApp
{
    // Here is a list of standard cooking unts:
    //Cooking Unit    SI unit
    //Cup	0.24 l
    //Gallon  3.79 l
    //Fluid Ounce	29.57 ml
    //Pint    0.47 l
    //Quart   0.95 l
    //Tablespoon  14.79 ml
    //Teaspoon    4.93 ml

    class Program
    {
        static void Main(string[] args)
        {
            double totalMl = PrintTeaspoonsToMl() + PrintTablespoonsToMl();
            PrintHowManyBottles(totalMl);
        }

        static void PrintHowManyBottles(double ml)
        {
            // We have 100ml bottles.
            // How many bottles can we fill?
            int bottlesCount = (int)(ml / 100);
            Console.WriteLine($"{ml} can fill {bottlesCount} 100ml bottles.");
        }

        static double PrintTeaspoonsToMl()
        {
            // double use less resources than a decimal.
            double teaspoons = GetFromConsole("teaspoons");
            double mlOfTeaspoons = TeaspoonsToMl(teaspoons);
            Print(teaspoons, "teaspoons", mlOfTeaspoons);

            return mlOfTeaspoons;
        }

        static double PrintTablespoonsToMl()
        {
            // Tablespoons
            double tablespoons = GetFromConsole("tablespoons");
            double mlOfTablespoons = TablespoonsToMl(tablespoons);
            Print(tablespoons, "tablespoons", mlOfTablespoons);

            return mlOfTablespoons;
        }

        static double GetFromConsole(string unit)
        {
            Console.Write($"Please enter {unit} amount: ");
            string input = Console.ReadLine();
            double amount = double.Parse(input);

            return amount;
        }

        static double TeaspoonsToMl(double teaspoons)
        {
            double ml = teaspoons * 4.93;
            return ml;
        }

        static double TablespoonsToMl(double tablespoons)
        {
            double ml = tablespoons * 14.79;
            return ml;
        }

        static void Print(double cookingUnitAmount, string cookingUnit, double ml)
        {
            // String interpolation - more readable.
            string convertedDescription = $"{cookingUnitAmount} {cookingUnit} = {ml:F2} ml";
            Console.WriteLine(convertedDescription);

            // Not readable
            //Console.WriteLine(teaspoons + " teaspoons to ml is " + ml);
        }
    }
}
