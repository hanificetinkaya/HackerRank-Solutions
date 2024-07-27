public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
  int appleCount=0;
  int orangeCount=0;
  for(int i=0;i<apples.Count();i++)
  {
    if(apples[i]+a>=s & apples[i]+a<=t) appleCount++;
  }
      
  for(int i=0;i<oranges.Count();i++)
  {
    if(oranges[i]+b>=s & oranges[i]+b<=t) orangeCount++;
  }
  
  Console.WriteLine(appleCount);        
  Console.WriteLine(orangeCount);        
}
