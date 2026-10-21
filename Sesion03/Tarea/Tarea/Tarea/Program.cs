
using System;
using System.Text;

Console.Write("Nombre completo: ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Documento: ");
string documento = Console.ReadLine() ?? "";

Console.WriteLine("Usuario generado: " + GenerarUsuario(nombre, documento));
Console.WriteLine();


Console.Write("Escribe una frase: ");
string frase = Console.ReadLine() ?? "";
Console.WriteLine("Cantidad de palabras: " + ContarPalabras(frase));
Console.WriteLine("Frase invertida: " + InvertirPalabras(frase));

static string GenerarUsuario(string nombreCompleto, string documento)
{
    string nombre = nombreCompleto.ToLower();

    nombre = nombre.Replace("á", "a")
                   .Replace("é", "e")
                   .Replace("í", "i")
                   .Replace("ó", "o")
                   .Replace("ú", "u");

    string[] palabras = nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string primerNombre = palabras[0];
    string primerApellido;

    if (palabras.Length == 4)
    {
        primerApellido = palabras[2];
    }
    else
    {
        primerApellido = palabras[1];
    }

    string ultimosDigitos = documento.Substring(documento.Length - 2);

    return primerNombre[0] + primerApellido + ultimosDigitos;
}

static int ContarPalabras(string frase)
{
    string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    return palabras.Length;
}

static string InvertirPalabras(string frase)
{
    string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    StringBuilder resultado = new StringBuilder();

    for (int i = palabras.Length - 1; i >= 0; i--)
    {
        resultado.Append(palabras[i]);

        if (i > 0)
        {
            resultado.Append(" ");
        }
    }

    return resultado.ToString();
}
