Console.WriteLine("Mayor De Dos números");
Console.WriteLine("Este programa calcula el mayor de dos numeros proporcionados por el usuario.");

Console.WriteLine();


Console.WriteLine("Escriba el primer número a comnparar y presione enter");
string linea = Console.ReadLine();
int primerNumero = int.Parse(linea);


Console.WriteLine("Escriba el segundo número a comnparar y presione enter");
string linea2 = Console.ReadLine();
int numeroB = int.Parse(linea2);

//Console.WriteLine("Escriba 2 números para saber cual es el mayor");
//Console.WriteLine("Escriba 2 números para saber cual es el mayor");


Console.WriteLine("Procesando...");
Thread.Sleep(2000); //Numero en mili segundos

if (primerNumero == numeroB)
{
    Console.WriteLine("Los numeros son iguales");
}

else
{
    if (primerNumero > numeroB)
    {
        Console.WriteLine("El número mayor es " + primerNumero);
    }
    else { Console.WriteLine("El número mayor es " + numeroB); }

}

Console.WriteLine("Presione una tecla cualquiera para salir.");
Console.ReadLine();


