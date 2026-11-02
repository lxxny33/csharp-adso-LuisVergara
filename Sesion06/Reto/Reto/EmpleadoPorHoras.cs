
namespace Reto
{
    class EmpleadoPorHoras : Empleado
    {
        public int Horas { get; private set; }
        public decimal ValorHora { get; private set; }

        public override string Tipo => "Empleado por horas";

        public EmpleadoPorHoras(
            string nombre,
            string documento,
            int horas,
            decimal valorHora
        ) : base(nombre, documento)
        {
            Horas = horas;
            ValorHora = valorHora;
        }

        public override decimal CalcularSalario()
        {
            if (Horas > 160)
            {
                decimal horasNormales = 160 * ValorHora;
                decimal horasExtras = (Horas - 160) * ValorHora * 1.5m;

                return horasNormales + horasExtras;
            }

            return Horas * ValorHora;
        }
    }
}
