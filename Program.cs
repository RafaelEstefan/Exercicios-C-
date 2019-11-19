using System;
using System.Collections.Generic;

namespace Exercicios_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExibirDicionario(QuantLetras("arara"));
            Console.WriteLine(SomatorioMultiplo6(60));
        }
        
        // Ex1.
        static int SomatorioMultiplo6(int n) {
            int somatorio = 0;

            // for (primeira_parte; segunda_parte; terceira_parte) {}
            // for (var i = 1; i <= n; i++) {}

            var i = 1; 
            
            while (i <= n) {
                if (i % 6 == 0) {
                    somatorio += i;
                }

                i++;
            }

            return somatorio;
        }

        static bool ProcuraNaLista(int valor, List<int> lista) {
            foreach (var elemento in lista) {
                if (elemento == valor)
                    return true;
                
            }

            return false;
        }

        // Ex0.
        static Dictionary<char, int> QuantLetras(string palavra) {
            // Dicionário com cada letra e a sua quantidade
            var dict = new Dictionary<char, int>();

            foreach (var letra in palavra) {
                if (dict.ContainsKey(letra)) {
                    dict[letra]++;
                } else {
                    dict[letra] = 1;
                }
            }

            return dict;
        }

        static void ExibirDicionario(Dictionary<char, int> letras) {
            Console.WriteLine("");

            foreach (var letra in letras) {
                Console.WriteLine($"{letra.Key} --> {letra.Value}");
            }

            Console.WriteLine("");
        }

        static void ExibirLista(List<string> lista) {
            Console.WriteLine("");

            foreach(var elem in lista) 
                Console.WriteLine(elem);
            
            Console.WriteLine("");
        }
    }
}
