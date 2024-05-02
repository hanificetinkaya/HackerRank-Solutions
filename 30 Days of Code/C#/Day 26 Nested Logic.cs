╔══════════════════════════════════════════════════════════════════════════════════════════╗
║                                 Information                                              ║
╟──────────────────────────────────────────────────────────────────────────────────────────╢
║   Direct Link: https://www.hackerrank.com/challenges/30-nested-logic/problem             ║
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
        string[] returnedDateStr=Console.ReadLine().Split(' ');
        string[] dueDateStr=Console.ReadLine().Split(' ');
        
        int returnedDateDay=int.Parse(returnedDateStr[0]);
        int returnedDateMonth=int.Parse(returnedDateStr[1]);
        int returnedDateYear=int.Parse(returnedDateStr[2]);
        
        int dueDateDay=int.Parse(dueDateStr[0]);
        int dueDateMonth=int.Parse(dueDateStr[1]);
        int dueDateYear=int.Parse(dueDateStr[2]);
        
        DateTime returnedDate=new DateTime(returnedDateYear, returnedDateMonth, returnedDateDay);
        DateTime dueDate=new DateTime(dueDateYear, dueDateMonth, dueDateDay);
        
        NestedLogic(dueDate, returnedDate);
    }
    
    private static void NestedLogic(DateTime dueDate, DateTime returnedDate)
    {
        int fine=0;
        if(returnedDate<=dueDate) fine=0;
        else if(returnedDate.Month==dueDate.Month && returnedDate.Year==dueDate.Year) fine=15*(returnedDate.Day-dueDate.Day);
        else if(returnedDate.Year==dueDate.Year) fine=500*(returnedDate.Month-dueDate.Month);
        else fine=10000;
        
        Console.WriteLine(fine);
    }
}
