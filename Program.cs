while (true)
{

Console.WriteLine("=========================");
Console.WriteLine("    EL CRONOMETRO ROTO   ");
Console.WriteLine("=========================");

Console.WriteLine("MENU PRINCIPAL");
Console.WriteLine("1.Nueva expedicion");
Console.WriteLine("2.Resumen de actividad");
Console.WriteLine("0.Salir");

Console.Write("¿Que opcion escogera?");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
    string Nombre = "";
    while (Nombre == "")
    {
    Console.Write("Nombre del participante:");
    Nombre = Console.ReadLine();
    if (Nombre == "")
    {
        Console.WriteLine("No se ha escrito nada");
    }

    }
    int numeroparticipantes = 0;
    while (numeroparticipantes < 2 || numeroparticipantes > 6)
    {
    Console.Write("Numero de participantes (2-6):");
    numeroparticipantes = int.Parse(Console.ReadLine());
    if (numeroparticipantes >= 2 && numeroparticipantes <= 6)
    {
        Console.WriteLine("Registro completado de los participantes");
    }
    else
    {
        Console.WriteLine("ERROR:Numero de participantes inconrrecto");
    }
    }
    
    int expedicion = 0;

    while(expedicion < 1 || expedicion > 3)
    {
    Console.WriteLine("==== ELIGE TU EXPEDICION ====");
    Console.WriteLine("1. El Santuario Olvidado - 50€ ");
    Console.WriteLine("2. El Templo del Tiempo - 55 € ");
    Console.WriteLine("3. La camara de los Sabios - 60€ ");

    Console.Write("Seleccione su expedicion:");
    expedicion = int.Parse(Console.ReadLine().ToUpper());

    if(expedicion >= 1 && expedicion <= 3)
    {
        Console.WriteLine("Expedicion elegida");
    }
    else
    {
        Console.WriteLine("ERROR: Se ha equivocado con la aventura");
    }
    }

    bool ayudaElegida = false;
    bool tiempoElegido = false;
    bool reliquiaElegida = false;
    int cantidadExtra = 0;
    double precioExtra = 0;
    int opcionExtra = -1;

    
    
        Console.Write("Desea añadir una opcion extra para mejorar su aventura (SI /NO)");
        string respuestausuario = Console.ReadLine();

    if (respuestausuario?.ToUpper() == "SI")
    {
        while(opcionExtra != 0)
        {
            Console.WriteLine("==== DESEA ELEGIR ALGUN EXTRA PARA SU AVENTURA ===");
            Console.WriteLine("1. Ayuda del explorador - 5€ ");
            Console.WriteLine("2. Tiempo adicional - 8€ ");
            Console.WriteLine("3. Reliquia del templo - 7€ ");
            Console.WriteLine("0.Terminar");

        Console.Write("Seleccione su extra:");
        opcionExtra = int.Parse(Console.ReadLine());
        switch (opcionExtra)
        {
            case 1:
            if (ayudaElegida)
            {
                Console.WriteLine("Ya has contratado este servicio");
            }
            else 
            {
                ayudaElegida = true;
                cantidadExtra++;
                precioExtra = precioExtra + 5;
                
            }
            break;
            
            case 2:
            if(tiempoElegido)
            {
                Console.WriteLine("Ya has contratado este servicio");
            }
            else
            {
                tiempoElegido = true;
                cantidadExtra++;
                precioExtra = precioExtra + 8;
            }
            break;

            case 3:
            if (reliquiaElegida)
            {
                Console.WriteLine("Ya has contratado este servicio");
            }
            else
            {
                reliquiaElegida = true;
                cantidadExtra++;
                precioExtra = precioExtra + 7;

            }
            break;

            case 0:
            if (opcionExtra == 0)
            {
                Console.WriteLine("Has terminado de elegir extras");
            }
            break;

            default:
            Console.WriteLine("Opcion invalida, no se asigna extra");
            break;
            }
            }
        
    } 
    else
    {
        Console.WriteLine("Pues vuestra aventura comenzara en breve");
    }   
    
    double precioBase = 0 ;
    switch (expedicion)
    {
        case 1:
        Console.WriteLine("Expedicio elegido: El Santuario Olvidado");
        precioBase = 50;
        Console.WriteLine($"Precio base: {precioBase}");
        break;

        case 2:
        Console.WriteLine("Expedicio elegido: El Templo del Tiempo");
        precioBase = 55;
        Console.WriteLine($"Precio base: {precioBase}");
        break;

        case 3:
        Console.WriteLine("Expedicio elegido: La camara de los Sabios");
        precioBase = 60;
        Console.WriteLine($"Precio base: {precioBase}");
        break;
    }

    int modalidad = 0 ;
    double preciomodalidad = 0;

    Console.WriteLine("---- MODALIDADES ----");
    Console.WriteLine("1.Estandar - 0€");
    Console.WriteLine("2.Especial - 10€");

    
    while (modalidad < 1 || modalidad > 2)
    {
    Console.Write("¿Que modalidad desea hacer:");
    modalidad = int.Parse(Console.ReadLine());

        if (modalidad == 1)
        {
            preciomodalidad = 0;
        }
        else if (modalidad == 2)
        {
            preciomodalidad = 10;
        }
        else{
            Console.WriteLine("ERROR:modalidad no existen");
        }
    }
    double PrecioTotal = precioBase + precioExtra + preciomodalidad;
    Console.WriteLine($"Total: {PrecioTotal}");

    

    break;
    case 2:
        Console.WriteLine("==== RESUMEN DE LA ACTIVIDAD");

    break;

    case 0:
    Console.WriteLine("Gracias por visitar El Cronometro Roto");
    break;

    default:
    Console.WriteLine("Opción de menú inválida.");
    break;

    }
}


