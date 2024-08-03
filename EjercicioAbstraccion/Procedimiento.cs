namespace EjercicioAbstraccion
{
    public class Procedimiento : Matematicas
    {
        public override double Potencia(double baseNum, double Exponente)
        {
            return Math.Pow(baseNum, Exponente);
        }

        public override double Logaritmo(double Numero)
        {
            if (Numero <= 0)
            {
                Console.WriteLine("El logaritmo no está definido");
                return double.NaN;
            }
            return Math.Log(Numero);
        }

        public override double Raiz(double numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("No se puede calcular la raiz");
                return double.NaN;
            }
            return Math.Sqrt(numero);
        }

        public override double Exponencial(double numero)
        {
            return Math.Exp(numero);
        }
    }
}
