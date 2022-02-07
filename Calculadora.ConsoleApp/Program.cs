using System;

namespace Calculadora.ConsolleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Wake up, Neo... You need to do some math. v1.3");

            do
            {
                do
                {
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                        
                        do
                        {
                            Console.WriteLine("\nDigite 1 para somar");

                            Console.WriteLine("Digite 2 para subtrair");

                            Console.WriteLine("Digite 3 para multiplicar");

                            Console.WriteLine("Digite 4 para dividir\n");
                                                        
                            opcao = Console.ReadLine();
                                                        
                            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("\nDigite uma tecla válida!");

                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4");

                        Console.Write("\nDigite o primeiro número: ");

                        string strPrimeiroNumero = Console.ReadLine();

                        Console.Write("Digite o segundo número: ");

                        string strSegundoNumero = Console.ReadLine();

                        double primeiroNumero = Convert.ToDouble(strPrimeiroNumero);

                        double segundoNumero = Convert.ToDouble(strSegundoNumero);

                        double resultadoOperacao = 0;

                        if (opcao == "1")
                        {
                            resultadoOperacao = primeiroNumero + segundoNumero;
                        }
                        else if (opcao == "2")
                        {
                            resultadoOperacao = primeiroNumero - segundoNumero;
                        }
                        else if (opcao == "3")
                        {
                            resultadoOperacao = primeiroNumero * segundoNumero;
                        }
                        else if (opcao == "4")
                        {
                            if (segundoNumero == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("\nNão tente entortar a colher. É impossível dividir por 0.");

                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                resultadoOperacao = primeiroNumero / segundoNumero;
                            }
                        }
                        if (segundoNumero != 0 || opcao != "4")
                        {
                            Console.Write("Resultado: ");

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine(resultadoOperacao);
                        }

                        Console.ForegroundColor = ConsoleColor.White;

                        do
                        {

                            Console.WriteLine("\nDeseja fazer mais uma operação?");

                            Console.Write("Digite 'Y' para SIM ");

                            Console.Write("ou 'N' para NÃO: ");

                            opcao = Console.ReadLine();

                            if (opcao != "Y" && opcao != "N" && opcao != "y" && opcao != "n")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("\nDigite uma tecla válida!");

                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        } while (opcao != "Y" && opcao != "N" && opcao != "y" && opcao != "n");
                    }
                } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4");
                Console.Clear();
            } while (opcao == "Y" || opcao == "y");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nThe Matrix has you...");

            Console.WriteLine("Follow the white rabbit.");

            Console.ReadLine();
        }
    }
}