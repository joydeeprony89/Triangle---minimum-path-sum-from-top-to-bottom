// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var triangle = new List<IList<int>>();
triangle.Add(new List<int>() { 2 });  
triangle.Add(new List<int>() { 3, 4 });
triangle.Add(new List<int>() { 6, 5, 7 });
triangle.Add(new List<int>() { 4, 1, 0, 3 });
Solution s =new Solution();
var answer = s.MinimumTotal(triangle);
Console.WriteLine(answer);
//https://www.youtube.com/watch?v=OM1MTokvxs4&list=PLot-Xpze53ldg4pN6PfzoJY7KsKcxF1jg&index=7

public class Solution
{
  public int MinimumTotal(IList<IList<int>> triangle)
  {
    // Space O(N)
    int rows = triangle.Count;
    int c = triangle[rows - 1].Count;
    var dp = new int[c + 1];

    while (rows-- > 0)
    {
      int columns = triangle[rows].Count;
      for (int i = 0; i < columns; i++)
      {
        int val = triangle[rows][i];
        dp[i] = val + Math.Min(dp[i], dp[i + 1]);
      }
    }

    return dp[0];
  }
}