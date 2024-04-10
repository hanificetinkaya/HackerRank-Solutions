╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem    ║
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
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> dic=new Dictionary<string, int>();
        for(int i=0;i<n;i++)
        {
            string data=Console.ReadLine();
            dic.Add(data.Split(' ')[0],Convert.ToInt32(data.Split(' ')[1]));
        }
        
        for(int i=0;i<n;i++)
        {
            string name=Console.ReadLine();
            if(dic.ContainsKey(name))
                Console.WriteLine(name+"="+dic[name]);            
            else Console.WriteLine("Not found");
        }
    }
}
