
using Repaso_Guia5;

var libro1 = new Libro("La Odiesea", "Homero", 720);
var libro2 = new Libro("La Voragine", "Jose Eustasio Rivera", 720);
libro1.Prestar();


if(libro1.Prestar())
    Console.WriteLine("Libro prestado Exitosamente");
else
    Console.WriteLine("El libro ya esta prestado");


Console.WriteLine(libro1.Titulo);
Console.WriteLine(libro1.Disponible);

var libro3 = new Libro("Edison del sena", "Jose");

Console.WriteLine(libro1);


//using Repaso_Guia5;

//List<Libro> Repaso_Guia5 =
//    [
//     new Libro("La Odiesea", "Homero", 720),
//     new Libro("La Voragine", "Jose Eustasio Rivera", 320),
//     new Libro("Maria", "Jorge Isaacs", 288)
//    ];
//var disponibles = Repaso_Guia5.Where(l => l.Disponible).ToList();
//var masLargo = Repaso_Guia5.MaxBy(l => l.Paginas);
//Console.WriteLine($"El mas largo es : {masLargo?.Titulo}");
