using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Ui
    {
        public static string menu = "Choose an operation:\n1)Cross\n2)Dot\n3)Magnitude\n";
        
        public static int GetMenuSelection()
        {
            Console.WriteLine(menu);

            int selection = 0;
            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch 
            {
                GetMenuSelection();
            }

            return selection; 
        }

        public static double[] RequestVector3(string prompt = "")
        {
            Console.WriteLine(prompt);

            double[] result = new double[3];

            try
            {
                Console.Write("v1:");
                result[0] = int.Parse(Console.ReadLine());
                Console.Write("v2:");
                result[1] = int.Parse(Console.ReadLine());
                Console.Write("v3:");
                result[2] = int.Parse(Console.ReadLine());
            }
            catch
            {
                RequestVector3();
            }

            return result;
        }
    }
}
