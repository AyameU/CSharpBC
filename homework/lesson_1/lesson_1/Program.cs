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

        static void PrintBMI(string name, double bmi)
        {
            Console.WriteLine($"{name}'s BMI is {bmi:n}.\n");
        }

        static double CalculateBMI(double weight, double height)
        {
            double metres = height / 100;
            double bmi = weight / (metres * metres);
            return bmi;
        }

        static void PrintUserInfo(string name, string surname, string age, double weight, double height)
        {
            Console.WriteLine($"{name} {surname} is {age} years old, they are {height} cm tall and weigh {weight} kg.");
        }

        static void GetUserInfo()
        {
            string name = ReadFromConsole("name");
            string surname = ReadFromConsole("surname");
            string age = ReadFromConsole("age");
            string weightInput = ReadFromConsole("weight in kg");
            double weight = ConvertToDouble(weightInput);
            string heightInput = ReadFromConsole("height in cm");
            double height = ConvertToDouble(heightInput);
            PrintUserInfo(name, surname, age, weight, height);
            PrintBMI(name, CalculateBMI(weight, height));
        }

        static string ReadFromConsole(string inputType)
        {
            Console.Write($"Please enter a(n) {inputType}: ");
            return Console.ReadLine();
        }

        static double ConvertToDouble(string input)
        {
            double converted = double.Parse(input);
            return converted;
        }
    }
}