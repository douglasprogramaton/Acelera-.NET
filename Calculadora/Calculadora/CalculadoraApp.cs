using System;

namespace Calculadora
{
    // Definição da classe CalculadoraApp
    class CalculadoraApp
    {
        private char calcula; // Variável privada para controlar a repetição do menu

        // Método público responsável por iniciar a execução do aplicativo
        public void Executar()
        {
            // Loop principal para permitir que o usuário faça vários cálculos consecutivos
            do
            {
                MostrarMenu(); // Chama o método para exibir o menu de opções
                int opcao = Convert.ToInt32(Console.ReadLine()); // Lê a opção escolhida pelo usuário como um número inteiro

                // Estrutura de switch para lidar com diferentes opções do menu
                switch (opcao)
                {
                    case 1:
                        CalculadoraMedia calculadoraMedia = new CalculadoraMedia(); // Cria uma instância da CalculadoraMedia
                        calculadoraMedia.CalcularMedia(); // Chama o método para calcular a média
                        break;
                    case 2:
                        CalculadoraIMC calculadoraIMC = new CalculadoraIMC(); // Cria uma instância da CalculadoraIMC
                        calculadoraIMC.CalcularIMC(); // Chama o método para calcular o IMC
                        break;
                    default:
                        Console.WriteLine("Opção inválida!"); // Mensagem para opção inválida
                        break;
                }

                Console.Write("Deseja fazer outro cálculo? (S/N) ");
                calcula = char.ToUpper(Convert.ToChar(Console.ReadLine())); // Lê a resposta do usuário e converte para maiúscula

            } while (calcula == 'S'); // Continua o loop se a resposta for 'S'

            Console.WriteLine("Obrigado por usar a Calculadora Mega Ultra 2.0! Até mais!");
        }

        // Método privado para mostrar o menu de opções
        private void MostrarMenu()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**        CALCULADORA MEGA ULTRA 2.0         **");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**   Seja bem vindos amigos do ACELERA.NET   **");
            Console.WriteLine("***********************************************");
            Console.WriteLine("");
            Console.WriteLine("Escolha o cálculo que deseja:");
            Console.WriteLine("");
            Console.WriteLine("1 - CALCULAR MÉDIA DE NOTAS");
            Console.WriteLine("2 - CALCULAR IMC");
            Console.WriteLine("");
            Console.Write("Opção: ");
        }
    }
}