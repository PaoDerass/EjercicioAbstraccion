
namespace EjercicioAbstraccion
{
    public abstract class Matematicas
    {
        public abstract double potencia(double Base, double exponente);

        public abstract double Logaritmo(double Numero);

        public abstract double Raiz(double Numero);

        public abstract double Exponencial(double Numero);

        public void Imprimir(string Operacion, double resultado)
        {
        Console.WriteLine($"{Operacion}:{resultado}");
}


    }
}
