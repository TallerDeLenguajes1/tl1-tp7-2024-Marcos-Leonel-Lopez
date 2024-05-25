namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato = 0;
        public double resultado { get => dato; }

        public void Suma(double num1)
        {
            dato = num1 + dato;
        }
        public void Resta(double num1)
        {
            dato = dato - num1;
        }
        public void Multiplicacion(double num1)
        {
            dato = num1 * dato;
        }
        public void Division(double num1)
        {
            if (num1 != 0)
            {
                dato = dato / num1;
            }
            Console.WriteLine("No se puede dividir por 0");
        }
        public void Limpiar()
        {
            dato = 0;
        }
    }
}
