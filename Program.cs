using System;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            // static void duplicate ();
            {
                int[] numbers = { 1, 2, 2, 3, 4, 4 };
                List<int> numbersList = new List<int>(numbers); //Converting to list
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbersList[i] == numbersList[i - 1]) ; //Equality with preceeding number
                    numbersList.RemoveAt(i);
                    Console.WriteLine(numbersList[i - 1] + "");
                }
            }
            // static void largest ();
            {
                int[] numbers_1 = { 1, 5, 3, 4, 2 };
                List<int> numbersList_1 = new List<int>(numbers_1);
                int a = numbersList_1.Max();                        //Obtaining first maximum value
                for (int i = 0; i < numbersList_1.Count; i++)
                {
                    numbersList_1.Remove(a);                        //Removing first maximum value
                    numbersList_1.Max();
                }
                Console.WriteLine("" + a);
                Console.WriteLine("" + numbersList_1.Max());
            }
            // static void lastzeros ();
            {
                int[] numbers_2 = { 1, 5, 3, 4, 2 };
                List<int> numbersList_2 = new List<int>(numbers_2);
                int a = numbers_2.Length;                           //Total length of array
                int b = a - 1;                                        // Number of indexes
                for (int i = 0; i < a; i++)
                {
                    int c = numbers_2[b] = 0;
                    Console.WriteLine("" + numbers_2[i]);
                }
            }
            // static void MergeArrays ();
            {
                int[] firstarray = { 1, 3, 5 };
                int[] secondarray = { 2, 4, 6 };

                for (int z = 0; z < firstarray.Length; z++)
                {
                    for (int j = 0; j < secondarray.Length; j++)
                    {
                        if (firstarray[z] < secondarray[j]) ;   
                        int[] finalarray = { firstarray[z], secondarray[j] };   //Stacking array elements
                        for (int i = 0; i < firstarray.Length; i++)
                        {
                            Console.WriteLine("" + finalarray[i]);
                        }
                    }

                }
            }
            // static void MissingNumber ();
            {
                int[] samplearray = { 1, 3, 5, 4 };
                List<int> samplelist = new List<int>(samplearray);
                for (int i = 0; i < samplearray.Length; i++)
                {
                    int[] comparray = { 1, 2, 3, 4 };
                    if (samplearray[i] != comparray[i])
                        Console.WriteLine("" + samplearray[i]);

                }
            }
            // static void ArmstrongNumber ();
            {
                Console.Write("Enter number");
                int A = int.Parse(Console.ReadLine());
                while (A >= 1)
                {
                    int a = A % 10;                             //1st place value
                    int c = 0;
                    c = c + (a ^ 3);
                    A = A / 10;                                  //2nd place value
                    if (c == A)
                    {
                        Console.WriteLine("Armstrong Number");
                    }
                    else if (c != A)
                    {
                        Console.WriteLine("Not Armstrong Number");

                    }
                }
            }
            //static void LargestPrefix()
            {
                string[] samplearray1 = new string[] { "Punish", "Punt" };
                string a = samplearray1[0];
                string b = samplearray1[1];
                string largeprefix = "";
                int c = samplearray1[0].Length;
                int d = samplearray1[1].Length;
                for (int i = 0; i < c; i++)
                    for (int j = 0; j < d; j++)
                    {
                        if (a[i] == b[j])
                            break;
                        largeprefix += a[i];
                        Console.WriteLine("" + largeprefix);
                    }
            }
            //static void Fibonacci()
            {
                Console.Write("Enter number greater than 1 ");
                int n = int.Parse(Console.ReadLine());
                int[] newarray = new int[n + 1];
                newarray[0] = 0; newarray[1] = 1;           //Specifying 0 and 1 index value
                for (int i = 2; i < n; i++)
                {
                    newarray[i] = newarray[i - 2] + newarray[i - 1];
                   Console.WriteLine("" + newarray[i]);
                }
            }
        }
    }
}








