using System;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        int size = 10; // Change the size of the array as needed
        int minValue = 1; // Change the minimum value as needed
        int maxValue = 100; // Change the maximum value as needed

        int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

        for (int i = 0; i < randomArray.Length; i++)
        {
            Console.Write(randomArray[i] + " ");
        }

        InsertionSortArray(randomArray);
        Console.WriteLine();

        for (int i = 0; i < randomArray.Length; i++)
        {
            Console.Write(randomArray[i] + " ");
        }
    }

    static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
    {
        if (size <= 0 || minValue > maxValue)
        {
            throw new ArgumentException("Invalid arguments");
        }

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }

    static void InsertionSortArray(int[] arr)
    {
        int arrayLength = arr.Length;
        for (int currentIndex = 1; currentIndex < arrayLength; currentIndex++)
        {
            
            int currentValue = arr[currentIndex];

           
            int previousIndex = currentIndex - 1;

           
            while (previousIndex >= 0 && arr[previousIndex] > currentValue)
            {
               
                arr[previousIndex + 1] = arr[previousIndex];

               
                previousIndex = previousIndex - 1;
            }

            
            arr[previousIndex + 1] = currentValue;
        }
    }




}



