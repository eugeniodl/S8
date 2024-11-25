

bool continueProgram = true;

while (continueProgram)
{
    Console.Clear();
    Console.WriteLine("Seleccione el tipo de dato:");
    Console.WriteLine("1 - Entero");
    Console.WriteLine("2 - Cadena");
    Console.WriteLine("3 - Salir");

    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            HandleInteger();
            break;
        case "2":
            HandleString();
            break;
        case "3":
            continueProgram = false;
            Console.WriteLine("Gracias por usar el programa.");
            break;
        default:
            Console.WriteLine("Opción Inválida");
            break;
    }

    if(continueProgram)
    {
        Console.WriteLine("\n¿Desea repetir el proceso? (S/N)");
        string repeat = Console.ReadLine();
        if(repeat.ToUpper() != "S")
        {
            continueProgram = false;
            Console.WriteLine("Gracias por usar el programa.");
        }
    }
}

void HandleString()
{
    Console.WriteLine("Introduzca una cadena de texto:");
    string stringInput = Console.ReadLine();

    GenericClass<string> stringInstance = new GenericClass<string>(stringInput);
    Console.WriteLine($"Valor almacenado: {stringInstance.GetValue()}");
}

void HandleInteger()
{
    Console.WriteLine("Introduza un número entero:");
    string intInput = Console.ReadLine();

    // Validación del valor ingresado
    if(int.TryParse(intInput, out int intResult))
    {
        GenericClass<int> intInstance = new GenericClass<int>(intResult);
        Console.WriteLine($"Valor almacenado: {intInstance.GetValue()}");
    }
    else
    {
        Console.WriteLine("Entrada inválida. Debe ser un número entero.");
    }
}