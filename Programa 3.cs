// EJERCICIO PROGRAMA 3 S.RODRIGUEZ

string palabra = "MANTECA";
string aux = "";
int intentos = 7;
for (int i = 0; i < palabra.Length; i++)
{
    aux += "_";
}
while (intentos > 0 && aux != palabra)
{
    Console.WriteLine("Palabra: " + aux);
    Console.WriteLine("Intentos restantes: " + intentos);
    Console.WriteLine("Ingrese una letra: ");
    string letra = Console.ReadLine().ToUpper();

    bool asd = false;
    string nv = "";

    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra[i].ToString() == letra)
        {
            nv += letra;
            asd = true;
        }
        else
        {
           nv += aux[i];
        }
    }

    aux = nv;

    if (asd == false)
    {
        intentos--;
        Console.WriteLine("Letra incorrecta");
    }

}
if (aux == palabra)
{
    Console.WriteLine("ganaste, La palabra era: " + palabra);
}
else
{
    Console.WriteLine("perdiste, La palabra era: " + palabra);
}
