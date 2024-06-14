using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.IO;

namespace MultiplicaçãoAtravésDeSomasConsecutivas
{
    internal class MultiplicacaoConsecutivas
    {
        public static void Main(string[] args) {
            // Inicializando
            Console.WriteLine("Ola! Qual valor deseja multiplicar");
            // Primeiro Valor que será utilizado como o numero base que ser a multiplicado
            Console.Write("Valor da base que será multiplicada: ");
            int valorBase = Convert.ToInt32(Console.ReadLine());
            // Segundo valor será a quantidade de vezes que o valor vai ser somado até der o resultado
            Console.Write("Valor do multiplicador: ");
            int valorDoMultiplicador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            // Variavies do loop
            int somaTotal = 0;
            int contadorDeSoma = 0;

            // Iniciando loop while
            while (contadorDeSoma < valorDoMultiplicador) {
                somaTotal += valorBase;
                contadorDeSoma++;
            }
            // Resultado após o loop
            Console.Write($"O resultado da é: {somaTotal}");
        }
        }
    }

