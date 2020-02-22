using System;
using System.Collections.Generic;
using System.IO;

namespace EX_6A_C_Manipulating_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] Array_A = new int[] { 0, 2, 4, 6, 8, 10 };                    // expected result is 5. Added together equals 30 / 6 places
            int[] Array_B = new int[] { 1, 3, 5, 7, 9 };                        //expected result is 5. Added together equals 25 / 5 places
            int[] Array_C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };   //expected 4.416 result. 


            Console.Write("The average of Array_A is :");
            SumArray(Array_A);                                                  // Calls the method and Sets the input of each array in the method
            Console.Write("The average of Array_B is :");
            SumArray(Array_B);                                                  // Calls the method and Sets the input of each array in the method
            Console.Write("The average of Array_C is :");
            SumArray(Array_C);                                                  // Calls the method and Sets the input of each array in the method
            Console.WriteLine("\n");                                            // Inserts blank line between results

            Console.Write("Your reversed result of the Array_A is :"); 
            ReversingArray(Array_A);                                            // Calls the method and Sets the input of each array in the method
            Console.Write("Your reversed result of the Array_B is :");
            ReversingArray(Array_B);                                            // Calls the method and Sets the input of each array in the method
            Console.Write("Your reversed result of the Array_C is :");
            ReversingArray(Array_C);                                            // Calls the method and Sets the input of each array in the method
            Console.WriteLine("\n");                                            // Inserts blank line between results

            Console.Write("Array_A rotated Left 2 is :");
            RotatingArray("Left", 2, Array_A);                                  // Calls array rotate method with Array_A parameters above
            Console.Write("Array_B rotated Right 2 is :");
            RotatingArray("Right", 2, Array_B);                                 // Calls array rotate method with Array_B parameters above
            Console.Write("Array_C rotated Left 4 is :");
            RotatingArray("Left", 4, Array_C);                                  // Calls array rotate method with Array_C parameters above
            Console.WriteLine("\n");

            Console.Write("Array_C sorted is: ");                               
            sortedArray(Array_C);                                               // Calls the array sort method using Array_C parameters abobe
            Console.WriteLine("\n");
        }

        /*Write a method that counts the number of elements in an integer array, and then sums the elements in an integer array. 
         * It should return the average of the array elements as a double. Using the count and sum, compute and print the mean of each array. 
         * 
         * Array A: 0, 2, 4, 6, 8, 10
         * Array B: 1, 3, 5, 7, 9
         * Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9
         */

        public static void SumArray(int[] Array)
        {
            double Results=0;                                                   // Sets a place holder for the Results 
            double sum = 0;                                                     // Sets a place holder for the Sum
            for (int i = 0; i <= Array.Length-1; i++)                           // Steps through the Array one at a time 
            {
                sum += Array[i];                                                // Sums the values in the array one at a time
                int length = (Array.Length);                                    // determines how many values are in the array
                Results = (sum / length);                                       // Figures out the average and saves it to Results
            }
            Console.WriteLine(Results);                                         // Returnns the results   
        }

        /* Write a method that accepts an array as an argument and prints the reversed array.For example, 
         * if you pass the method Array B, it should print[9, 7, 5, 3, 1]. Print the reverse of all three arrays.*/

        public static void ReversingArray(int[] Array)                          // Calls the method. Set to public for testing
        {                                                                            
            string Results = "";                                                // Sets a place holder as an empty string
            for (int i=Array.Length-1 ; i>=0; --i)                              // Steps through the Array one at a time backwards 
            {                  
                Results += Array[i] + ",";                                      // Adds the values in the array one at a time to Results starting from the end and seperates by a comma                                                     
            }
            Console.WriteLine(Results); 
        }

        /*Arrays can be rotated to the right or to the left by any number of places. Rotating an array to the right by two places
         * puts the first element in position three, the second element in position four, and so on, with the last element in position 
         * two and the next to last element in position one. Array A rotated to the right by two places results in [8, 10, 0, 2, 4, 6]. 
         * Likewise, rotating an array to the left places the first elements at the end. Array B rotated to the left by two places results 
         * in [5, 7, 9, 1, 3].
         * 
         * Write a method that accepts three parameters, a direction (right or left), a number of places, and an array, which prints 
         * the appropriate rotation. Call the method on all three arrays. Rotate array A two places to the left. Rotate array B two places 
         * to the right. Rotate array C four places to the left. 
         */

        public static void RotatingArray(string direction, int numPlaces, int[] Array)
        {
            
            if (direction=="Left")
            {
                String Results = "";

                for (int i = 0; i < numPlaces; i++)
                {
                    int j, first;
                    first = Array[0];

                    for (j = 0; j < Array.Length - 1; j++)
                    {
                        Array[j] = Array[j + 1];
                    }
                    Array[j] = first;  
                }
                
                for (int i = 0; i < Array.Length; i++)
                {
                    Results+=(Array[i] + ",");
                }
                Console.WriteLine(Results);

            }

            if (direction == "Right")
            {
                String Results = "";

                for (int i = 0; i < (Array.Length-numPlaces); i++)
                {
                    int j, first;
                    first = Array[0];

                    for (j = 0; j < Array.Length - 1; j++)
                    {
                        Array[j] = Array[j + 1];
                    }
                    Array[j] = first;
                }

                for (int i = 0; i < Array.Length-1; i++)
                {
                    Results += (Array[i] + ",");
                }
                Results += Array[Array.Length-1];
                Console.WriteLine(Results);

            }


        }

        /*Sorting arrays
         * Write a method that takes an unsorted integer array and prints a sorted array. Use Array C as your test array. 
         * Do you recognize this list of numbers?
         * HINT: How do you sort a deck of cards? The simplest strategy is to go through the deck and if the “next” card is 
         * “smaller” than the current card, swap them. Then, repeat the process until all cards are in order. You should try 
         * to implement this without any outside help, but if you need just a hint, check out bubble sort.*/

        public static void sortedArray (int[] Array)                        //Method called to sort the array with Array_C above as array parameters
        { 
            string Results = "";                                            // Place holder empty string for results
            for(int i=0; i< Array.Length; i++)                              // Steps through array one at a time
            {
                for(int j=i+1; j < Array.Length; j++)                       // Internal loop to compare the first loop index with 2nd index
                {
                    if (Array[i] > Array[j])                                // If 1st loop index is greater then the 2nd enter if statement
                    {                                                       // This will swap places if i is greater than j
                        int temp = Array[i];                                // Copy array i to temp
                        Array[i] = Array[j];                                // Copy array j to array i
                        Array[j] = temp;                                    // Copy temp to Array J
                    }
                }
                
            }
            for (int k=0; k<Array.Length-1; k++)                            // Reindexing the new array in order to display results
            {
                Results += (Array[k] + ",");
            }
            Results += Array[Array.Length-1];
            Console.WriteLine(Results);                                     // Displaying results to screen
        }

    }
}
