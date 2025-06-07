namespace Source_Test_Git;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Header
{
    // This is a header file for the Source_Test_Git project.
    // It contains common using directives and other shared code.
    
    // Add any common functionality or constants here that can be used across multiple files.
    
    public const string ProjectName = "Source_Test_Git";
    public const string Version = "1.0.0";
    
    public static void PrintHeader()
    {
        Console.WriteLine($"{ProjectName} - Version {Version}");
    }
}