using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenesysGym
{
    public class ClassValidacao
    {
        public static bool validarCpf(string cpf)
        {
            int[] digito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] digito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string armazenarCpf = "";
            string digito;
            int soma;
            int resto;
            int i;

            if (cpf.Length != 11)
            {
                cpf = cpf.Trim();
                cpf = cpf.Replace(",", "").Replace("-", "");
                armazenarCpf = cpf.Substring(0, 11);
            }
            if ((cpf != "00000000000") && (cpf != "11111111111") && (cpf != "22222222222") && (cpf != "33333333333") && (cpf != "44444444444") && (cpf != "55555555555") && (cpf != "77777777777") && (cpf != "88888888888") && (cpf != "99999999999"))
            {
                //digito 1
                soma = 0;
                for (i = 0; i < 9; i++)
                {
                    soma += int.Parse(armazenarCpf[i].ToString()) * digito1[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();
                armazenarCpf = armazenarCpf + digito;

                //digito2
                soma = 0;
                for (i = 0; i < 10; i++)
                {
                    soma += int.Parse(armazenarCpf[i].ToString()) * digito2[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();
                armazenarCpf = armazenarCpf + digito;

                return cpf.EndsWith(digito);
            }
            else
            {
                return false;
            }
        }
        public static bool validarRg(string rg)
        {
            //Elimina da string os traços, pontos e virgulas,
            rg = rg.Replace("-", "").Replace(".", "").Replace(",", "");

            //Verifica se o tamanho da string é 9
            if (rg.Length == 9)
            {
                int[] n = new int[9];

                try
                {
                    n[0] = Convert.ToInt32(rg.Substring(0, 1));
                    n[1] = Convert.ToInt32(rg.Substring(1, 1));
                    n[2] = Convert.ToInt32(rg.Substring(2, 1));
                    n[3] = Convert.ToInt32(rg.Substring(3, 1));
                    n[4] = Convert.ToInt32(rg.Substring(4, 1));
                    n[5] = Convert.ToInt32(rg.Substring(5, 1));
                    n[6] = Convert.ToInt32(rg.Substring(6, 1));
                    n[7] = Convert.ToInt32(rg.Substring(7, 1));
                    if (rg.Substring(8, 1).Equals("x") || rg.Substring(8, 1).Equals("X"))
                    {
                        n[8] = 10;
                    }
                    else
                    {
                        n[8] = Convert.ToInt32(rg.Substring(8, 1));
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                //obtém cada um dos caracteres do rg

                //Aplica a regra de validação do RG, multiplicando cada digito por valores pré-determinados
                n[0] *= 2;
                n[1] *= 3;
                n[2] *= 4;
                n[3] *= 5;
                n[4] *= 6;
                n[5] *= 7;
                n[6] *= 8;
                n[7] *= 9;
                n[8] *= 100;

                //Valida o RG
                int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7] + n[8];
                if ((somaFinal % 11) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
