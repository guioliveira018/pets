using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacao = 0;
            while (operacao != 4)
            {
                Console.WriteLine("Bem vindo ao Petshop");
                Console.WriteLine("Selecione a opção");
                Console.WriteLine("1°Calcular a medicaçao\n2°Agendamento de banho\n3°Calculo de Alimentaçao\n4°sair");
                int.TryParse(Console.ReadLine(), out operacao);

                if (operacao == 1)
                {
                    Console.WriteLine("Solicitar o peso");
                    int peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("Solicitar a dose");
                    int dose = int.Parse(Console.ReadLine());

                    decimal dosagem = peso * dose;

                    Console.WriteLine($"A dose do medicamento deve ser de: {dosagem}");

                    // Espera o usuário digitar alguma coisa
                    Console.ReadKey();

                    // Limpa a tela
                    Console.Clear();
                }

                if (operacao == 2)
                {
                    Console.WriteLine("Informa o porte do pet");
                    string porte = (Console.ReadLine());
                    Console.WriteLine("Pergunta se que adicionar cuidado extras");
                    string reposta = (Console.ReadLine());
                    decimal total = 0;

                    if (reposta == "sim")
                    {
                        Console.WriteLine("tirar parasitas");
                        string resp = (Console.ReadLine());
                        if (resp == "sim")
                        
                    }
                    
                    
                   
                    
                   

                }
            }
        } 
    }
}
