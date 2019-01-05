using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Caixa
    {
        private readonly int[] notas = { 100, 50, 20, 10, 5, 2 };

        public int[] Qtds { get; private set; } = { 0, 0, 0, 0, 0, 0 };

        public string Sacar(int valor)
        {
            string result = "";
            if (valor > 1)
            {
                int i = 0;
                int valorcopy = valor;
                foreach (int nota in notas)
                {

                    if (nota <= valor)
                    {
                        Qtds[i] = valor / nota;
                        valor = valor % nota;
                        result += Qtds[i] + " notas(s) de " + nota + "\n";
                    }
                    i++;

                    if (valor == 0)
                    {
                        result = $"Saque de {valorcopy}R$ realizado com sucesso:\n\n" + result;
                        break;
                    }

                    if (valor == 1)
                    {
                        result = $"Apenas foi possivel realizar o saque de {valorcopy - 1}R$ :\n\n" + result;
                        break;
                    }
                }
            }
            else
            {
                result = "Não foi possivel realizar saque, valor indisponivel";
            }

            return result;
        }
    }
}
