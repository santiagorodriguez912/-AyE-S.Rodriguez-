int intentosMax = 3;

while (true)
{
    int intentos = intentosMax;

    while (intentos > 0)
    {
        Console.WriteLine("Ingrese un numero ");
        string texto = Console.ReadLine();

        bool valido = true;

        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] < '0' || texto[i] > '9')
                valido = false;
        }

        if (!valido || texto == "")
        {
            intentos--;
            if (intentos > 0)
                Console.WriteLine("no es valido (" + intentos + " intentos restantes)");
            else
                Console.WriteLine("no tiene mas intentos");
        }
        else
        {
            int num = Convert.ToInt32(texto);

            int fact = 1;
            for (int i = 1; i <= num; i++)
                fact *= i;

            Console.WriteLine("Factorial: " + fact);
            break;
        }
    }

    if (intentos == 0)
        break;
}
