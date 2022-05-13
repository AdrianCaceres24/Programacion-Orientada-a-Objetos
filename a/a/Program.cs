using System;

namespace a
{
    internal class Program
    {
    
        /// <param name="bueno"></param>
        static double Pato3(string bueno = "Ingrese un numero: ")
        {
            Console.WriteLine(bueno);
            double inputnumber;
            while (!double.TryParse(Console.ReadLine(), out inputnumber))
            {
                Console.WriteLine();
            }
            return inputnumber;

        }
        static string Pato2(string bueno = "Ingrese un texto: ")
        {
            Console.WriteLine(bueno);
            string Pato = Console.ReadLine();
          
            return Pato;
        }
        static void Main(string[] args)
        {
            string Nombre = Pato2("Ingrese un nombre: ");
            string Apellido = Pato2("Ingrese un apellido:");
            double HoraTrabajo = Pato3("Ingrese Horas Trabajadas:");
            double HoraValor = Pato3("Ingrese valor de hora:");
 
            Console.WriteLine(HoraTrabajo * HoraTrabajo);
             
        }
    }
}
