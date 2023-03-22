using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_calculo_de_perimetro
{
    internal class Quadrado : Program // Está herdando as informações da classe "Program"
    {
        public void Quadra()
        {
            double a; // área
            double l; // lado 

            Program calc2 = new Program(); // Herança utilizada para acessar as informações da classe "Program"

            Console.WriteLine("\nInforme o valor do lado do quadrado que deseja calcular: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            l = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"

            a = l * l; // efetua o calculo e encontra o valor da área do quadrado

            Console.WriteLine("\n===============================================================================");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine($"|    Calculando o lado > ({l}) ao quadrado chegamos ao resultado da área > ({a}) |"); // imprime o valor após o calculo
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("===============================================================================");
        }
    }
}
