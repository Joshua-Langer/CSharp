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

class Solution {

    static void Main(string[] args) {
        var rockCount = int.Parse(Console.ReadLine());
        var mineralMap = new Dictionary<char, int>();
        var rock = Console.ReadLine();
        
        foreach(var mineral in rock)
        {
            if(!mineralMap.ContainsKey(mineral))
            {
                mineralMap.Add(mineral, 1);
            }
        }
        
        for(var i = 1; i <rockCount; i++)
        {
            rock = Console.ReadLine();
            var currentRockUnique = new HashSet<char>();
            foreach(var mineral in rock)
            {
                if(mineralMap.ContainsKey(mineral) && !currentRockUnique.Contains(mineral))
                {
                    mineralMap[mineral]++;
                    currentRockUnique.Add(mineral);
                }
            }
        }
        
        var gemstone = 0;
        foreach(var mineral in mineralMap)
        {
            if(mineral.Value == rockCount)
                gemstone++;
        }
        Console.WriteLine(gemstone);
    }
}