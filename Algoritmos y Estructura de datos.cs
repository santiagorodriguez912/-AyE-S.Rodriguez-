//evaluacion 12/5 AyE

//ejercicio 1

Console.WriteLine("vamos a calcular el salario de un obrero");
try
{
        Console.WriteLine("ingrese sus horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());
}
catch
{
        Console.WriteLine("error al ingresar el numero")
}
    int salario;
    int aux;
    if (horas <= 40)
    {
        salario = horas * 16;
        Console.WriteLine("su salario es de: " + salario + "$");
    }
    else
    {
        aux = (horas - 40) * 20;
        Console.WriteLine("la cantidad extra de su salario x las horas extras es de: " + aux + "$ sumado a su salario de 640$ ");
    }


//ejercicio2
    
try
{
 Console.WriteLine("ingrese el numero para sumar y 0 para terminar")
 numero = int.Parse(Console.ReadLine());
 suma += numero;

}
catch
{
  Console.WriteLine("error");
}
    while (numero != 0)
    {
        return suma;
    }

//ejercicio 3
try
{
        Console.WriteLine("ingrese una palabra");
        string oracion = Console.ReadLine().ToLower();
}
catch
{
        Console.WriteLine("error al ingresar la palabra")
}
    string vocales = "aeiou";
    int cont = 0;
for (int i = 0; i < oracion.Length; i++)
{
  for (int v = 0; v < vocales.Length; v++)
  {
     if (oracion[i] == vocales[v])
     {
       cont++;
       break;
     }
  }

}
Console.WriteLine("la cantidad de vocales son de: " + cont);

//ejercicio4
    Console.WriteLine("palabra palindromo" + pedirpalindromo());
static string pedirpalindromo()
{


        string invertida = "";
        string palabra = "";
 try
 {
    Console.WriteLine("ingrese una palabra");
    palabra = Console.ReadLine().ToLower();

    invertida = "";
    for (int i = palabra.Length - 1; i >= 0; i--)
    {
       invertida += palabra[i];
    }
    if (palabra != invertida)
    {
                Console.WriteLine("no es un palindromo");
    }
 }
 catch
 {
  Console.WriteLine("error al ingresar su palabra");
 }
  while (palabra != invertida) ;
  return palabra;
}
