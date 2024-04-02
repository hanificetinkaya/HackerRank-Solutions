╔══════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                  ║
╟──────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-data-types/problem   ║
║   Difficulty: Easy                                                           ║
║   Language: C#                                                               ║
╠══════════════════════════════════════════════════════════════════════════════╣
║   Solutioin                                                                  ║
╚══════════════════════════════════════════════════════════════════════════════╝


using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        // Declare second integer, double, and String variables.
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        // Read and save an integer, double, and String to your variables.
        int a=Console.ReadLine();
        double b=Console.ReadLine();
        string c=Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+a);

        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}",d+b));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s+c);
    }
}