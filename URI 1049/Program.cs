using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo
             * o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido,
             * através das três palavras fornecidas.
             * 
             * Vertebrado - Ave - Carnívoro = Águia
             * Vertebrado - Ave - Onivoro = Pomba
             * Vertebrado - Mamífero - Onivoro = Homem
             * Vertebrado - Mamífero - Herbívoro = Vaca
             * Invertebrado - Inseto - Hematofago = Pulga
             * Invertebrado - Inseto - Herbívoro = Lagarta
             * Invertebrado - Anelídeo - Hematofago = Sanguessuga
             * Invertebrado - Anelídeo - Onivoro = Minhoca
             * 
             * Entrada
             * A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal
             * segundo a figura acima, com todas as letras minúsculas.
             * 
             * Saída
             * Imprima o nome do animal correspondente à entrada fornecida.*/

            string VI = Console.ReadLine();
            string AVIA = Console.ReadLine();
            string COHH = Console.ReadLine();

            if (VI == "vertebrado")
            {
                if (AVIA == "ave")
                {
                    if (COHH == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (COHH == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (AVIA == "mamifero")
                {
                    if (COHH == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (COHH == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            } else if (VI == "invertebrado")
            {
                if (AVIA == "inseto")
                {
                    if (COHH == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (COHH == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (AVIA == "anelideo")
                {
                    if (COHH == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (COHH == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
