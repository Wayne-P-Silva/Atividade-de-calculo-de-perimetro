using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_calculo_de_perimetro
{
    internal class Retangulo : Program // Está herdando as informações da classe "Program"
    {
        public void Retang()
        {
            double h; // altura
            double a; // área
            double b; // base

            Program calc3 = new Program(); // Herança utilizada para acessar as informações da classe "Program"

            Console.WriteLine("\nInforme a base do Retângulo que deseja calcular: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            b = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"
            Console.WriteLine("Informe a altura do Retângulo: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            h = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"

            a = b * h; // efetua o calculo e encontra o valor da área do retangulo

            Console.WriteLine("\n=========================================================================================");
            Console.WriteLine("|                                                                                   \t|");
            Console.WriteLine($"|\tCalculando a base > ({b}) vezes a altura ({h}) chegamos ao valor da área que é: {a}\t|"); // imprime o valor após o calculo
            Console.WriteLine("|                                                                                   \t|");
            Console.WriteLine("=========================================================================================");
        }
    }
}
