using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
            string string1 = Convert.ToString(myInt);
            myString = myString + string1;

            //MAIN:  NUMBER CONVERSION PROGRAM
            ///Console.WriteLine(numberConversion(13, 2));
           
            //CODE GOES HERE

           string binary = "";
            int leftOVER = 0;
           

            Console.WriteLine("Enter number");
            int numb = Convert.ToInt32(Console.ReadLine());

     
            for (int i = 0;i < 8;i++)
             {
              leftOVER = numb % 2;
              binary = leftOVER + binary;
              numb =  numb / 2;
               
            }
             Console.WriteLine(binary);


        }

        

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE

            int answer = number + numberbase;
            string result = answer.ToString();
            return result; //REMOVE THE RED LINE!
        }
    }
}
