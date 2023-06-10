using System.Text.RegularExpressions;

Console.WriteLine("Enter name");
string name = Console.ReadLine();
Console.WriteLine(name);

//uc1

//string namepattern = "^[A-Z]{3,}$";

//UC2

string namepattern = "^[A-Z]{3,}$";


Regex regex = new Regex(namepattern);

if (regex.IsMatch(name))
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Valid");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("InValid");
    Console.ResetColor();
}