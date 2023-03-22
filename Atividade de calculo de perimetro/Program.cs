using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_de_calculo_de_perimetro
{
    internal class Program
    {
        private double h; // altura
        private double b; // base
        private double a; // área

        public double H // Utilizado como mediador para que o resto do código possa acessar o atributo privado
        {
            get { return h; } // pega o valor
            set { h = value; } // atribui o valor
        }
        public double B
        {
            get { return b; } //pega o valor
            set { b = value; } // atribui o valor
        }
        public double A
        {
            get { return a; } //pega o valor
            set { a = value; } // atribui o valor
        }
        static void Main(string[] args) // Utilizado para rodar o programa
        {
            int escolha; // variavel de escolha para efetuar o switch com case

            Console.WriteLine("\nQual calculo deseja efetuar? ");
            Console.WriteLine("\n=================================");
            Console.WriteLine("|\t1 > Triângulo\t\t|");
            Console.WriteLine("|\t2 > Quadrado\t\t|");
            Console.WriteLine("|\t3 > Retângulo\t\t|");
            Console.WriteLine("|\t4 > Trapézio\t\t|");
            Console.WriteLine("|\t5 > Círculo\t\t|");
            Console.WriteLine("=================================");
            Console.Write("\n\tR:");
            escolha = Convert.ToInt32(Console.ReadLine());
            if (escolha == 1 || escolha == 2 || escolha == 3 || escolha == 4 || escolha == 5 || escolha == 0)
            {
                switch (escolha)
                {
                    case 1:
                        Triangulo calc1 = new Triangulo(); // Herança utilizada para acessar as informações da classe "Triangulo"

                        calc1.Triang(); // Utilizado para realizar o processo da colheta dos valores e efetuar o calculo pedido e assim imprimir o resultado

                        break;
                    case 2:
                        Quadrado calc2 = new Quadrado(); // Herança utilizada para acessar as informações da classe "Quadrado"

                        calc2.Quadra(); // Utilizado para realizar o processo da colheta dos valores e efetuar o calculo pedido e assim imprimir o resultado

                        break;
                    case 3:
                        Retangulo calc3 = new Retangulo(); // Herança utilizada para acessar as informações da classe "Retangulo"

                        calc3.Retang(); // Utilizado para realizar o processo da colheta dos valores e efetuar o calculo pedido e assim imprimir o resultado

                        break;
                    case 4:
                        Trapezio calc4 = new Trapezio(); // Herança utilizada para acessar as informações da classe "Trapezio"

                        calc4.Trapez(); // Utilizado para realizar o processo da colheta dos valores e efetuar o calculo pedido e assim imprimir o resultado

                        break;
                    case 5:
                        Circulo calc5 = new Circulo(); // Herança utilizada para acessar as informações da classe "Circulo"

                        calc5.circu(); // Utilizado para realizar o processo da colheta dos valores e efetuar o calculo pedido e assim imprimir o resultado

                        break;
                    case 0:  // Case utilizado para caso o úsuario resolva não escolher sair
                        Console.Clear();
                        Console.WriteLine($"Adeus, tenha um bom dia.");
                        break;
                }
            }
        }
    }
}
