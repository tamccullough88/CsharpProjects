using System.Runtime.CompilerServices;

string[] values = { "abc", "12.3", "45", "11", "def"};

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number)) 
    {   
        total += number;
    } else 
    {
        message += value;

    }
}

Console.WriteLine($"message: {message}");
Console.WriteLine($"Total: {total}");