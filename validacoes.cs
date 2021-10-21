using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundBra
{
    public static class validacoes
    {

        public static bool emailValido(string email)
        {
            try
            {
                var endEmail = new System.Net.Mail.MailAddress(email);
                return endEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool cpfvalido(string cpf)
        {
            bool cpfvalido = true;

            if(cpf.Length != 11)  //se o a qntd de digitos for diferente de 11, retornará falso
            {
                cpfvalido = false;
            }

            else
            {
                for(int i = 0; i < cpf.Length; i++)  //cpf.Length é a quantidade de numeros, poderia colocar 11 direto
                {
                    if (!Char.IsDigit(cpf[i]))           // laço de repetição que verifica digito por digito para ver se são numeros
                    {
                        cpfvalido = false;
                        break;
                    }
                }
            }

            //verifica se é sequencia, ex: 000000000 ou 9999999999
            if (cpfvalido)
            {
                for (byte i = 0; i < 10; i++)
                {
                    var temp = new string(Convert.ToChar(i), 11);
                    if (cpf == temp)
                    {
                        cpfvalido = false;
                        break;
                    }
                }
            }
            return cpfvalido;
        }

        

    }
}
