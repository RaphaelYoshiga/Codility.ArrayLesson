using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] A)
    {
        var knownItemsAndCount = new Dictionary<int, int>();
        foreach (var number in A)
        {
            if (knownItemsAndCount.ContainsKey(number))
                knownItemsAndCount[number]++;
            else
                knownItemsAndCount[number] = 1;
        }

        return knownItemsAndCount.First(p => p.Value % 2 != 0).Key;
    }
}