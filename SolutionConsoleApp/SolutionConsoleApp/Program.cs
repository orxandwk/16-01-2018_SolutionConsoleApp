﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    
    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {
        int[] Alice_Bob = new int[]{ 0,0};
        if (a0 > b0)
        {
            Alice_Bob[0]++;
        } 
        else if (a0 != b0)
        {
            Alice_Bob[1]++;
        }

        if (a1 > b1)
        {
            Alice_Bob[0]++;
        }
        else if (a1 != b1)
        {
            Alice_Bob[1]++;
        }

        if (a2 > b2)
        {
            Alice_Bob[0]++;
        }
        else if (a2 != b2)
        {
            Alice_Bob[1]++;
        }
        return Alice_Bob;
    }

    static void Main(String[] args)
    {
        Console.WriteLine("3 ayri reqem daxil edin (yan-yana bosluqla ayrilmis).");
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        Console.WriteLine("3 ayri reqem daxil edin (yan-yana bosluqla ayrilmis).");
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));


    }
}
