
class Program
{
    static Random rnd = new Random();

    static void Main()
    {
        string[] pokemones =
        {
            "Bulbasaur","Ivysaur","Venusaur",
            "Charmander","Charmeleon","Charizard",
            "Squirtle","Wartortle","Blastoise",
            "Pikachu","Raichu","Moltres"
        };

        string[] tipos =
        {
            "Grass","Grass","Grass",
            "Fire","Fire","Fire",
            "Water","Water","Water",
            "Electric","Electric","Fire"
        };
  
        string[,] red = CrearEquipo(pokemones, tipos);
        string[,] green = CrearEquipo(pokemones, tipos);
        string[,] blue = CrearEquipo(pokemones, tipos);
        string[,] yellow = CrearEquipo(pokemones, tipos);

        Console.WriteLine("ejercicio 1");
        MostrarEquipo("Red", red);
        MostrarEquipo("Green", green);
        MostrarEquipo("Blue", blue);
        MostrarEquipo("Yellow", yellow);

        Console.WriteLine("batallas");

        string[,] ganador1;
        string nombreGanador1;

        if (SumarNiveles(red) > SumarNiveles(green))
        {
            ganador1 = red;
            nombreGanador1 = "Red";
        }
        else
        {
            ganador1 = green;
            nombreGanador1 = "Green";
        }

        Console.WriteLine("Ganador Red vs Green: " + nombreGanador1);

        string[,] ganador2;
        string nombreGanador2;

        if (SumarNiveles(blue) > SumarNiveles(yellow))
        {
            ganador2 = blue;
            nombreGanador2 = "Blue";
        }
        else
        {
            ganador2 = yellow;
            nombreGanador2 = "Yellow";
        }

        Console.WriteLine("Ganador Blue vs Yellow: " + nombreGanador2);

        Console.WriteLine("Final: ");

        if (SumarNiveles(ganador1) > SumarNiveles(ganador2))
        {
            Console.WriteLine("Campeón: " + nombreGanador1);
            MostrarEquipo(nombreGanador1, ganador1);
        }
        else
        {
            Console.WriteLine("Campeón: " + nombreGanador2);
            MostrarEquipo(nombreGanador2, ganador2);
        }
        Console.WriteLine("ejercicio 2");
        Console.WriteLine("Recursiva");
        MostrarNumeros(50);
    }

    static string[,] CrearEquipo(string[] pokemones, string[] tipos)
    {
        string[,] equipo = new string[6, 3];

        for (int i = 0; i < 6; i++)
        {
            int pos = rnd.Next(pokemones.Length);

            equipo[i, 0] = pokemones[pos];
            equipo[i, 1] = tipos[pos];
            equipo[i, 2] = rnd.Next(50, 81).ToString();
        }

        return equipo;
    }

    static void MostrarEquipo(string nombre, string[,] equipo)
    {
        Console.WriteLine("Equipo " + nombre);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(
                "{" +
                equipo[i, 0] + ", " +
                equipo[i, 1] + ", " +
                equipo[i, 2] + "}"
            );
        }
    }

    static int SumarNiveles(string[,] equipo)
    {
        int suma = 0;

        for (int i = 0; i < 6; i++)
        {
            suma += Convert.ToInt32(equipo[i, 2]);
        }

        return suma;
    }

    static void MostrarNumeros(int numero)
    {
        if (numero < 0)
        {
            return;
        }

        Console.WriteLine(numero);
        MostrarNumeros(numero - 5);
    }
}
