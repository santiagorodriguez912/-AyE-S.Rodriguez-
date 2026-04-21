
//EJERCICIO 1
Console.WriteLine("ejercicio 1");
Console.WriteLine("ingrese una palabra");
String palabra = Console.ReadLine();
String vocales = "aeiouAEIOU";
int cont = 0;
for (int i = 0; i < palabra.Length; i++)
{
    for (int v = 0; v < vocales.Length; v++)
    {
        if (palabra[i] == vocales[v])
        {
            cont++;
            break;
        }
    }
}
Console.WriteLine("las vocales que hay en la oracion es de: " + cont);


//EJERCICIO 2
Console.WriteLine("ejercicio 2");
Console.WriteLine("ingrese su palabra");
String agus = Console.ReadLine();
String invert = "";
foreach (char letra in agus)
{
    invert = letra + invert;
}
Console.WriteLine("su texto invertido es: " + invert);


//EJERCICIO 3
Console.WriteLine("ingrese un numero entero");
string texto = Console.ReadLine();
int aux = 0;
int aux2 = 0;
foreach (char n in texto)
{
    aux = Convert.ToInt16(n);
    aux2 = aux + aux2;
}
Console.WriteLine(aux2);