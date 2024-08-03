using EjercicioAbstraccion;

Procedimiento procedimiento = new Procedimiento();

Console.WriteLine("Ingrese la base y el exponente para calcular la potencia:");
Console.Write("Base: ");
double baseNum = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Exponente: ");
double exp = Convert.ToDouble(Console.ReadLine());
double potencia = procedimiento.Potencia(baseNum, exp); 


Console.WriteLine("Ingrese un número para calcular la raíz cuadrada:");
Console.Write("Número: ");
double num = Convert.ToDouble(Console.ReadLine());
double raiz = procedimiento.Raiz(num); 
procedimiento.Imprimir("Raíz Cuadrada", raiz);


Console.WriteLine("Ingrese un número para calcular el logaritmo :");
Console.Write("Número: ");
double num1 = Convert.ToDouble(Console.ReadLine());
double logaritmo = procedimiento.Logaritmo(num1);
procedimiento.Imprimir("Logaritmo Natural", logaritmo);

Console.WriteLine("Ingrese un número para calcular la función exponencial:");
Console.Write("Número: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double exponencial = procedimiento.Exponencial(num2);
procedimiento.Imprimir("Exponencial", exponencial);

