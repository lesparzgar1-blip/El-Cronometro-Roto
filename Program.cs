//Variables globales del resumen: se acumulan durante toda la ejecucion del programa
int operaciones = 0; // Cuenta cuantas expediciones se han cobrado
double recaudacion = 0; // Suma de los totales finales de todas las expediciones
double importeMasCaro = 0;// Mayor total final registrado hasta ahora
string clienteMasCaro = "";//Responsable de esa expedicion mas cara
bool salir = false;// Bandera que controla el bucle del menu principal

// Bucle del menú principal: se repite hasta que el usuario elige 0 (salir pasa a true)
while (salir == false)
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

// Según la opción: 1 = nueva expedición, 2 = resumen, 0 = salir
switch (opcion)
{
    case 1:
    // Pedir nombre del responsable: se repite mientras se deje vacío
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

// Validar número de participantes: solo se acepta entre 2 y 6
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

// Elegir expedición (1-3): se repite hasta que la opción sea válida
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

// Variables de extras: las banderas evitan contratar el mismo extra dos veces
// cantidadExtra cuenta cuántos se han elegido y precioExtra acumula su coste
    bool ayudaElegida = false;
    bool tiempoElegido = false;
    bool reliquiaElegida = false;
    int cantidadExtra = 0;
    double precioExtra = 0;
    int opcionExtra = -1;

    
    
        Console.Write("Desea añadir una opcion extra para mejorar su aventura (SI /NO)");
        string respuestausuario = Console.ReadLine();

// Si el usuario quiere extras, se muestra el menú de extras hasta que escriba 0
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
            // Si ya está contratado se avisa; si no, se marca, se suma 1 al contador y su precio (5€)
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
            // Igual que el anterior: tiempo adicional (8€), solo una vez
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
            // Igual que el anterior: reliquia del templo (7€), solo una vez
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
            // Termina la selección de extras (el while se corta porque opcionExtra vale 0)
            if (opcionExtra == 0)
            {
                Console.WriteLine("Has terminado de elegir extras");
            }
            break;

            default:
            // Cualquier otro número es inválido y no se añade ningún extra
            Console.WriteLine("Opcion invalida, no se asigna extra");
            break;
            }
            Console.WriteLine($"Extras elegidos: {cantidadExtra}");
            Console.WriteLine($"Importe: {precioExtra}");
            }
        
    } 
    else
    {
        Console.WriteLine("Pues vuestra aventura comenzara en breve");
    }   
    
    // Asignar el nombre y el precio base según la expedición elegida (50€, 55€ o 60€)
    double precioBase = 0 ;
    string nombreExpedicion = "";
    switch (expedicion)
    {
        case 1:
        Console.WriteLine("Expedicio elegido: El Santuario Olvidado");
        precioBase = 50;
        nombreExpedicion = "El Santuario Olvidado";
        Console.WriteLine($"Precio base: {precioBase}");
        break;

        case 2:
        Console.WriteLine("Expedicio elegido: El Templo del Tiempo");
        precioBase = 55;
        nombreExpedicion = "El Templo del Tiempo";
        Console.WriteLine($"Precio base: {precioBase}");
        break;

        case 3:
        Console.WriteLine("Expedicio elegido: La camara de los Sabios");
        precioBase = 60;
        nombreExpedicion = "La camara de los Sabios";
        Console.WriteLine($"Precio base: {precioBase}");
        break;
    }

// Elegir modalidad: Estándar (0€) o Especial (10€), se repite hasta que sea válida
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

    // Subtotal = precio base + extras + modalidad
    double PrecioTotal = precioBase + precioExtra + preciomodalidad;

    // Subtotal = precio base + extras + modalidad
    double descuento = 0;
    if (PrecioTotal >= 70  )
    {
        descuento = PrecioTotal * 0.10;
    }
    double totalFinal = PrecioTotal - descuento;

