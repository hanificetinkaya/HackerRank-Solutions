╔═════════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                                 ║
╟─────────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem ║
║   Difficulty: Medium                                                                        ║
║   Language: C#                                                                              ║
╠═════════════════════════════════════════════════════════════════════════════════════════════╣
║   Solutioin                                                                                 ║
╚═════════════════════════════════════════════════════════════════════════════════════════════╝


using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<t;i++)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckPrime(n));
        }
    }
    
    public static string CheckPrime(int number)
    {
        if (number==2 || number==3 || number==5) return "Prime";
        bool check=false;
        for(int i=2;i<number/2;i++)
        {
            if(number%i==0) return "Not prime";
            else
            {
                check=true;
            }
        }
        if (check) return "Prime";
        else return "Not prime";
    }
}
