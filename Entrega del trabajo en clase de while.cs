// Ejercicio 1
Console.WriteLine("Ingrese el 0 o 1: ");
int num = Convert.ToInt16(Console.ReadLine());

while (num != 0 || num != 1)
{
    if (num == 1 || num == 0)
    {
        Console.WriteLine("correcto, escribio el número: " + num);
        break;
    }
    else
    {
        Console.WriteLine("equivocado, intente de nuevo");
        num = Convert.ToInt16(Console.ReadLine());
    }

}

//Ejercicio 2

Console.WriteLine("Ingrese un número de dos cifras");
int num2 = Convert.ToInt16(Console.ReadLine());
bool seguir = true;

while (seguir)
{
    if (num2 < 0)
    {
        Console.WriteLine("Ingresó un número negativo, intentenlo de vuelta");
        num2 = Convert.ToInt16(Console.ReadLine());
    }
    else if (num2 < 10 || num2 > 99)
    {
        Console.WriteLine("Ingresó un número fuera de rango, intentenlo de vuelta");
        num2 = Convert.ToInt16(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Correcto, su numero:" + num2 + "es de 2 cifras");
        break;
    }
}
