╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-review-loop/problem              ║
║   Difficulty: Easy                                                                       ║
║   Language: C#                                                                           ║
╠══════════════════════════════════════════════════════════════════════════════════════════╣
║   Solutioin                                                                              ║
╚══════════════════════════════════════════════════════════════════════════════════════════╝


using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N=Convert.ToInt32(Console.ReadLine());
        for(int j=0;j<N;j++)
        {
            string S=Console.ReadLine();
            string l="";
            string r="";
            for(int i=0;i<S.Length;i++)
            {
                if (i%2 == 0)
                    l += S[i];
                else
                    r += S[i];
            }
            Console.WriteLine(l+" "+r);
        }
    }
}
