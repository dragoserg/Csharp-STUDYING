using System;


namespace Test
{
    class Test
    {
        static string generatePhoneNumber(int[] numbers)
        {
            string number = $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}" +
                $"-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";

            return number;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(generatePhoneNumber(arr));
        }


    }
}