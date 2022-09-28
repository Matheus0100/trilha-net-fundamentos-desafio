using DesafioFundamentos.Interfaces;
using System.Text.RegularExpressions;
namespace DesafioFundamentos.Models    
{


    public class RegexPlaca : IRegexPlaca
    {
        public string placa { get; set; }

        // este m�todo verifica se o formato de placa � v�lido e se est� no padr�o mercosul ou no antigo padr�o.
        public bool VerificarPlaca(string placa)
        {
            

            if (string.IsNullOrWhiteSpace(placa))
            {
                return false;
            }

            if (placa.Length != 7) { return false; }
            //Retira o sinal " - " caso houver e retira espa�os em branco.
            placa = placa.Replace("-", "").Trim();

            //Verifica se o caractere na posi��o 4 � uma letra, se sim, aplica a valida��o para o formato de placa do Mercosul,
            //sen�o, aplica a valida��o do formato de placa antigo.

            if (char.IsLetter(placa, 4))
            {
                //Verifica se a placa inserida tem 3 letras, 1 n�mero, 1 letra e 2 n�meros.
                var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");

                return padraoMercosul.IsMatch(placa);
            }
            else
            {
                // Verifica se tem 3 letras e se h� 4 n�meros no final.
                var padraoAntigo = new Regex("[a-zA-Z]{3}[0-9]{4}");

                return padraoAntigo.IsMatch(placa);
            }
        }
    }
}