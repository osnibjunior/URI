using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            /**A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer
             * uma estatística do resultado de vários GRENAIS. Escreva um programa para ler o
             * número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever
             * a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1,
             * o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos
             * times em uma nova partida, caso contrário deve ser encerrado imprimindo:
             * 
             * - Quantos GRENAIS fizeram parte da estatística.
             * - O número de vitórias do Inter.
             * - O número de vitórias do Grêmio.
             * - O número de Empates.
             * - Uma mensagem indicando qual o time que venceu o maior número de GRENAIS
             * (ou "Nao houve vencedor", caso termine empatado).
             * 
             * Entrada
             * O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados
             * pelo Inter e pelo Grêmio respectivamente. Em seguida háverá um inteiro (1 ou 2),
             * correspondente à repetição do programa.
             * 
             * Saída
             * Após cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)".
             * Quando o algoritmo for encerrado devem ser mostradas as estatísticas conforme a descrição
             * apresentada acima. Obs: a palavra "Gremio" deve ser impressa sem acento, conforme o exemplo abaixo.*/

            int inter, vInter = 0, gremio, vGremio = 0, empate = 0, opcao, grenal = 0;

            string[] valores = Console.ReadLine().Split(' ');
            inter = int.Parse(valores[0]);
            gremio = int.Parse(valores[1]);
            grenal++;

            //Adiciona os valores de vitória para as variáveis do Gremio, Inter ou Empate, será usada no final para imprimir o valor
            if (inter == gremio)
            {
                empate++;
            } else if (inter > gremio)
            {
                vInter++;
            } else
            {
                vGremio++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            opcao = int.Parse(Console.ReadLine());

            while(opcao == 1)
            {
                valores = Console.ReadLine().Split(' ');
                inter = int.Parse(valores[0]);
                gremio = int.Parse(valores[1]);

                grenal++;

                if (inter == gremio)
                {
                    empate++;
                }
                else if (inter > gremio)
                {
                    vInter++;
                }
                else
                {
                    vGremio++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(grenal + " grenais");
            Console.WriteLine("Inter:"+vInter);
            Console.WriteLine("Gremio:"+vGremio);
            Console.WriteLine("Empates:"+empate);
            
            //Verifica qual o time que mais venceu o GreNal e imprime a mensagem correspondente na tela
            if (vInter > vGremio && vInter > empate)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                if (vGremio > empate)
                {
                    Console.WriteLine("Gremio venceu mais");
                }
                else
                {
                    Console.WriteLine("Nao houve vencedor");
                }
            }
        }
    }
}
