using System;

namespace Assignment05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable C# example.
            // Value type by value: Copy the value change to the parameter does not affect the original variable.
            // Value type by reference: Refer to the original value change to the parameter affect the original variable.
            void ExampleValueType()
            {
                int number = 10;
                ModifyByValue(number);
                Console.WriteLine("After ModifyByValue: " + number);
                ModifyByReference(ref number);
                Console.WriteLine("After ModifyByReference: " + number);
            }

            void ModifyByValue(int x)
            {
                x += 10;
            }

            void ModifyByReference(ref int x)
            {
                x += 10;
            }

            ExampleValueType();
            #endregion

            #region Q2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable C# example.
            // Reference type by value: Copy the reference change to the object are visible but reassigning the reference does not affect the original.
            // Reference type by reference: Change to the reference and the object affect the original.
            void ExampleReferenceType()
            {
                string[] array = { "A", "B" };
                ModifyArrayByValue(array);
                Console.WriteLine(string.Join(", ", array)); 
                ModifyArrayByReference(ref array);
                Console.WriteLine(string.Join(", ", array)); 
            }

            void ModifyArrayByValue(string[] arr)
            {
                arr[0] = "Z";
                arr = new string[] { "X", "Y" };
            }

            void ModifyArrayByReference(ref string[] arr)
            {
                arr = new string[] { "C", "D" };
            }

            ExampleReferenceType();
            #endregion

            #region Q3. Write a C# Function that accepts 4 parameters from the user and returns the result of summation and subtraction of two numbers.
            (int sum, int diff) SumAndSubtract(int a, int b, int c, int d)
            {
                return (a + b, c - d);
            }

            Console.Write("Enter four integers (a b c d): ");
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]), c = int.Parse(inputs[2]), d = int.Parse(inputs[3]);
            var result = SumAndSubtract(a, b, c, d);
            Console.WriteLine($"Sum: {result.sum}, Difference: {result.diff}");
            #endregion

            #region Q4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            int SumOfDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of {num} is: {SumOfDigits(num)}");
            #endregion

            #region Q5. Create a function named "IsPrime" to check if a number is prime.
            bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            Console.Write("Enter a number to check if it is prime: ");
            int primeCheck = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(primeCheck) ? "The number is prime." : "The number is not prime.");
            #endregion

            #region Q6. Create a function named MinMaxArray to return the minimum and maximum values in an array using reference parameters.
            void MinMaxArray(int[] arr, out int min, out int max)
            {
                min = int.MaxValue;
                max = int.MinValue;
                foreach (int num in arr)
                {
                    if (num < min) min = num;
                    if (num > max) max = num;
                }
            }

            Console.Write("Enter array elements separated by space: ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            MinMaxArray(array, out int min, out int max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            #endregion

            #region Q7. Create an iterative (non-recursive) function to calculate the factorial of a number.
            int Factorial(int number)
            {
                int result = 1;
                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }

            Console.Write("Enter a number to calculate its factorial: ");
            int factNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {factNum} is: {Factorial(factNum)}");
            #endregion

            #region Q8. Create a function named "ChangeChar" to modify a letter in a string at a given position.
            string ChangeChar(string str, int index, char newChar)
            {
                if (index < 0 || index >= str.Length)
                    throw new ArgumentOutOfRangeException("Index is out of range.");

                char[] chars = str.ToCharArray();
                chars[index] = newChar;
                return new string(chars);
            }

            Console.Write("Enter a string: ");
            string originalStr = Console.ReadLine();
            Console.Write("Enter the position to change: ");
            int pos = int.Parse(Console.ReadLine());
            Console.Write("Enter the new character: ");
            char newChar = char.Parse(Console.ReadLine());
            Console.WriteLine($"Modified string: {ChangeChar(originalStr, pos, newChar)}");
            #endregion
        }
    }
}
