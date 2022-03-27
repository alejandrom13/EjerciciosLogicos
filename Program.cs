// See https://aka.ms/new-console-template for more information

using EjerciciosLogicos;

var obj = new CEjercicios();

Console.WriteLine("Hola, selecciona el programa que deseas probar:");
Console.WriteLine("1) Calcular Array");
Console.WriteLine("2) Validar Pin");
Console.WriteLine("3) Salir");
Console.Write("\r\nSeleccione una opción: ");

switch (Console.ReadLine())
{
    case "1":
        Console.Clear();
        Console.Write("Inserte un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(obj.CalcArray(num));
        break;
    case "2":
        Console.Clear();
        break;
}