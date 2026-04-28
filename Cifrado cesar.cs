Console.WriteLine();

string abc = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine("Cifrado cesar");
Console.WriteLine(funcion1(abc));
Console.WriteLine("Elija alguna de estas funciones sobre el Cifrado Cesar: ");
Console.WriteLine("1: Cifrado           2: Descifrado         0: Cerrar Programa");

int menu = Convert.ToInt32(Console.ReadLine());

// Función 1

string funcion1(string abc)
{
    string w = "Su mensaje es: ";
    string mensaje = "";
    bool Valido = false;

    while (!Valido)
    {

        Console.WriteLine("Escribe el mensaje, trate no poner caracteres que no sean letras:");
        mensaje = Console.ReadLine();
        mensaje = mensaje.ToLower();

        bool Error = false;

        for (int i = 0; i < mensaje.Length; i++)
        {
            char caracterUsuario = mensaje[i];
            bool encontrado = false;

            for (int j = 0; j < abc.Length; j++)
            {
                if (caracterUsuario == abc[j])
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Error = true;
                break;
            }
        }

        if (Error)
        {
            Console.WriteLine("El mensaje contiene caracteres que no estan permitidos");
        }
        else
        {
            Valido = true;
        }


    }
    return w + mensaje;
}
string mensaje = funcion1(abc);
// Función 2: Cifrado

string Cifrado(string mensaje)
{
    Console.WriteLine("Escribir la clave");
    int clave = Convert.ToInt32(Console.Read());
    string NewText = "";
    string texto = mensaje;
    string abc = "abcdefghijklmnopqrstuvwxyz";

    for (int i = 0; i <= texto.Length; i++)
    {
        for (int x = 0; x <= abc.Length; x++)
        {
            if (texto[i] == abc[x])
            {
                NewText = NewText + abc[i + clave];
                Console.WriteLine(NewText);
                break;
            }
        }
    }
    Console.WriteLine("Texto cifrado: " + NewText);
    return NewText;
}

//Función 2: Descifrado

string Descifrado(string mensaje)
{
    Console.WriteLine("Escribir la clave");
    int clave = Convert.ToInt32(Console.Read());
    string NewText = "";
    string texto = mensaje;
    string abc = "abcdefghijklmnopqrstuvwxyz";

    for (int i = 0; i < texto.Length; i++)
    {
        for (int x = 0; x < abc.Length; x++)
        {
            if (texto[i] == abc[x])
            {
                NewText = NewText + abc[x - clave];
                Console.WriteLine(NewText);
                break;
            }
        }
    }
    Console.WriteLine("Texto descifrado: " + NewText);
    return NewText;
}
switch (menu)
{
    case 1:
        Descifrado(mensaje);
        break;

    case 2:
        Cifrado(mensaje);
        break;

    case 0:
        break;

}
