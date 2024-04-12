╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-binary-numbers/problem           ║
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
        string bit=convertToBinary(n);
        int say=0;
        int enCok=0;
        for(int i=0;i<bit.Length;i++)
        {
            if(bit[i]=='1') say++;
            else
            {
                if(say>enCok) enCok=say;
                say=0;
            }
        }
        if(say>enCok) enCok=say;
        Console.WriteLine(enCok);
    }
    
    public static string convertToBinary(int n)
    {
        string bit="";
        while(n!=0)
        {
            bit+=n%2;
            n=n/2;
        }
        return bit;
    }
}
