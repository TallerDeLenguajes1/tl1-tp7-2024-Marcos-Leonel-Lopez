namespace Empleados
{
    public class Empleado
    {
        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        private string name;
        private string lastName;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;
        public Empleado(string name, string lastName, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.name = name;
            this.lastName = lastName;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        public TimeSpan antiguedad()
        {
            DateTime Hoy = DateTime.Now;
            TimeSpan antiguedad = Hoy - fechaIngreso;
            return antiguedad;
        }

        public TimeSpan edadEmpleado()
        {
            DateTime Hoy = DateTime.Now;
            TimeSpan edad = Hoy - fechaNacimiento;
            return edad;
        }

        public TimeSpan faltaParaJubilacion()
        {
            DateTime Hoy = DateTime.Now;
            TimeSpan edad = Hoy - fechaNacimiento;
            TimeSpan faltaParaJubilacion = new TimeSpan(65, 0, 0, 0) - edad;
            return faltaParaJubilacion;
        }

        public double Salario()
        {
            int aniosAntiguedad = (int)antiguedad().Days / 360;
            double adicional = 0;
            if (aniosAntiguedad <= 20)
            {
                adicional = sueldoBasico * aniosAntiguedad * 0.01;
            }
            else
            {
                adicional = sueldoBasico * 0.25;
            }
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.50; //
            }
            if (estadoCivil == 'C')
            {
                adicional += 150000d;
            }
            return sueldoBasico + adicional;
        }
        public string MostrarDatos()
        {
            return $"Nombre: {name}\n" +
                   $"Apellido: {lastName}\n" +
                   $"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}\n" +
                   $"Estado Civil: {estadoCivil}\n" +
                   $"Fecha de Ingreso: {fechaIngreso.ToShortDateString()}\n" +
                   $"Sueldo Basico: {sueldoBasico:C}\n" +
                   $"Cargo: {cargo.ToString()}\n";
        }
    }
}