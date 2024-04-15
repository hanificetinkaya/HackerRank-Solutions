╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-2d-arrays/problem                ║
║   Difficulty: Easy                                                                       ║
║   Language: C#                                                                           ║
╠══════════════════════════════════════════════════════════════════════════════════════════╣
║   Solutioin                                                                              ║
╚══════════════════════════════════════════════════════════════════════════════════════════╝


using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        
        int xStart=0;
        int yStart=1;
        int t=0, s=-5000;
        for(int i=0;i<arr.Count()-2;i++)
        {
            for(int j=0;j<4;j++)
            {
                for(int k=j;k<j+3;k++)
                {
                    t+=arr[xStart][k];
                    t+=arr[xStart+2][k];
                }
                t+=arr[xStart+1][yStart];
                if(t>s) s=t;
                t=0;
                yStart++;
                if(yStart==5) yStart=1;
            }
            xStart++;
        }
        Console.WriteLine(s);
    }
}
