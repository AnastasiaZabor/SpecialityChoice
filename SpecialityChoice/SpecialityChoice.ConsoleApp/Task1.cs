using System;
using System.Linq;

namespace SpecialityChoice.ConsoleApp
{
    public class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("Enter size array");
            int.TryParse(Console.ReadLine(), out int size);
            string[] array = FillArray(size);
            Console.WriteLine(PrintArray(array));
            Console.WriteLine(PrintArray(PickStringsWithLengthLessThanThree(array)));


        }

        private static string[] FillArray(int size)
        {
            string[] array = new string[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = GenerateRandomString();
            }

            return array;
        }

        private static string GenerateRandomString()
        {
            string result = string.Empty;

            int stringLength = new Random().Next(1, 10);

            for (int i = 0; i < stringLength; i++)
            {
                result = string.Concat(result, (char)new Random().Next(97, 123));
            }
            
            return result;
        }

        private static string[] PickStringsWithLengthLessThanThree(string[] array)
        {
            return array.Where(str => str.Length <= 3).ToArray();
        }

        private static string PrintArray(string[] array)
        {
            return string.Join(", ", array);
        }
    }
}