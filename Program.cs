﻿using System;
using System.Collections.Generic;

namespace Exercicios_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirIMC(89, 1.83);            
            
            #region "Main"

            //var entrada = Console.ReadLine();
            //Console.WriteLine(entrada);
            //ExibirIMC = entrada;
            ////Console.WriteLine(IMC(80, 1.75));
            //var entrada = Console.ReadLine();
            //Console.WriteLine(entrada);
            //float A, P, imc;

            //Console.Write("Digite o seu peso:");
            //P = float.Parse(Console.ReadLine());


            //Console.Write("Digite o seu altura:");
            //A = float.Parse(Console.ReadLine());

            //imc = (P / (A * A));

            //if (imc <= 18)
            //{
            //    Console.WriteLine("Peso abaixo do normal");
            //}
            //else if ((imc > 18.5) && (imc < 24.9))
            //{
            //    Console.WriteLine("Peso normal");
            //}

            //else if ((imc >= 25) && (imc < 29.9))
            //{
            //    Console.WriteLine("Sobre o Peso");
            //}
            //else if ((imc >= 30) && (imc < 34.9))
            //{
            //    Console.WriteLine("Grau de Obesidade I");
            //}
            //else if ((imc >= 35) && (imc < 39.9))
            //{
            //    Console.WriteLine("Grau de Obesidade II");
            //}
            //else if (imc >= 40)
            //{
            //    Console.WriteLine("Obesidade Grau III");
            //}

            //Console.ReadKey();


            //float num;
            //float soma;
            //Console.WriteLine(SomaSerie(10));
            // ExibirDicionario(QuantLetras("arara"));
            //Console.WriteLine(SomatorioMultiplo6(10));
            //Console.WriteLine(SomatorioMultiplo3(9));
            //int peso, altura, resultado;
            //Console.Write("Informe O Peso:");
            //peso = int.Parse(Console.ReadLine());

            //Console.Write("Informe A Altura:");
            //altura = int.Parse(Console.ReadLine());

            //resultado = peso / altura * 2;
            #endregion
        }

        static int IMC(int peso, double altura)
        {
            var A = Math.Pow(altura, 2);

            return (peso / (int)A);
        }

        static void ExibirIMC(int peso, double altura)
        {
            var imc = IMC(peso, altura);

            if (imc <= 18)
            {
                Console.WriteLine("Você está abaixo do peso, se alimente mais");
            }

            else if ((imc >= 18.5) && (imc <= 24.9))
            {
                Console.WriteLine("Seu peso é normal, parabéns!");
            }
            else if ((imc >= 25) && (imc <= 29.9)) 
            {
                Console.WriteLine("Você está um pouquinho acima do peso");
            }
            else if ((imc >= 30) && (imc <= 39.9))
            {
                Console.WriteLine("Obesidade grau I, presta atenção na sua saúde ");
            }
            else if ((imc >= 35) && (imc <=39.9))
            {
                Console.WriteLine("Obesidade grau II, cuidado!!!");
            }
            else if (imc >=40)
            {
                Console.WriteLine("Obesidade grau 3, quer morrer????");
            }

        }
        #region "Codigos Treinamento
        //static void main(float num, float soma)
        //{
        //    soma = SomaSerie(num);

        //}


        //static int Somatorio2PontoZero(int n)
        //{
        //    int somatorio = 0;

        //    var i = 1;

        //    while (i<= n )
        //    {

        //    }
        //}







        // Ex1.
        static int SomatorioMultiplo3(int n)
        {
            int somatorio = 0;

            // for (primeira_parte; segunda_parte; terceira_parte) {}
            // for (var i = 1; i <= n; i++) {}

            var i = 1;

            while (i <= n)
            {
                if (i % 3 == 0)
                    somatorio += i;

                i++;
            }

            return somatorio;
        }

        static float Fatorial (float n)
        {
            if (n <=2)
            {
                return n;
            }
            else
            {
                return n *Fatorial (n - 1);
            }
        }

        static float SomaSerie(int r)
        {
            float n = 0;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                n = n + (SomaSerie(r - 1) + (1 / Fatorial(n)));

                return n;
            }
        }

        //static bool ProcuraNaLista(int valor, List<int> lista) {
        //    foreach (var elemento in lista) {
        //        if (elemento == valor)
        //            return true;

        //    }

        //    return false;
        //}

        //// Ex0.
        //static Dictionary<char, int> QuantLetras(string palavra) {
        //    // Dicionário com cada letra e a sua quantidade
        //    var dict = new Dictionary<char, int>();

        //    foreach (var letra in palavra) {
        //        if (dict.ContainsKey(letra)) {
        //            dict[letra]++;
        //        } else {
        //            dict[letra] = 1;
        //        }
        //    }

        //    return dict;
        //}

        //static void ExibirDicionario(Dictionary<char, int> letras) {
        //    Console.WriteLine("");

        //    foreach (var letra in letras) {
        //        Console.WriteLine($"{letra.Key} --> {letra.Value}");
        //    }

        //    Console.WriteLine("");
        //}

        //static void ExibirLista(List<string> lista) {
        //    Console.WriteLine("");

        //    foreach(var elem in lista) 
        //        Console.WriteLine(elem);

        //    Console.WriteLine("");
        //}
        #endregion
    }
}
