using Useif.models;

namespace Useif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // decir si es niño, joven o adulto
            int edad = 0;

            Evaluate evaluare = new Evaluate();

            Console.WriteLine("Evaluar edad");
            Console.Write("Ingrese su edad: ");
            try
            {
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(evaluare.EvalAge(edad));
            }
            catch (Exception)
            {
                Console.WriteLine("Edad no válida");
            }
        }
    }
}
