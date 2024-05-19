﻿// See https://aka.ms/new-console-template for more information
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


//Iniciando punto CalculadoraV2

int seguirOperando = 0;
do
{
    Console.WriteLine("Que tipo de operación desea realizar?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Valor absoluto\n6.Cuadrado\n7.Raíz cuadrada\n8.Seno\n9.Coseno\n10.Parte entera\n11.Máximo\n12.Mínimo\n13.Terminar\n");
    string lineaCalc = Console.ReadLine();
    int opcion;

    if (int.TryParse(lineaCalc, out opcion))
    {
        double numCalc1 = 0;
        double numCalc2 = 0;
        double resultado = 0;

        if (opcion >= 1 && opcion <= 12)
        {
            Console.WriteLine("Inserte el primer número\n");
            lineaCalc = Console.ReadLine();
            if (double.TryParse(lineaCalc, out numCalc1))
            {
                if (opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("Inserte el segundo número\n");
                    lineaCalc = Console.ReadLine();
                    if (double.TryParse(lineaCalc, out numCalc2))
                    {
                        // Operaciones básicas
                        switch (opcion)
                        {
                            case 1:
                                resultado = numCalc1 + numCalc2;
                                break;
                            case 2:
                                resultado = numCalc1 - numCalc2;
                                break;
                            case 3:
                                resultado = numCalc1 * numCalc2;
                                break;
                            case 4:
                                resultado = numCalc1 / numCalc2;
                                break;
                        }
                    }
                }
                else
                {
                    // Operaciones unarias
                    switch (opcion)
                    {
                        case 5:
                            resultado = Math.Abs(numCalc1);
                            break;
                        case 6:
                            resultado = Math.Pow(numCalc1, 2);
                            break;
                        case 7:
                            resultado = Math.Sqrt(numCalc1);
                            break;
                        case 8:
                            resultado = Math.Sin(numCalc1);
                            break;
                        case 9:
                            resultado = Math.Cos(numCalc1);
                            break;
                        case 10:
                            resultado = Math.Truncate(numCalc1);
                            break;
                        case 11:
                        case 12:
                            Console.WriteLine("Inserte el segundo número\n");
                            lineaCalc = Console.ReadLine();
                            if (double.TryParse(lineaCalc, out numCalc2))
                            {
                                if (opcion == 11)
                                {
                                    resultado = Math.Max(numCalc1, numCalc2);
                                }
                                else
                                {
                                    resultado = Math.Min(numCalc1, numCalc2);
                                }
                            }
                            break;
                    }
                }
                Console.WriteLine("El resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("Número no válido");
            }
        }
        else if (opcion == 13)
        {
            seguirOperando = 5;
        }
        else
        {
            Console.WriteLine("Ingrese un valor válido");
        }
    }
    else
    {
        Console.WriteLine("Opción no válida");
    }
} while (seguirOperando != 5);