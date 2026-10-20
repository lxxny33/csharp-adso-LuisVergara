using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;
string contrasena;
int nivel;
do
{
    Console.WriteLine("Contraseña: ");
    contrasena = Console.ReadLine() ?? "";
    nivel = EvaluarContrasena(contrasena);

    if (nivel == 6)
    {
        Console.WriteLine($"Nivel fuerte: ({nivel}/6)");
    }
    else if (nivel >= 4)
    {
        Console.WriteLine($"Nivel Media: ({nivel}/6)");
    }
    else
    {
        Console.WriteLine($"Nivel Debil: ({nivel}/6)");
    }
    if (nivel < 6)
    {
        Console.WriteLine("Intenta nuevamente");
    }
} while (nivel < 6);
static int EvaluarContrasena(string contrasena)
{
     int nivel = 0;

     bool minimo = contrasena.Length >= 8;
     bool mayuscula = false;
     bool minuscula = false;
     bool numero = false;
     bool especial = false;
     bool sinEspacios = true;
        
     foreach( char c in contrasena)
     {
        if (char.IsUpper(c))
            mayuscula = true;
        else if (char.IsLower(c))
            minuscula = true;
        else if (char.IsDigit(c))
            numero = true;
        else if (char.IsWhiteSpace(c))
            sinEspacios = false;
        else if (char.IsPunctuation(c) || char.IsSymbol(c))
            especial = true;
     }
    if (minimo)
    {
        Console.WriteLine("✔️ Minimo 8 caracteres");
        nivel++;
    }
    else
        Console.WriteLine("✘ Minimo 8 caracteres");
    if (mayuscula)
    {
        Console.WriteLine("✔️ Una mayuscula");
        nivel++;
    }
    else
        Console.WriteLine("✘ Minimo una mayuscula");
    if (minuscula)
    {
        Console.WriteLine("✔️ Una minuscula");
        nivel++;
    }
    else
        Console.WriteLine("✘ Minimo una minuscula");
    if (numero)
    {
        Console.WriteLine("✔️ Un numero");
        nivel++;
    }
    else
        Console.WriteLine("✘ Un numero");
    if (especial)
    {
        Console.WriteLine("✔️ Un caracter especial");
        nivel++;
    }
    else
        Console.WriteLine("✘ Por lo menos un caracter especial");
    if (sinEspacios)
    {
        Console.WriteLine("✔️ Sin espacios");
        nivel++;
    }
    else
        Console.WriteLine("✘ Sin espacios");
    return nivel;
}


