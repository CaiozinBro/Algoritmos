using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decração de Variável
            //Sintaxe: tipoNomeVariável valor
            string nome = "Caio";

            //Reatribuição de vetores
            nome = "Henrique";
            Console.WriteLine(nome);

            //Declaração de Vetores
            //Sintaxe: tipo[] nomeVariavel = {Valor1, Valor2, Valor3}
            string[] nomes = { "Caio", "Henrique", "Garcia", "Maria", "João", "Jessé" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //Loop FOR
            //Sintaxe: for(indice; controle; incremento)
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("{0}° Nome: {1}",i+1, nomes[i]);
            }

            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine("Número: {0}", i);
            
            }

            //Loop foreach
            //Sintaxe: foreach( variavel in vetor)
            foreach (string varNome  in nomes) 
            {
                Console.WriteLine("Nome: {0}",varNome);
            }
        }
    }
}
