╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-sorting/problem                  ║
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
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        int t=0;
        int swapsCount=0;
        for(int i=0; i<a.Count();i++)
        {
            for(int j=i;j<a.Count();j++)
            {
                if(a[i]>a[j])
                {
                    swapsCount++;
                    t=a[j];
                    a[j]=a[i];
                    a[i]=t;
                }
            }
        }
        
        Console.WriteLine($"Array is sorted in {swapsCount} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Count()-1]}");
    }
}
