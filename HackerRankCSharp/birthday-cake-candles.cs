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
using static System.Console;

class Solution
{
    public static void Main(string[] args)
    {
        ReadLine();
        var heightTemp = ReadLine().Split(' ');
        var height = Array.ConvertAll(heightTemp, int.Parse);
        var maxValue = height[0];
        var maxValueOccurs = 1;
        
        for(int i = 1; i < height.Length; i++)
        {
            if(height[i] == maxValue)
            {
                maxValueOccurs++;
                continue;
            }
            
            if(height[i] > maxValue)
            {
                maxValue = height[i];
                maxValueOccurs = 1;
            }
        }
        WriteLine(maxValueOccurs);
    }
}