using System;
namespace ConsoleApp1
{
    public class FizzBuzz
    {
        public void fizzBuzz(int[] args)
        {
            foreach (var t in args)
            {
                string s = "";
                s += t % 3 == 0 ? "sas" : "";
                s += t % 5 == 0 ? "sos" : "";
                if (!(s.Equals("")))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}