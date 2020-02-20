using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // temperature data is in temps.txt

            Console.WriteLine("Enter File Name");
            string fileName = Console.ReadLine();
            

            if(File.Exists(fileName))
            {

                Console.WriteLine("Input a Temperature Threshold");
                string input = Console.ReadLine();
                int threshold = int.Parse(input);

                int tempValue;
                int tempSum = 0;
                int aboveCount = 0;
                int belowCount = 0;
                int totalCount = 0;

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string line = sr.ReadLine();




                    while (line != null)
                    {
                        tempValue = int.Parse(line);

                        tempSum += tempValue;
                        totalCount += 1;

                        if (tempValue >= threshold)
                        {
                            aboveCount += 1;
                        }
                        else
                        {
                            belowCount += 1;
                        }

                        line = sr.ReadLine();
                    }
                }

                Console.WriteLine("Number of Temperatures Above = " + aboveCount);
                Console.WriteLine("Number of Temperatures Below = " + belowCount);

                int aveTemp = tempSum / totalCount;

                Console.WriteLine("Average Temperature is " + aveTemp);
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
    }
}
