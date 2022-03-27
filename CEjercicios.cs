using System.Text.RegularExpressions;

namespace EjerciciosLogicos;

public class CEjercicios
{
    public string CalcArray(int num)
    {
        //Variables & Definitions
        const int min = 1;
        const int max = 20;
        var random = new Random();
        
        //This line gives a size to the array w/ parameter &
        //fills array with random numbers
        var numArray = Enumerable
            .Repeat(0, num)
            .Select(i => random.Next(min, max))
            .ToArray();

        //This line multiplies each number by the next
        var arrayMult = numArray.Aggregate((x, y) => x * y); 

        //This line takes multiplication, then evaluate if the total is even
        return arrayMult % 2 == 0 ? $"{arrayMult} es par, por ende la sumatoria es {numArray.Sum()}" : "0";
    }

    public string ValidatePin(string? input)
    {
        string pin = Regex.Replace(input, @"\D", ""); //Removes non-number characters

        if (pin.Length is 4 or 6 && //Validates if length is 4 or 6
            !Regex.IsMatch(pin, @"([0-9])[0-9]*\1")) //Validates if there aren't repeating numbers
            return "PIN VALIDO";
        
        return "PIN INVALIDO";
    }
}