// Mostrar el desglose del precio antes de cobrar
    Console.WriteLine("---- DESGLOSE ----");
    Console.WriteLine($"Precio base: {precioBase}€");
    Console.WriteLine($"Extras: {precioExtra}€");
    Console.WriteLine($"Modalidad: {preciomodalidad} €");
    Console.WriteLine($"Subtotal:{PrecioTotal} €");
    Console.WriteLine($"Descuento: {descuento} €");
    Console.WriteLine($"TOTAL FINAL: {totalFinal}€");
    Console.WriteLine();

// Cobro: se pide dinero hasta que cubra el total final
    double dineroEntregado = 0;
    while (dineroEntregado < totalFinal)
    {
        Console.WriteLine("Dinero entregado:");
        dineroEntregado = double.Parse(Console.ReadLine());

        if (dineroEntregado < totalFinal )
        {
            Console.WriteLine("ERROR: Falta dinero");
        }
    }
    double cambio = dineroEntregado - totalFinal;

// Actualizar las estadísticas del resumen (nº de operaciones, ingresos y expedición más cara)
    operaciones = operaciones + 1;
    recaudacion = recaudacion + totalFinal;

    if (totalFinal > importeMasCaro)
    {
        importeMasCaro = totalFinal;
        clienteMasCaro = Nombre;
    }
    
// Imprimir el recibo final con todos los datos de la operación
    Console.WriteLine("==== RECIBO ====");
    Console.WriteLine($"Operacion nº: {operaciones} ");
    Console.WriteLine($"Responsable: {Nombre}");
    Console.WriteLine($"Participantes: {numeroparticipantes}");
    Console.WriteLine($"Expedicion: {nombreExpedicion}");
    Console.WriteLine("Extras:");

// Listar los extras contratados; si no hay ninguno, se indica "Ninguno"
    if (cantidadExtra == 0)
    {
        Console.WriteLine("Ninguno");
    }
    if (ayudaElegida)
    {
        Console.WriteLine("Ayuda del explorador");
    }
    if (tiempoElegido)
    {
        Console.WriteLine("Tiempo adicional");
    }
    if (reliquiaElegida)
    {
        Console.WriteLine(" Reliquia elegida ");
    }

    if (modalidad == 1)
    {
        Console.WriteLine($"Modalidad: Estandar ");
    }
    else 
    {
        Console.WriteLine($"Modalidad: Especial ");
    }

        Console.WriteLine("--- DETALLES DEL PAGO ---");
        Console.WriteLine($"Subtotal: {PrecioTotal}€");
        Console.WriteLine($"Descuento: - {descuento}€");
        Console.WriteLine($"Total Final: {totalFinal}€");
        Console.WriteLine($"Dinero entregado: {dineroEntregado}€");
        Console.WriteLine($"Cambio: {cambio}€");

    break;

    case 2:
        Console.WriteLine("==== RESUMEN DE LA ACTIVIDAD ====");

    // Si aún no se ha cobrado ninguna expedición, no hay datos que mostrar
        if (operaciones == 0)
        {
            Console.WriteLine("Todavia no hay actividad");
        }
        else
        {
        // Precio medio = ingresos totales / número de expediciones
            double precioMedio = recaudacion / operaciones;

            Console.WriteLine($"Expediciones realizadas: {operaciones} ");
            Console.WriteLine($"Ingresos totales: {recaudacion} €");
            Console.WriteLine($"Precio medio: {precioMedio} €");
            Console.WriteLine ($"Expedicion mas cara: {importeMasCaro} €");
            Console.WriteLine($"Cliente de la expedicion mas cara: {clienteMasCaro}");
        }
    break;

    case 0:
    // Poner salir a true para que el while termine, y mostrar el resumen final
    salir = true;
    Console.WriteLine("Gracias por visitar El Cronometro Roto");

    Console.WriteLine("Operaciones realizadas: " + operaciones);
    Console.WriteLine("Ingresos totales: " + recaudacion + "€");
    break;

    default:
    // Si la opción no es 0, 1 ni 2, se avisa y el menú se vuelve a mostrar
    Console.WriteLine("Opción de menú inválida.");
    break;

    }
}


