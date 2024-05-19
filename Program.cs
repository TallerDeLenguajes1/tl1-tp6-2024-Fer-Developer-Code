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
double resultado = num1 + num2;
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
double suma = numA + numB;
Console.WriteLine($"La suma de {numA} y {numB} es {suma}");