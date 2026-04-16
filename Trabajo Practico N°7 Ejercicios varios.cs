
        Console.WriteLine("hola dame un numero entero");
        int animal = Convert.ToInt32(Console.ReadLine());
        bool primo = true;
        if (animal <= 1)
        {
            primo = false;
            Console.WriteLine("no es primo");
        }
        else
        {
            for (int agus = 2; agus < animal; agus++)
            {
                if (animal % agus == 0)
                {
                    primo = false;
                }
            }
        }
        if (primo == true)
        {
            Console.WriteLine(animal + " es primo");
        }
        else
        {
            Console.WriteLine(animal + " no es primo");
        }

        Console.WriteLine("ingrese un numero para generar la factorial");
        int manteca = Convert.ToInt32(Console.ReadLine());

        int xd = 1;
        for (int calampa = 1; calampa <= manteca; calampa++)
        {
            xd = xd * calampa;
        }
        Console.WriteLine("el factorial de tu numero es: " + xd);


        Console.WriteLine("ingrese un numero");

        int n = Convert.ToInt32(Console.ReadLine());
        int fibonacci;
        int pt = 0;
        int st = 1;

        for (int a = 0; a < n; a++)
        {
            Console.WriteLine(pt);
            if (st > n)
            {
                break;
            }
            fibonacci = pt;
            pt = st;
            st = fibonacci + pt;
        }



        Console.WriteLine("menú interactivo");
        Console.WriteLine("ingrese 1 para decir hola");
        Console.WriteLine("ingrese 2 para decir chau");
        Console.WriteLine("ingrese 3 para terminar el programa");

        int asd = Convert.ToInt16(Console.ReadLine());
        switch (asd)
        {
            case 1:
                Console.WriteLine("hola");
                break;
            case 2:
                Console.WriteLine("chau");
                break;
           default:
        break;

        }
    