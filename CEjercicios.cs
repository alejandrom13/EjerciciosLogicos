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

        var arrayMult = numArray.Aggregate((x, y) => x * y);

        return arrayMult % 2 == 0 ? $"{arrayMult} es par, por ende la sumatoria es {numArray.Sum()}" : "0";
    }

    public string ValidatePin(string pin)
    {
        return null;
    }
}