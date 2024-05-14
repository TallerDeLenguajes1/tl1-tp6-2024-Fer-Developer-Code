// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
//Iniciando punto 1
int num1;
int auxNum;
int num2 = 1;
string linea;
do
{
    Console.WriteLine("Ingrese un valor");
    linea = Console.ReadLine();
    if (int.TryParse(linea, out num1))
    {
        Console.WriteLine("Numero aceptado: " + num1);
        Console.WriteLine("Ingrese un segundo valor");
        linea = Console.ReadLine();
        if (int.TryParse(linea, out num2))
        {
            Console.WriteLine("Numero aceptado: " + num2);
            Console.WriteLine("Num 1: " + num1);
            Console.WriteLine("Num 2: " + num2);
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
} while (num1 < 0);

Console.WriteLine("Num 1 ahora: " + num1);
Console.WriteLine("Num 2 ahora: " + num2);