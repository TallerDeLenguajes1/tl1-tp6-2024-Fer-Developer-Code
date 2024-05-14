// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
int num1;
int num2;
int auxNum;
string linea;
do
{
    Console.WriteLine("Ingrese un valor");
    linea = Console.ReadLine();
    if (int.TryParse(linea, out num1))
    {
        Console.WriteLine("Numero aceptado" + num1);
        linea = Console.ReadLine();
        if (int.TryParse(linea, out num2))
        {
            Console.WriteLine("Numero aceptado" + num2);
            auxNum = num2;
            num2 = num1;
            num1 = auxNum;
        }
        else
        {
            Console.WriteLine("Numero no valido");
        }
    }
    else
    {
        Console.WriteLine("Numero no valido");
    }
} while ((num1 < 0) && (num2 < 0));