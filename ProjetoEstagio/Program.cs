using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace ProjetoEstagio
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamReader leitor = new StreamReader("Prova Estagio DEV - Anexo 1.txt");
            // string lido = leitor.ReadLine();

            string[] linhas1 = File.ReadAllText("Prova Estagio DEV - Anexo 1.txt").Split('\n', ';'); // Transformar o txt em um array do tipo string dividido pelas linhas e ';'.
            List<string> linhas = new List<string>();

            for(int i = 0; i < linhas1.Length; i++) // Estrutura de repetição feita para percorrer todo o array e adicionar os nomes da categoria '1' em uma lista separada.
            {
                if (linhas1[i] == "1" || linhas1[i] ==  "1\r") // Lógica para selecionar os nomes da categoria '1';
                {
                    linhas.Add(linhas1[i - 1]); // 
                }
            }

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }




            Console.ReadLine();
        }

    }
}
