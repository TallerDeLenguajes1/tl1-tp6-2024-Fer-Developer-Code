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

//Iniciando punto CalculadoraV1
int opcion;
int seguirOperando;
int numCalc1;
int numCalc2;
int resultado;
string lineaCalc;
do
{
    Console.WriteLine("Que tipo de operación desea realizar?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Terminar\n");
    lineaCalc = Console.ReadLine();
    if (int.TryParse(lineaCalc, out opcion))
    {
        if (opcion >= 1 && opcion <= 4)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Inserte el primer numero a sumar\n");
                    lineaCalc = Console.ReadLine();
                    if (int.TryParse(lineaCalc, out numCalc1))
                    {
                        Console.WriteLine("Inserte el segundo numero a sumar\n");
                        lineaCalc = Console.ReadLine();
                        if (int.TryParse(lineaCalc, out numCalc2))
                        {
                            resultado = numCalc1 + numCalc2;
                            Console.WriteLine("El resultado es: " + resultado);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Inserte el primer numero a restar\n");
                    lineaCalc = Console.ReadLine();
                    if (int.TryParse(lineaCalc, out numCalc1))
                    {
                        Console.WriteLine("Inserte el segundo numero a restar\n");
                        lineaCalc = Console.ReadLine();
                        if (int.TryParse(lineaCalc, out numCalc2))
                        {
                            resultado = numCalc1 - numCalc2;
                            Console.WriteLine("El resultado es: " + resultado);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Inserte el primer numero a multiplicar\n");
                    lineaCalc = Console.ReadLine();
                    if (int.TryParse(lineaCalc, out numCalc1))
                    {
                        Console.WriteLine("Inserte el segundo numero a multiplicar\n");
                        lineaCalc = Console.ReadLine();
                        if (int.TryParse(lineaCalc, out numCalc2))
                        {
                            resultado = numCalc1 * numCalc2;
                            Console.WriteLine("El resultado es: " + resultado);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Inserte el primer numero a dividir\n");
                    lineaCalc = Console.ReadLine();
                    if (int.TryParse(lineaCalc, out numCalc1))
                    {
                        Console.WriteLine("Inserte el segundo numero a dividir\n");
                        lineaCalc = Console.ReadLine();
                        if (int.TryParse(lineaCalc, out numCalc2))
                        {
                            resultado = numCalc1 / numCalc2;
                            Console.WriteLine("El resultado es: " + resultado);
                        }
                    }
                    break;
            }
            Console.WriteLine("Desea seguir operando? Presione cualquier numero menos 5\n");
            lineaCalc = Console.ReadLine();
            if (int.TryParse(lineaCalc, out seguirOperando))
            {
                Console.WriteLine("Eligio seguir operando");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un valor valido");
        }
    }

} while (seguirOperando != 5);