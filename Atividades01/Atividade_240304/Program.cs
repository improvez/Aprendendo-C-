// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");



string operador = "+";
operador = Console.ReadLine();
string numero5 = "5";
numero5 = Convert.ToDouble(Console.ReadLine());
string numero6 = "6";
numero6 = Console.ReadLine();

switch (operador)
{
    case operador == "+":
    Console.WriteLine($"{numero5 + numero6}");
    break;

    case operador == "-":
    Console.WriteLine($"{numero5 - numero6}");
    break;

    case operador == "*":
    Console.WriteLine($"{numero5 * numero6}");
    break;

    case operador == "/":
    Console.WriteLine($"{numero5 / numero6}");
    break;
    
    default:
    Console.WriteLine("0");
    break;
}