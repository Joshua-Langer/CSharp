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

class Result
{

    public static int countingValleys(int steps, string path)
    {
        int valleys = 0;
        var deltas = new[] {1, -1};
        var directions = new[] {'U', 'D'};
        int current = 0;
        bool intoValley = false;
        
        foreach(var s in path.ToCharArray()){
            if(!directions.Contains(s)) throw new ArgumentException();
            
            var effective = Array.IndexOf(directions, s);
            
            var temp = current;
            
            current += deltas[effective];
            
            if(current == 0 && temp < 0)
                valleys++;
        }
        
        return valleys;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
