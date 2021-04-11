using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cordenadas;
            string[] comandos;
            string opcao = "";
            


            while (true);
            {

                Console.WriteLine("Robos dos Brasil 1.0");

                Console.WriteLine();

                Console.WriteLine("Digite P para inserrir a  Posiçao de 'Y' e 'X': ");

                Console.WriteLine("Digite 1 se a face do Robo se encontra para o Sul; ");

                Console.WriteLine("Digite 2 se a face se encontra para o Norte; ");

                Console.WriteLine("Digite 3 se a face se encontra para o Oeste; ");

                Console.WriteLine("Digite 4 se a face se encontra para o Leste; ");

                Console.WriteLine("Digite 'A' Para abortar Comando Digitado!");

                opcao = Console.ReadLine();

                OpcaReturn(opcao);
                return;
                string[] coordenadas;
                {

                    do
                    {
                        Console.WriteLine("Digite a posiçao inicial :");

                        coordenadas = Console.ReadLine().Split(' ');

                        if (coordenadas.Length > 2)
                            Console.WriteLine("Posições inseridas incorretamente!");

                    } while (coordenadas.Length > 2);
                    return;
                }
                double posicao;

                Console.Write("Digite a posição de Y e depois a posiçao de X:   ");
                posicao = Convert.ToDouble(Console.ReadLine());

                double valorPosicao = 0;
                string direcao = "";

                switch (opcao)
                {
                    case "1":
                        valorPosicao = posicao;
                        direcao = "S";
                        break;

                    case "2":
                        valorPosicao = posicao;
                        direcao = "N";
                        break;

                    case "3":
                        valorPosicao = posicao;
                        direcao = "O";
                        break;

                    case "4":
                        valorPosicao = posicao;
                        direcao = "L";
                        break;

                    default:
                        break;
                }

                string posicaoInicial = posicao.ToString() + "" + direcao.ToString() + "=" + valorPosicao.ToString();

                Console.WriteLine(valorPosicao);

                Console.WriteLine();

                Console.WriteLine(posicaoInicial);

                Console.ReadLine();

                return;

                
                var M = 0.1;
                var D = 0;
                var E = 0;
                string codigo = "";
                codigo = opcaodecomando(codigo);
                

                string comando1 = "E+M+E+M+E+M+M";
                String comando2 = "M+M+D+M+M+D+M+D+D+M";

                switch (codigo)
                {

                    case "K":
                        codigo = comando1 + E + M + E + M + E + M + M;

                        break;

                    case "L":
                        codigo = comando2 + M + M + D + M + M + D + M + D + D + M;

                        break;


                }

                string posicaoFinal = codigo + posicaoInicial;
                Console.WriteLine(codigo);

                Console.WriteLine();

                Console.WriteLine(posicaoFinal);

                Console.ReadLine();

                return;
            }






        }

        private static string opcaodecomando(string codigo)
        {
            while (true)
            {


                Console.WriteLine("Digite a Palavra Reservada 'K' para executar seu primeiro comando :");

                Console.WriteLine("Digite a Palavra Reservada 'L' Para Executar seu segundo codigo: ");

                codigo = Console.ReadLine();

                if (codigo == "K" && codigo == "L") ;

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Palavra reservada foi escrita incorretamente");

                Console.ResetColor();

                Console.ReadLine();

                
            }

            return codigo;
        }

        private static void OpcaReturn(string opcao)
        {
            if (opcao != "P" && opcao != "p" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "A" && opcao != "a") ;
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Opção inválida! Tente novamente");

                Console.ResetColor();

                Console.ReadLine();

                Console.Clear();

                return;

            }
        }
    }

}
