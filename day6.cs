using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create list of all fish starting in the list
            List<int> listOfFish = new List<int>()
            {
                1,4,1,1,1,1,5,1,1,5,1,4,2,5,1,2,3,1,1,1,1,5,4,2,1,1,3,1,1,1,1,1,1,1,2,1,1,1,1,1,5,1,1,1,1,1,1,1,1,1,4,1,1,1,1,5,1,4,1,1,4,1,1,1,1,4,1,1,5,5,1,1,1,4,1,1,1,1,1,3,2,1,1,1,1,1,2,3,1,1,2,1,1,1,3,1,1,1,2,1,2,1,1,2,1,1,3,1,1,1,3,3,5,1,4,1,1,5,1,1,4,1,5,3,3,5,1,1,1,4,1,1,1,1,1,1,5,5,1,1,4,1,2,1,1,1,1,2,2,2,1,1,2,2,4,1,1,1,1,3,1,2,3,4,1,1,1,4,4,1,1,1,1,1,1,1,4,2,5,2,1,1,4,1,1,5,1,1,5,1,5,5,1,3,5,1,1,5,1,1,2,2,1,1,1,1,1,1,1,4,3,1,1,4,1,4,1,1,1,1,4,1,4,4,4,3,1,1,3,2,1,1,1,1,1,1,1,4,1,3,1,1,1,1,1,1,1,5,2,4,2,1,4,4,1,5,1,1,3,1,3,1,1,1,1,1,4,2,3,2,1,1,2,1,5,2,1,1,4,1,4,1,1,1,4,4,1,1,1,1,1,1,4,1,1,1,2,1,1,2
            };

            //User chooses how many days to run the experiment
            Console.Write("Choose how many days to run the fish experiment: ");
            int numberOfDays = 0;
            bool success = false;
            while (success != true)
                {
                success = Int32.TryParse(Console.ReadLine(), out numberOfDays);
                if (success)
                {
                    //Runs the experiement as many days as chosen
                    for (int j = 0; j < numberOfDays; j++)
                    {
                        //Write out the whole list of fish values
                        foreach (int i in listOfFish)
                        {
                            Console.Write(i);
                            Console.Write(",");
                        }

                        //Count all 0 = Zeros
                        int Zeros = (from x in listOfFish where x < 1 select x).Count();

                        //Remove all 0
                        listOfFish.RemoveAll(x => x < 1);

                        //Adds new fish
                        for (int i = 0; i < Zeros; i++)
                        {
                            //Add Zeroes amount of 6's to the list as replacement of the 0's
                            listOfFish.Add(7);
                            //add Zeroes amount of 8's to the List
                            listOfFish.Add(9);
                        }

                        //Count the number of elements in the fish list
                        int numberOfFish = listOfFish.Count;

                        //Lower all int's in listOfFish with 1
                        for (int i = 0; i < numberOfFish; i++)
                        {
                            listOfFish[i] = listOfFish[i] - 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error: Write a number only");
                    Console.Write("Choose how many days to run the fish experiment: ");
                }
            }



            //Outputs the number of fish in the end
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "There are " + listOfFish.Count + " fish alive after " + numberOfDays + " days.");
            Console.ReadKey();
        }
    }
}
