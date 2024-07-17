using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            //CODE GOES HERE

            Console.WriteLine("Enter number");
            Console.WriteLine(Validation(string1));
            Console.WriteLine(DenTOBIN(13, 2));
           

            

           
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




        static string DenTOBIN(int n, int nbase) //STATIC STRINGS MEANS THE DATA TYPE BEING RETUNE IS A STRING
        {
            string binary = "";
            int leftOVER = 0;
            int numb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 8; i++)
            {
                leftOVER = numb % 2;
                binary = leftOVER + binary;
                numb = numb / 2;

            }
           

            string result = binary;
            return result;
        }




        static string Validation(string input)
        {
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb < -1 || numb > 256)
            {

                while (numb < -1)
                {
                    Console.WriteLine("Please enter a number between 0-255");

                    numb = Convert.ToInt32(Console.ReadLine());

                }
                string result = Console.ReadLine();
                return result;
            }
            else if (numb > 255)
            {
                Console.WriteLine("Please enter a number between 0-255");

                numb = Convert.ToInt32(Console.ReadLine());
                string result = Console.ReadLine();
                return result;
            }
           
            else
            {
                string result = Console.ReadLine();
                return result;
            }


        }



    }
}

