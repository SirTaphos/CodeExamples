using System;

namespace Opgave2_SorteringsAlgoritme
{
    internal class Program
    {
        private static void Main()
        {
            var myArray = new[] { 5, 3, 6, 8, 4, 2, 7, 9, 1 };
            var isDone = false;
            Console.WriteLine(
                $"{myArray[0]}, {myArray[1]}, {myArray[2]}, {myArray[3]}, {myArray[4]}, {myArray[5]}, {myArray[6]}, {myArray[7]}, {myArray[8]}");
            while (!isDone)
            {
                isDone = true;
                for (var i = 0; i < myArray.Length - 1; i++)
                {
                    if (myArray[i] <= myArray[i + 1]) continue;
                    var a = myArray[i];
                    var b = myArray[i + 1];
                    myArray[i + 1] = a;
                    myArray[i] = b;
                    isDone = false;
                }

                Console.WriteLine(
                    $"{myArray[0]}, {myArray[1]}, {myArray[2]}, {myArray[3]}, {myArray[4]}, {myArray[5]}, {myArray[6]}, {myArray[7]}, {myArray[8]}");
            }

            Console.ReadLine();
        }
    }
}
