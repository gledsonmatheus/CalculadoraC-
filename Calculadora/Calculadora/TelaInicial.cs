using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora
{
    public class telainicial
    {
        static void Main(string[] args)
        {
            Calculos calc = new Calculos();
            String escolha = "n";
            int operacao = 0;
            int primeiroValor = 0;
            int segundoValor = 0;
            double resultado = 0;

            Console.WriteLine("deseja fazer alguma operaçao? (S/N) ");
            escolha = Console.ReadLine();

            if (escolha.ToLower() == "s")
            {
                Boolean continuar = true;
                while (continuar) {
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("digite o primeiro valor (inteiro)");
                        primeiroValor = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite o segundo valor (inteiro)");
                        segundoValor = int.Parse(Console.ReadLine());


                        Console.WriteLine("digite a opção da operaçao desejada  ");
                        Console.WriteLine("(1) Soma  ");
                        Console.WriteLine("(2) Subtração  ");
                        Console.WriteLine("(3) divisão  ");
                        Console.WriteLine("(4) Multiplicação  ");
                        operacao = int.Parse(Console.ReadLine());

                        switch (operacao)
                        {
                            case 1:
                                resultado = calc.soma(primeiroValor, segundoValor);
                                break;
                            case 2:
                                resultado = calc.subtracao(primeiroValor, segundoValor);
                                break;
                            case 3:
                                resultado = calc.divisao(primeiroValor, segundoValor);
                                break;
                            case 4:
                                resultado = calc.multiplicao(primeiroValor, segundoValor);
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("O resultado da operação é : " + resultado);

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("ouve uma tentativa de dividir por 0, por favor tente novamente e use números validos. ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ocorreu um erro tente novamente");
                    }
                    finally
                    {
                        Console.WriteLine(" deseja fazer algum calculo (S/N)");
                        escolha = Console.ReadLine();
                        if (escolha.ToLower() == "s") { continuar = true; } else { continuar = false; }
                    }

                }
               

            }
            
                Console.WriteLine("Para encerrar digite qualquer tecla");
                Console.ReadKey();
            

        }
    }
}
