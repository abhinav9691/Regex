﻿using System;
using System.Text.RegularExpressions;




//UC4
Console.WriteLine("Enter The Mobile");
string name = Console.ReadLine();
string namepattern = "^[1-9]{1,2}[ ][6-9]{1}[0-9]{9}$";
Regex regex = new Regex(namepattern);
if (regex.IsMatch(name))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Valid");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("InValid");
    Console.ResetColor();
}



