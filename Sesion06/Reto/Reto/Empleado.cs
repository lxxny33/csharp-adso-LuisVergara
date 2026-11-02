
namespace Reto
{
    abstract class Empleado
    {
        public string Nombre { get; private set; }
        public string Documento { get; private set; }

        public virtual string Tipo => "Empleado";

        public Empleado(string nombre, string documento)
        {
            Nombre = nombre;
            Documento = documento;
        }

        public abstract decimal CalcularSalario();

        public override string ToString()
        {
            return $"{Tipo} | {Nombre} | Documento: {Documento} | Pago: ${CalcularSalario():N0}";
        }
    }
}
