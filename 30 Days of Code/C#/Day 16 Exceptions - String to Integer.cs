╔══════════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                                  ║
╟──────────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem ║
║   Difficulty: Easy                                                                           ║
║   Language: C#                                                                               ║
╠══════════════════════════════════════════════════════════════════════════════════════════════╣
║   Solutioin                                                                                  ║
╚══════════════════════════════════════════════════════════════════════════════════════════════╝


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
        string S = Console.ReadLine();
        try
        {
            int a=Convert.ToInt32(S);
            Console.WriteLine(a);
        }
        catch(Exception e)
        {
            Console.WriteLine("Bad String");
        }
    }
}
