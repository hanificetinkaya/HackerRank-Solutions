╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-scope/problem                    ║
║   Difficulty: Easy                                                                       ║
║   Language: C#                                                                           ║
╠══════════════════════════════════════════════════════════════════════════════════════════╣
║   Solutioin                                                                              ║
╚══════════════════════════════════════════════════════════════════════════════════════════╝


using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    // Add your code here  
    public Difference(int[] _elements)
    {
        elements=_elements;
    }
    
    public void computeDifference()
    {
        maximumDifference=0;
        for(int i=0;i<elements.Length-1;i++)
        {
            for(int j=i+1;j<elements.Length;j++)
            {
                if(Math.Abs(elements[i]-elements[j])>maximumDifference) maximumDifference=Math.Abs(elements[i]-elements[j]);
            }
        }
    }	
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
