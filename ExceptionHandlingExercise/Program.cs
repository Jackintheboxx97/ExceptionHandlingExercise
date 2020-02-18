using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'k', 'm', 't'};
            var numbers = new List<int>();
            var str = "";

            foreach(var character in arr)
            {
                try
                {
                str = character.ToString();
                numbers.Add(int.Parse(str));

                }
                catch(Exception e)
                {
                    Console.WriteLine($"Pickles you silly goose! Something is wrong '{character}'");
                }
                foreach(var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            
            // -----------------------------------------------------------------------------
            // DONE First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // DONE Create a list called numbers that will hold integers
            // DONE Create an string variable with an empty string initializer - name it str

            // DONE using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            
            // DONEMake a foreach loop to iterate through your character array
                        

            // Now create a try catch
             
                
                    // Inside your try block
                        // set your string variable to each array element in your char[] to .ToString()
                        // Now, using int.Parse, parse your string variable and store in an int variable
                        // Then add each int to your list
                
                // in your () of your catch, 
                
                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                
            

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
       }
    }
}

