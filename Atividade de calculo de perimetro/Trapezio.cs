using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_calculo_de_perimetro
{
    internal class Trapezio : Program // Está herdando as informações da classe "Program"
    {
        public void Trapez()
        {
            double a; // área
            double b; // Base menor
            double B; // Base maior
            double h; // altura

            Program calc4 = new Program(); // Herança utilizada para acessar as informações da classe "Program"

            Console.WriteLine("\nInforme a base menor do Trapézio que deseja calcular: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            b = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"
            Console.WriteLine("Informe a base maior do Trapézio que deseja calcular: "); // pede um valor para adicionar a conta 
            Console.Write("R: ");
            B = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"
            Console.WriteLine("Informe a altura do Trapézio: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            h = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"
             
            a = ((B + b) * h) / 2; // efetua o calculo e encontra o valor da área do trapezio


            Console.WriteLine("\n=========================================================================================================================================");
            Console.WriteLine("|                                                                                                                                  \t|");
            Console.WriteLine($"|\tCalculando a base menor > ({b}) mais a base maior ({B}) vezes a altura > ({h}) dividido por 2, chegamos ao valor da área que é: {a}\t|"); // imprime o valor após o calculo
            Console.WriteLine("|                                                                                                                                  \t|");
            Console.WriteLine("=========================================================================================================================================");
        }
    }
}
