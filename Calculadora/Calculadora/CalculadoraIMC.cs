using System;
namespace Calculadora
{
   
    class CalculadoraIMC
    {
        // Método público para calcular o IMC
        public void CalcularIMC()
        {
            // Solicita ao usuário que digite o nome
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            // Solicita ao usuário que digite o peso em quilogramas
            Console.Write("Digite o peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            // Solicita ao usuário que digite a altura em centímetros
            Console.Write("Digite a altura (cm): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcula o IMC usando a fórmula IMC = peso / altura^2
            double IMC = peso / Math.Pow(altura / 100, 2);

            // Exibe uma linha em branco
            Console.WriteLine("");

            // Exibe o IMC formatado com duas casas decimais e o nome da pessoa
            Console.WriteLine($"O IMC de {nome} é: {IMC.ToString("F2")}");

            // Exibe a classificação do IMC usando o método ClassificaIMC
            Console.WriteLine("Classificação: " + ClassificaIMC(IMC));
        }

        // Método privado para classificar o IMC em categorias
        private string ClassificaIMC(double iMC)
        {
            string classificacao;

            // Lógica de classificação com base nos valores do IMC
            if (iMC < 18.5)
                classificacao = "MAGREZA";
            else if (iMC < 25.0)
                classificacao = "NORMAL";
            else if (iMC < 30.0)
                classificacao = "SOBREPESO";
            else if (iMC < 40.0)
                classificacao = "OBESIDADE";
            else
                classificacao = "OBESIDADE GRAVE";

            // Retorna a classificação
            return classificacao;
        }
    }
}
