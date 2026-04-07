//ejercicio 1

Console.WriteLine("ejercicio 1");
String contraseña = "12345";
String intento = "-";
Console.WriteLine("ingrese la contraseña");
while (intento != contraseña)
{
    if (intento == "-")
    {

    }
    else {
        Console.WriteLine("Intentelo de nuevo");
    }
    intento = Console.ReadLine();
}
Console.WriteLine("Entrando");



//ejercicio 2

Console.WriteLine("ejercicio 2");

Console.WriteLine("cuenta regresiva");
for (int asd =5; asd >= 1; asd--) {
    Console.WriteLine(asd);
}
Console.WriteLine("¡Listo para despegar!");
Console.WriteLine("¡Despegue!");



//ejercicio 3
Console.WriteLine("ejercicio 3");
Console.WriteLine("adivine el numero secreto");
int secreto = 7;
int num = 0;
while (num != secreto)
{
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("¡Felicidades! Adivinaste el número.");



//ejercicio 4
Console.WriteLine("ejercicio 4");
int suma = 0;
int numero = -1;
while (numero != 0)
{
    Console.WriteLine("ingrese los numeros que desee sumar y ingrese 0 si y no desea sumar más");
    numero = Convert.ToInt32(Console.ReadLine());
    suma += numero;
}
    Console.Write("el resultado de la suma es: ");
    Console.Write(suma);


