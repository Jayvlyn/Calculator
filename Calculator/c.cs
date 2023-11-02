using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Calculator
{
    public static class c
    {
        // CROSS PRODUCT only works with 3 X 3
        public static double[] Cross(double[] v, double[] w)
        {
            string formula = "v cross w = i((v2*w3) - (w2*v3)) - j((v1*w3) - (w1*v3)) + k((v1*w2) - (w1*v2))";
            Console.WriteLine(formula);

            if (v.Length != w.Length) return new double[0];

            double[] answer = new double[3];

            answer[0] = (v[1] * w[2]) - (w[1] * v[2]);
            answer[1] = (w[0] * v[2]) - (v[0] * w[2]);
            answer[2] = (v[0] * w[1]) - (w[0] * v[1]);

            Console.WriteLine("i((" + v[1] + " * " + w[2] + ") - (" + w[1] + " * " + v[2] + ")) - j((" + v[0] + " * " + w[2] + ") - (" + w[0] + " * " + v[2] + ")) + k((" + v[0] + " * " + w[1] + ") - (" + w[0] + " * " + v[1] + "))");
            //Console.WriteLine("<" + answer[0] + ", " + answer[1] + ", " + answer[2] + ">");

            return answer;
        }

        // DOT PRODUCT
        public static double Dot(double[] v, double[] w)
        {
            string formula = "v dot w = (v1 * w1) + (v2 * w2)";
            Console.WriteLine(formula);

            // Vectors must be of equal length
            if (v.Length != w.Length) return 0;

            double answer = 0;


            for (int i = 0; i < v.Length; i++)
            {
                // Each vector component multiplied by the other, summed up
                Console.Write("("+ v[i] + " * " + w[i] + ")");
                // If not on last index
                if (i != v.Length - 1) Console.Write(" + ");

                // Formula in action
                answer += v[i] * w[i];
            }
            Console.Write(" = " + answer + "\n");

            return answer;
        }

        // MAGNITUDE
        public static double Mag(double[] v)
        {
            string formula = "|v| = sqrt(v1^2 + v2^2)";
            Console.WriteLine(formula);

            double answer = 0;

            Console.Write("Sqrt((");
            for (int i = 0; i< v.Length; i++)
            {
                // Each component squared
                Console.Write(v[i] + "^2");
                // If not on last index
                if (i != v.Length - 1) Console.Write(" + ");

                // Formula in action
                answer += Math.Pow(v[i], 2);
            }
            Console.Write(")\n");

            Console.WriteLine("Sqrt(" + answer + ")");

            // Sqrt of all components squared and added together
            answer = Math.Sqrt(answer);

            return answer;
        }

        public static string AsVector(double[] v)
        {
            string vec = "<";
            for (int i = 0; i< v.Length; i++) 
            {
                vec += v[i].ToString();
                if (i != v.Length - 1) vec += ", ";
            }
            vec += ">";

            return vec;
        }


    }
}
