using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{

    public static string startPeg, endPeg, tempPeg;
    public static int totalDisks;

    public static void Main(String[] args)
    {
        startPeg = "A";
        endPeg = "C";
        tempPeg = "B";
        totalDisks = 3;

        solver(totalDisks, startPeg, endPeg, tempPeg);
        Console.WriteLine("#########################");
    }

    private static void solver(int n, string startPeg, string endPeg, string tempPeg)
    {
        if (n > 0)
        {
            solver(n - 1, startPeg, tempPeg, endPeg);
            Console.WriteLine("#########################");
            Console.WriteLine("Moving disk from " + startPeg + " to " + endPeg);
            solver(n - 1, tempPeg, endPeg, startPeg);
        }
    }

}