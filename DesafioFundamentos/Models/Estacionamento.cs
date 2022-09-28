using System;
using DesafioFundamentos.Interfaces;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        //objeto
        RegexPlaca RegexPlacaVeiculo = new RegexPlaca();
        //variáveis
        public string placa;
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private int vagas = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora, int vagas)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.vagas = vagas;

        }
        
        public void AdicionarVeiculo()
        {
            // Implementado!
            
            bool placaReal;
            // Verificar se há vagas
            if(veiculos.Count >= vagas)
            {
                Console.WriteLine($"O estacionamento não tem vagas :(");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else { 
                //****** loop para validar a placa *******//
            do
            {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            placaReal= RegexPlacaVeiculo.VerificarPlaca(placa);

                if (placaReal)
                {
                    veiculos.Add(placa);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Placa Inválida, por favor, digite uma placa válida.");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                }

            }while(placaReal == false);
            // ********** Fim loop ********** //
            
            }
        }

        public void RemoverVeiculo()
    {
            if (veiculos.Any())
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Implementado!

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
           
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");     
                    
                // Implementado!
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Implementado!

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
    }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implementado!
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
