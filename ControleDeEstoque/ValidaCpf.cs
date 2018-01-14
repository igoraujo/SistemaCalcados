using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class ValidaCpf
    {
        public bool validarCPF(string CPF)
        {
            int[] pesos1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //para os calculos do primeiro digito verificador 
            int[] pesos2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 }; // para os calculos do segundo digito verificador
            string tempCpf;//variavel de passagem
            string digito;
            int somatorio;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)//se o numero de caracteres digitados na entrada for diferente de 11 retorna "false"
            {
                return false;
            }

            tempCpf = CPF.Substring(0, 9);// Substring- Deve-se passar como parâmetro a posição inicial seguida do número de caracteres que se deve extrar a partir da posição inicial.
            somatorio = 0;

            //verificando o primeiro digito do CPF------------------------------------------
            for (int i = 0; i < 9; i++) // para i menor que 9 somatorio acumula mais o valor da variavel de passagem tempCPF na poscao que o "i" referencia internamente no loop.
            {
                somatorio += Convert.ToInt32(tempCpf[i].ToString()) * pesos1[i];
            }

            resto = somatorio % 11; // resto recebe o modulo de somatorio / 11.
            if (resto < 2)
            {
                resto = 0; // caso resto seja menor que 2, resto recebe 0, conforme as regras matemáticas para valização e cricação de CPF's
            }

            else
            {
                resto = 11 - resto; // senao, o resto recebe, 11 - resto 
            }

            digito = resto.ToString(); // variavel digito recebe o resto
            tempCpf = tempCpf + digito;
            somatorio = 0;

            //verificando o segundo digito do CPF------------------------------------------
            for (int i = 0; i < 10; i++)
            {
                somatorio += Convert.ToInt32(tempCpf[i].ToString()) * pesos2[i];
            }

            resto = somatorio % 11;
            if (resto < 2)
            {
                resto = 0;
            }

            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString(); //seguindo a logica da primeira verificacao de digito, variavel de digito recebe o digito lá de cima mais o digito(resto) calculado no segundo momento.

            return CPF.EndsWith(digito);
        }

    }
}
