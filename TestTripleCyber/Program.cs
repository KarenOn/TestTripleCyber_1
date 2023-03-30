// See https://aka.ms/new-console-template for more information

int countAleatorio = 0;
int longitudAleatorio = 0;

Console.WriteLine(" --------------------------------------------------------------------- ");
Console.WriteLine("|                         Numeros Aleatorios                          |");
Console.WriteLine(" --------------------------------------------------------------------- ");
do
{
    Console.Write("Introduzca la longitud: ");
    longitudAleatorio = int.Parse(Console.ReadLine());

    if (longitudAleatorio > 20)
    {
        Console.WriteLine("La cantidad máxima de longitud debe ser 20. Inténtalo de nuevo.");
    }
}
while (longitudAleatorio > 20);

int[] iterarAleatorio = new int[longitudAleatorio];
Random numberAleatorios = new Random();

int arrayLength = 0;
while(countAleatorio < longitudAleatorio)
{
    while(arrayLength < iterarAleatorio.Length)
    {
        int numero = numberAleatorios.Next(1, 100);
        if (!iterarAleatorio.Contains(numero))
        {
            iterarAleatorio[arrayLength] = numero;
            arrayLength++;
        }
    }
    countAleatorio++;
}

foreach(int numero in iterarAleatorio)
{
    Console.WriteLine(numero);
}

//////////////////////////////////////////
int countPrimos = 0;
int longitudPrimos;
int numberPrimos = 2;


Console.WriteLine(" --------------------------------------------------------------------- ");
Console.WriteLine("|                             Numeros Primos                          |");
Console.WriteLine(" --------------------------------------------------------------------- ");
Console.Write("Introduzca la longitud: ");
longitudPrimos = int.Parse(Console.ReadLine());

while(countPrimos < longitudPrimos)
{
    if (Primo(numberPrimos))
    {
        Console.WriteLine(numberPrimos);
        countPrimos++;
    }

    numberPrimos++;
}

bool Primo(int numberPrimo)
{
    if(numberPrimo < 2)
    {
        return false;
    }

    for (int i = 2; i < numberPrimo; i++)
    {
        if (numberPrimo % i == 0)
        {
            return false;
        }
    }

    return true;
}

///////////////////////////////////////////////////
int cantidad;
int[] billetes = { 1000, 500, 200, 100, 50 };
int[] monedas = { 25, 10, 5, 1 };


Console.WriteLine(" --------------------------------------------------------------------- ");
Console.WriteLine("|                          Cajero Automático                          |");
Console.WriteLine(" --------------------------------------------------------------------- ");
Console.Write("Introduzca la cantidad: ");
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("Cantidad en billetes y monedas:");
int montoRestante = cantidad;

foreach (int denominacion in billetes)
{
    int cantidadDenominacion = montoRestante / denominacion;
    if (cantidadDenominacion > 0)
    {
        Console.WriteLine($"{cantidadDenominacion} billete(s) de {denominacion}");
    }
    montoRestante %= denominacion;
}

foreach (int denominacion in monedas)
{
    int cantidadDenominacion = montoRestante / denominacion;
    if (cantidadDenominacion > 0)
    {
        Console.WriteLine($"{cantidadDenominacion} moneda(s) de {denominacion}");
    }
    montoRestante %= denominacion;
}

/////////////////////////////////////////////////
List<int> coincidencias = new List<int>();


Console.WriteLine(" --------------------------------------------------------------------- ");
Console.WriteLine("|                              Coincidencias                          |");
Console.WriteLine(" --------------------------------------------------------------------- ");
Console.WriteLine("Numeros primos en el conjunto de aleatorios");

foreach (int numero in iterarAleatorio)
{
    if (Primo(numero))
    {
        Console.WriteLine(numero);
        coincidencias.Add(numero);
    }
}

foreach (int numero in coincidencias)
{
    Console.WriteLine(numero);
}

int numeroMayorCoincidencias = coincidencias.Max();
Console.WriteLine(numeroMayorCoincidencias);

List<int> fibonacci = new List<int>();

int primerNumero = 0;
int segundoNumero = 1;
int numeroFibonacci;

fibonacci.Add(primerNumero);
fibonacci.Add(segundoNumero);


Console.WriteLine(" --------------------------------------------------------------------- ");
Console.WriteLine("|                         Numeros Fibonacci                           |");
Console.WriteLine(" --------------------------------------------------------------------- ");

Console.WriteLine($"Numeros Fibonacci con una longitud de {numeroMayorCoincidencias}");
for (int i = 2; i < numeroMayorCoincidencias; i++)
{
    numeroFibonacci = primerNumero + segundoNumero;
    fibonacci.Add(numeroFibonacci);
    primerNumero = segundoNumero;
    segundoNumero = numeroFibonacci;
}

foreach(int numerosFibonacci in fibonacci)
{
    Console.WriteLine(numerosFibonacci);
}