using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_calculo_de_perimetro
{
    internal class Circulo : Program // Está herdando as informações da classe "Program"
    {
        public void circu()
        {
            double Pi = 3.14; // Valor de Pi
            double a; // área
            double r; // raio do circulo

            Program calc5 = new Program(); // Herança utilizada para acessar as informações da classe "Program"

            Console.WriteLine("\nInforme o valor do raio do círculo: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            r = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"

            a = Pi * (r * r); // efetua o calculo e encontra o valor da área do circulo

            Console.WriteLine("\n===================================================================================================================");
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine($"|   Calculando o raio do circulo > ({r}) ao quadrado vezes π > ({Pi}) chegamos ao valor da área do circulo > ({a}) |"); // imprime o valor após o calculo
            Console.WriteLine("|                                                                                                                 |");
            Console.WriteLine("===================================================================================================================");
        }
    }
}
