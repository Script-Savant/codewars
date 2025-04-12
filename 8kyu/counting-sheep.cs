// Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).

 public static int CountSheeps(bool[] sheeps)
  {
    int count = 0;
    
    for (int i = 0; i < sheeps.Length; i++)
    {
      if (sheeps[i] == true)
        {
        count++;
      }
    }
    
    return count;
  }