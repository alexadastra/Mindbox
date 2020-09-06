using System;

namespace ConsoleApp1
{
    public class Quadatic
    {
        static void SolveQuadraticEquasion()
        {
            string equasion = InputEquasion();
            float[] coefficients = ParseEquasion(equasion);
            bool coefficientsAreValid = ValidateCoefficients(coefficients);
            if (coefficientsAreValid)
            {
                float D = calculateDiscriminant(coefficients);
                if (D < 0)
                {
                    returnNullSolutions();
                }
                else
                {
                    double[] solutions = calculateSolutions(coefficients, D);
                    PrintResults(solutions);
                }
            }
        }

        // reads equasion from somewhere
        // return equasion as string
        static string InputEquasion()
        {
            return "";
        }

        // parses equasion as string
        // returns int[3] result, where result[0] = a, result[1] = b, result[2] = c  
        static float[] ParseEquasion(string equasion)
        {
            return new float[] { };
        }

        // validates coefficients
        // returns true if everything is alright, else prints message
        static bool ValidateCoefficients(float[] coefficirnts)
        {
            return false;
        }

        // calculates D as b^2 - 4ac
        // returns value
        static float calculateDiscriminant(float[] coefficients)
        {
            return (float) 0.0;
        }

        // returns a message that there's no solutions
        static void returnNullSolutions()
        {

        }

        // calculates x1 and x2
        // returns float[] = {x1, x2}
        public static double[] calculateSolutions(float[] coefficients, float D){

            double x1 = (-coefficients[1] + Math.Sqrt(D)) / (2 * coefficients[0]);
            double x2 = (-coefficients[1] - Math.Sqrt(D)) / (2 * coefficients[0]);
            return x1 == x2 ? new double[] {x1} : new double[] {x1, x2};
        }

    // prints solutions
        static void PrintResults(double[] solutions)
        {
            
        }
        
        static void solve(string[] args)
        {
            //int[] arr = new[] {1, 2, 3, 4, 5, 6, 15};
            //fizzBuzz(arr);
            SolveQuadraticEquasion();
        }
    }
}