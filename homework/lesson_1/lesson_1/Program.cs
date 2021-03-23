using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person 1
            GetUserInfo();

            // Person 2
            GetUserInfo();

            // Person 3
            GetUserInfo();
        }

        /// <summary>
        /// Prints the calculated BMI to the console.
        /// </summary>
        static void PrintBMIToConsole(string name, double bmi)
        {
            Console.WriteLine($"{name}'s BMI is {bmi:n}.\n");
        }

        /// <summary>
        /// Calculates a person's body mass index.
        /// </summary>
        static double CalculateBodyMassIndex(double weight, double height)
        {
            double heightInMetres = height / 100;
            double bmi = weight / (heightInMetres * heightInMetres);
            return bmi;
        }

        /// <summary>
        /// Prints the user's info to the console.
        /// </summary>
        static void PrintUserInfoToConsole(string name, string surname, string age, double weight, double height)
        {
            Console.WriteLine($"{name} {surname} is {age} years old, they are {height} cm tall and weigh {weight} kg.");
        }

        /// <summary>
        /// Gets the person's info from the console.
        /// </summary>
        static void GetUserInfo()
        {
            string name = ReadFromConsole("name");
            string surname = ReadFromConsole("surname");

            string age = ReadFromConsole("age");

            string weightInput = ReadMeasurementsFromConsole("weight", "kg");
            double weight = ConvertStringToDouble(weightInput);

            string heightInput = ReadMeasurementsFromConsole("height", "cm");
            double height = ConvertStringToDouble(heightInput);

            PrintUserInfoToConsole(name, surname, age, weight, height);

            double bmi = CalculateBodyMassIndex(weight, height);
            PrintBMIToConsole(name, bmi);
        }

        /// <summary>
        /// Takes user input from the console of a specified type.
        /// </summary>
        /// <returns>The user input.</returns>
        static string ReadFromConsole(string inputType)
        {
            Console.Write($"Please enter a(n) {inputType}: ");
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Takes user input from the console of the specified type and unit of measurement.
        /// </summary>
        /// <returns>The user input.</returns>
        static string ReadMeasurementsFromConsole(string inputType, string unitOfMeasurement)
        {
            Console.Write($"Please enter a(n) {inputType} in {unitOfMeasurement}: ");
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Converts a string to a double.
        /// </summary>
        /// <returns>The converted double.</returns>
        static double ConvertStringToDouble(string input)
        {
            double converted = double.Parse(input);
            return converted;
        }
    }
}