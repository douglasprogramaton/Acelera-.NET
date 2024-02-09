using System;


namespace Calculadora
{
    // Classe responsável por calcular a média e verificar a aprovação do aluno
    class CalculadoraMedia
    {
        // Método público para calcular a média e exibir o resultado
        public void CalcularMedia()
        {
            // Declaração de um array de doubles para armazenar as notas
            double[] notas = new double[3];

            // Solicita e armazena a primeira nota
            Console.WriteLine("Digite a primeira nota:");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            // Solicita e armazena a segunda nota
            Console.WriteLine("Digite a segunda nota:");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            // Solicita e armazena a terceira nota
            Console.WriteLine("Digite a terceira nota:");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            // Calcula a média das notas
            double media = (notas[0] + notas[1] + notas[2]) / 3;

            // Exibe a situação do aluno (aprovado, recuperação ou reprovado) e a média
            Console.WriteLine("O aluno foi " + VerificaAprovacao(media));
            Console.WriteLine("Média: " + media);
        }

        // Método privado que verifica a aprovação com base na média
        private string VerificaAprovacao(double media)
        {
            // Variável para armazenar o resultado da verificação
            string resultado;

            // Verifica se a média é menor que 5, situação de reprovação
            if (media < 5)
                resultado = "REPROVADO";
            // Verifica se a média é menor que 7, situação de recuperação
            else if (media < 7)
                resultado = "RECUPERAÇÃO";
            // Se não, o aluno está aprovado
            else
                resultado = "APROVADO";

            // Retorna o resultado da verificação
            return resultado;
        }
    }
}
