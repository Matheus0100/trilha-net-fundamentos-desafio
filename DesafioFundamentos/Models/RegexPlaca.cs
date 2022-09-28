using DesafioFundamentos.Interfaces;
using System.Text.RegularExpressions;
namespace DesafioFundamentos.Models    
{


    public class RegexPlaca : IRegexPlaca
    {
        public string placa { get; set; }

        // este método verifica se o formato de placa é válido e se está no padrão mercosul ou no antigo padrão.
        public bool VerificarPlaca(string placa)
        {
            

            if (string.IsNullOrWhiteSpace(placa))
            {
                return false;
            }

            if (placa.Length != 7) { return false; }
            //Retira o sinal " - " caso houver e retira espaços em branco.
            placa = placa.Replace("-", "").Trim();

            //Verifica se o caractere na posição 4 é uma letra, se sim, aplica a validação para o formato de placa do Mercosul,
            //senão, aplica a validação do formato de placa antigo.

            if (char.IsLetter(placa, 4))
            {
                //Verifica se a placa inserida tem 3 letras, 1 número, 1 letra e 2 números.
                var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");

                return padraoMercosul.IsMatch(placa);
            }
            else
            {
                // Verifica se tem 3 letras e se há 4 números no final.
                var padraoAntigo = new Regex("[a-zA-Z]{3}[0-9]{4}");

                return padraoAntigo.IsMatch(placa);
            }
        }
    }
}