using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Aula4_VetoresMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exe1();
            //Exe2();
            //Exe3();
            //Exe4();
            //Exe5();
            //Desafio_V1();
            Desafio_V2();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar");
            Console.ReadKey();
        }

        private static void Exe1()
        {
            // Calcular e apresentar a média geral de 5 alunos
            float[] mediaAlunos = new float[5];
            float soma = 0;
            float mediaGeral;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite a média do {0}.o aluno: ", i + 1);
                mediaAlunos[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Media dos alunos: ");
            //Mostrando os dados do vetor
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(mediaAlunos[i].ToString("F2", CultureInfo.InvariantCulture));
            }

            for (i = 0; i < 5; i++)
            {
                soma += mediaAlunos[i];
            }

            mediaGeral = soma / 5;

            Console.WriteLine("Media geral é: " + mediaGeral.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void Exe2()
        {
            /*Ler dez elementos de um vetor A, construir um vetor B de mesmo tipo,
             * levando em consideração que se o valor do índice for par, o valor deve ser multiplicado
             * por 5, e se for ímpar seve ser somado com 5.*/

            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int soma;
            int multiplicar;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite {0}.o numeros: ", i + 1);
                vetorA[i] = int.Parse(Console.ReadLine());

                if (vetorA[i] % 2 == 0)
                {
                    //Console.WriteLine("Numero é par");
                    multiplicar = vetorA[i] * 5;
                    vetorB[i] = multiplicar;
                }
                else
                {
                    //Console.WriteLine("Numero é impar");
                    soma = vetorB[i] + 5;
                    vetorB[i] = soma;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("Os numeros vetor A: " + vetorA[i].ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("VetorA[{0}] = {1,4} / ", i, vetorA[i]);
                Console.Write("VetorB[{0}] = {1,4} / ", i, vetorB[i]);
                Console.WriteLine();
            }
        }

        private static void Exe3()
        {
            string[] nome = new string[5];
            int i, j;
            string x;

            //entrada
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0} nome: ", i + 1);
                nome[i] = Console.ReadLine();
            }

            //processamento ordenação
            for (i = 0; i < 4; i++)
                for (j = i + 1; j < 5; j++)
                    if (nome[i].CompareTo(nome[j]) > 0)
                    {
                        x = nome[i];
                        nome[i] = nome[j];
                        nome[j] = x;
                    }

            Console.WriteLine();
            Console.WriteLine("Lista de nomes ordenados");
            Console.WriteLine();

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }

        private static void Exe4()
        {
            /*Fazer a leitura de nove valores dispostos em uma matriz de duas dimensões
             * com três linhas e três colunas. Em seguida, apresentaremos os elementos
             * existentes na diagonal principal*/

            int[,] a = new int[3, 3];

            int i, j;

            int lin = 7, col = 0;

            Console.SetCursorPosition(0, 0);
            Console.Write("Digite um valor na ordem coordenada:");
            Console.SetCursorPosition(0, 2);
            Console.Write("Linha...:");
            Console.SetCursorPosition(0, 3);
            Console.Write("Coluna...:");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("{0}", i + 1);
                    Console.SetCursorPosition(11, 3);
                    Console.Write("{0}", j + 1);
                    Console.SetCursorPosition(0, 5);
                    Console.Write("--> ");

                    a[i, j] = int.Parse(Console.ReadLine());

                    Console.SetCursorPosition(4, 5);
                    Console.Write("    ");
                    Console.SetCursorPosition(col, lin);
                    Console.Write("{0,4}", a[i, j]);
                    col += 6;
                }
                lin += 2;
                col -= 18; 
            }

            Console.SetCursorPosition(0, 13);
            Console.Write("Saida - Diagonal Principal");
            Console.SetCursorPosition(0, 15);

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write("A[{0},{1}]", i + 1, j + 1);
                        Console.WriteLine(" = {0,4}", a[i,j]);
                    }
                }
            }
        }

        private static void Exe5()
        {
            /*Efetua a leitura de dois vetores. Vetor A com 5 elementos e Vetor B com 6 elementos.
             * construa matriz sendo a junção de 2 vetores. Assim, C deve ter a capacidade de
             * armazenar 12 elementos. Apresente matriz C.*/

            int[] a = new int[5];
            int[] b = new int[7];
            int[,] c = new int[3, 4];
            int x = 0;

            int i,j;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0} valor no vetor A: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i < 7; i++)
            {
                Console.Write("Digite o {0} valor no vetor B: ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i < 3; i++)
            {               
                for (j = 0; j < 4; j++)
                {
                    if (x < 5)
                    {
                        c[i, j] = a[x];
                        x++;
                    }
                    else
                    {
                        c[i, j] = b[x - 5];
                        x++;
                    }

                    Console.Write("C[{0},{1}]", i, j);
                    Console.WriteLine(" = {0, 3}", c[i,j]);
                }
            }
        }

        private static void Desafio_V1() 
        {
            int[] a = new int[8];
            int[] b = new int[8];
            int i;

            for (i = 0; i < 8; i++)
            {
                Console.Write("Informe o {0} numero: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());

                b[i] = a[i];
            }

            for (i = 0; i < 8; i++)
            {
                Console.Write("A = {1,2} ", i + 1, a[i]);
                Console.WriteLine();
            }

            Console.WriteLine();

            for(i = 7; i >= 0; i--)
            {
                Console.Write("B = {1,2} ", i + 1, b[i]);
                Console.WriteLine();
            }
        }

        private static void Desafio_V2()
        {
            int[] a = new int[8];
            int[] b = new int[8];
            int i, x = 0;

            for (i = 0; i < 8; i++)
            {
                Console.Write("Informe o {0} numero: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());   
            }

            for (i = 7; i >= 0; i--)
            {
                if(x < 8)
                {
                    b[x] = a[i];
                }
                x++;
            }

            Console.WriteLine();

            for (i = 0; i < 8; i++)
            {
                Console.Write("VetorA[{0}] = {1,2} / ", i +1, a[i]);
                Console.Write("VetorB[{0}] = {1,2} / ", i +1, b[i]);
                Console.WriteLine();
            }
        }
    }
}
