using System.Net.Mail;
Console.WriteLine("Hola, Mundo!");

static double sumaNumeros(double numCalc1, double numCalc2)
{
    return numCalc1 + numCalc2;
}

AsignacionVariables();
IntercambioValores();
CalculadoraV2();

static void AsignacionVariables()
{
    int a = 10;
    int b = a;
    Console.WriteLine($"Valor de a: {a}");
    Console.WriteLine($"Valor de b: {b}");
}

static void IntercambioValores()
{
    int num1;
    int num2 = 1;
    string linea;
    do
    {
        Console.WriteLine("Ingrese un valor");
        linea = Console.ReadLine();
        if (int.TryParse(linea, out num1))
        {
            Console.WriteLine($"Número aceptado: {num1}");
            Console.WriteLine("Ingrese un segundo valor");
            linea = Console.ReadLine();
            if (int.TryParse(linea, out num2))
            {
                Console.WriteLine($"Número aceptado: {num2}");
                Console.WriteLine($"Num 1: {num1}");
                Console.WriteLine($"Num 2: {num2}");
                int auxNum = num2;
                num2 = num1;
                num1 = auxNum;
            }
            else
            {
                Console.WriteLine("Número no válido");
            }
        }
        else
        {
            Console.WriteLine("Número no válido");
        }
    } while (num1 < 0);

    Console.WriteLine($"Num 1 ahora: {num1}");
    Console.WriteLine($"Num 2 ahora: {num2}");
}

static void CalculadoraV2()
{
    int seguirOperando = 0;
    do
    {
        Console.WriteLine("¿Qué tipo de operación desea realizar?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Valor absoluto\n6.Cuadrado\n7.Raíz cuadrada\n8.Seno\n9.Coseno\n10.Parte entera\n11.Máximo\n12.Mínimo\n13.Terminar\n");
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
                                    resultado = sumaNumeros(numCalc1, numCalc2);
                                    break;
                                case 2:
                                    resultado = numCalc1 - numCalc2;
                                    break;
                                case 3:
                                    resultado = numCalc1 * numCalc2;
                                    break;
                                case 4:
                                    if (numCalc2 != 0)
                                    {
                                        resultado = numCalc1 / numCalc2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se puede dividir por cero");
                                    }
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
                    Console.WriteLine($"El resultado es: {resultado}");
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
}
//Punto 4
Console.WriteLine("Ingrese una cadena:");
string cadena = Console.ReadLine();

// Obtener la longitud de la cadena
Console.WriteLine($"Longitud de la cadena: {cadena.Length}");

// Concatenar con otra cadena
Console.WriteLine("Ingrese otra cadena:");
string cadena2 = Console.ReadLine();
string concatenada = cadena + cadena2;
Console.WriteLine($"Cadenas concatenadas: {concatenada}");

// Extraer una subcadena
if (cadena.Length >= 2)
{
    string subcadena = cadena.Substring(0, 2);
    Console.WriteLine($"Subcadena: {subcadena}");
}

// Realizar operaciones con la calculadora
Console.WriteLine("Ingrese dos números para sumar:");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double resultado = sumaNumeros(num1, num2);
Console.WriteLine($"La suma de {num1} y {num2} es igual a: {resultado}");

// Recorrer la cadena con un ciclo foreach
foreach (char c in cadena)
{
    Console.WriteLine(c);
}

// Buscar la ocurrencia de una palabra
Console.WriteLine("Ingrese una palabra para buscar en la cadena:");
string palabra = Console.ReadLine();
if (cadena.Contains(palabra))
{
    Console.WriteLine($"La palabra '{palabra}' se encontró en la cadena.");
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no se encontró en la cadena.");
}

// Convertir la cadena a mayúsculas y minúsculas
Console.WriteLine($"Cadena en mayúsculas: {cadena.ToUpper()}");
Console.WriteLine($"Cadena en minúsculas: {cadena.ToLower()}");

// Dividir la cadena
Console.WriteLine("Ingrese un carácter para dividir la cadena:");
char divisor = Convert.ToChar(Console.ReadLine());
string[] partes = cadena.Split(divisor);
Console.WriteLine("Partes de la cadena:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

// Resolver una ecuación simple
Console.WriteLine("Ingrese una ecuación simple (p. ej., '582+2'):");
string ecuacion = Console.ReadLine();
string[] numeros = ecuacion.Split('+');
double numA = Convert.ToDouble(numeros[0]);
double numB = Convert.ToDouble(numeros[1]);
double suma = sumaNumeros(numA, numB);
Console.WriteLine($"La suma de {numA} y {numB} es {suma}");

esURL();
Console.Write("Ingresa una dirección de correo electrónico: ");
string emailInput = Console.ReadLine();

bool isValidEmail = IsValidEmail(emailInput);
if (isValidEmail)
{
    Console.WriteLine("Es una dirección de correo electrónico válida.");
}
else
{
    Console.WriteLine("No es una dirección de correo electrónico válida.");
}

static void esURL()
{
    Console.Write("Ingresa una cadena: ");
    string input = Console.ReadLine();

    bool isWebAddress = Uri.TryCreate(input, UriKind.Absolute, out _);
    if (isWebAddress)
    {
        Console.WriteLine("Es una dirección web válida.");
    }
    else
    {
        Console.WriteLine("No es una dirección web válida.");
    }
}

static bool IsValidEmail(string email)
{
    
    try
    {
        var addr = new MailAddress(email);
        return addr.Address == email;
    }
    catch
    {
        return false;
    }
}
