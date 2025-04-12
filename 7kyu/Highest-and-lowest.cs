// In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

using System;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string []nums = numbers.Split(" ");
    
    int highest = Convert.ToInt32(nums[0]);
    int lowest = Convert.ToInt32(nums[0]);
    
    for (int i = 0; i < nums.Length; i++)
      {
      int currentNum = Convert.ToInt32(nums[i]);
      if (currentNum > highest)
        {
        highest = currentNum;
      } else if (currentNum < lowest)
        {
        lowest = currentNum;
      }
    }
    
    return highest.ToString() + " " + lowest.ToString();
  }
}