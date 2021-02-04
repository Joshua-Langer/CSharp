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
    static int[] solve(int[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            var item = grades[i];
            if(item >= 38)
            {
                var diff = 5 - (item % 5);
                if(diff < 3)
                    grades[i] = item + diff;
            }
        }
        return grades;
    }
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int i = 0; i < n; i++)
        {
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}