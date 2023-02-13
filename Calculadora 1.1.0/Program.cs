using System;
using System.Globalization;
using System.Collections.Generic;

namespace Calculadora_1._1._0 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Selecione o tipo de operação a ser realizada: ");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.WriteLine("[sair] Finaliza o programa a qualquer momento");
            Console.WriteLine();
            Console.Write("> ");

            double choice = (double.Parse(Console.ReadLine()));

            List<double> numbers = new List<double>();

            Console.WriteLine("\nDigite um número ou 'sair' para encerrar:");

            while (true) {
                string input = Console.ReadLine();

                if (input.ToLower() == "sair") {
                    break;
                }
                else {
                    numbers.Add(Convert.ToDouble(input));
                }
            }

            double result = numbers[0];

            for (int i = 1; i < numbers.Count; i++) {
                if (choice == 1) {
                    result += numbers[i];
                }
                else if (choice == 2) {
                    result -= numbers[i];
                }
                else if (choice == 3) {
                    result *= numbers[i];
                }
                else if (choice == 4) {
                    result /= numbers[i];
                }
                else {
                    Console.WriteLine("Valor inválido.");
                }
            }

            Console.WriteLine($"\nResultado = {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}