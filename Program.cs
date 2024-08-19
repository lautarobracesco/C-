
    // 12-8-24 Diego calcular cuil m20,f27,empresa30
    int ac = 0, digito, z;
    string sexo, dni;
    short numeroSexo = 0;
    bool boolSexo = false;

    Console.WriteLine("Ingrese su DNI sin puntos: ");

    while (true)
    {
        dni = Console.ReadLine();

        if (dni.Length == 8 && int.TryParse(dni, out _))
        {
            break;
        }

        Console.Clear();
        Console.WriteLine("Error. El DNI tiene que ser 8 números sin puntos.");
        Console.Write("Ingrese su DNI: ");
    }

    do
    {
        Console.Write("Ingrese su sexo Masculino 'M', Femenino 'F', o Empresa 'E': ");
        sexo = Console.ReadLine().ToUpper();
        switch (sexo)
        {

            case "M":
                numeroSexo = 20;
                ac = 10; // 10 + 0
                boolSexo = true;
                break;

            case "F":
                numeroSexo = 27;
                ac = 38; // 10 + 28
                boolSexo = true;
                break;

            case "E":
                numeroSexo = 30;
                ac = 15;
                boolSexo = true;
                break;

            default:

                Console.Clear();
                Console.WriteLine("Error.");
                break;
        }
    }
    while (!boolSexo);
    Console.WriteLine(ac);
    for (int i = 0; i < dni.Length; i++)
    {
        digito = dni[i] - '0';
        Console.WriteLine(digito + "" + i);
        switch (i)
        {
            case 0:
            case 6:
                ac = ac + (digito * 3);
                break;

            case 1:
            case 7:
                ac = ac + (digito * 2);
                break;

            case 2:
                ac = ac + (digito * 7);
                break;

            case 3:
                ac = ac + (digito * 6);
                break;

            case 4:
                ac = ac + (digito * 5);
                break;

            case 5:
                ac = ac + (digito * 4);
                break;
        }
    }

    z = ac / 11;
    ac = ac - (z * 11);
    z = 11 - ac;

    Console.WriteLine("CUIL-CUIT");
    Console.WriteLine(numeroSexo + "-" + dni + "-" + z);


    Console.ReadKey();


