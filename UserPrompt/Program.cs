using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPrompt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for child's details
            //
            Console.Write("Enter the child's name and surname: ");
            string sName = Console.ReadLine();
            
            //Taken with consideration that user will enter an uppercase value of either 'M' or 'F'.
            Console.Write("\nSelect the child's gender (M/F): ");
            char cGender = Console.ReadKey().KeyChar;
            
            //Taken with consideration that the user will enter ages between 0 and 19.
            Console.Write("\nEnter the child's age (years): ");
            int iAge = int.Parse(Console.ReadLine());
            

            string sMsg = sName + " is a(n) " + iAge.ToString() + " year old ";

            if (cGender == 'M'
                )
            {
                sMsg += "male ";
            }
            else
            {
                sMsg += "female ";
            }

            if(iAge <= 1)
            {
                sMsg += "baby.";
            }
            else
            {
                if (iAge >= 2 && iAge <= 3)
                {
                    sMsg += "toddler.";
                }
                else if (iAge >= 4 && iAge <= 5)
                {
                    sMsg += "preschooler.";
                }
                else if (iAge >= 6 && iAge <= 12)
                {
                    sMsg += "grade-schooler.";
                }
                else if (iAge <= 19)
                {
                    sMsg += "teenager.";
                }
                else
                    sMsg += "Adult";
            }
            Console.WriteLine();
            Console.WriteLine(sMsg);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
