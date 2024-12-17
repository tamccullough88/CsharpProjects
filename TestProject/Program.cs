using System.Runtime.CompilerServices;
string? readResult;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter a number between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (readResult != null)
    {
        if (validNumber == true)
        {
            if (numericValue <= 5 || numericValue >= 10)
            {
                validNumber = false;
                Console.WriteLine($"You entered {numericValue}, Please enter a valid number");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    }

} while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");

readResult = Console.ReadLine();