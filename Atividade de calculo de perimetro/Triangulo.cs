using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_calculo_de_perimetro
{
    internal class Triangulo : Program // Está herdando as informações da classe "Program"
    {

        public void Triang()
        {
            double a; // área
            double h; // altura
            double b; // base

            Program calc1 = new Program(); // Herança utilizada para acessar as informações da classe "Program"

            Console.WriteLine("\nInforme a base do Triângulo que deseja calcular: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            b = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"
            Console.WriteLine("Informe a altura do Triângulo: "); // pede um valor para adicionar a conta
            Console.Write("R: ");
            h = Convert.ToDouble(Console.ReadLine()); // pega o valor digitado e o converte para "double"

            a = (b * h) / 2; // efetua o calculo e encontra o valor da área do trinagulo

            Console.WriteLine("\n=================================================================================================================");
            Console.WriteLine("|                                                                                                         \t|");
            Console.WriteLine($"|\tCalculando a base > ({b}) vezes a altura ({h}) e dividindo por 2 chegamos ao valor da área que é: {a}\t|"); // imprime o valor após o calculo
            Console.WriteLine("|                                                                                                         \t|");
            Console.WriteLine("=================================================================================================================");
        }
    }
}
