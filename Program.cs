using System.Drawing;

namespace ArrayseFuncoes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays e Funções");

            int[] sequenciaNumeros = new int[]
                {-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6};

            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                Console.Write(sequenciaNumeros[i]);
                if (i != sequenciaNumeros.Length - 1)
                    Console.Write(", ");

            }

            // Encontrar o maior valor

            int maiorValor = sequenciaNumeros[0];
            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                if (sequenciaNumeros[i] > maiorValor)
                {
                    maiorValor = sequenciaNumeros[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Maior Valor: " + maiorValor);

            // Encontrar o menor valor

            int menorValor = sequenciaNumeros[0];
            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                if (sequenciaNumeros[i] < menorValor)
                {
                    menorValor = sequenciaNumeros[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Menor Valor:" + menorValor);

            //Calcular o valor médio

            int valorTotal = 0;
            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                valorTotal = valorTotal + sequenciaNumeros[i];
            }
            decimal valorMedio = valorTotal / sequenciaNumeros.Length;

            Console.WriteLine();
            Console.WriteLine("Valor Médio:" + valorMedio);

            //Encontrar os 3 maiores

            Array.Sort(sequenciaNumeros);
            Array.Reverse(sequenciaNumeros);

            int[] tresMaiores = new int[3];
            for (int i = 0; i < tresMaiores.Length; i++)
            {
                tresMaiores[i] = sequenciaNumeros[i];
            }

            Console.WriteLine();
            Console.Write("Três Maiores:");

            for (int i = 0; i < tresMaiores.Length; i++)
            {
                Console.Write(tresMaiores[i]);
                if (i != tresMaiores.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();

            // Encontrar os valores negativos

            Array.Reverse(sequenciaNumeros);
            int qtdNumerosNegativos = 0;
            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                if (sequenciaNumeros[i] < 0)
                    qtdNumerosNegativos++;
            }

            int[] valoresNegativos = new int[qtdNumerosNegativos];
            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                if (sequenciaNumeros[i] < 0)
                {
                    valoresNegativos[i] = sequenciaNumeros[i];
                }
            }

            Console.WriteLine();

            Console.Write("Valores Negativos:");

            for (int i = 0; i < valoresNegativos.Length; i++)
            {
                Console.Write(valoresNegativos[i]);

                if (i != valoresNegativos.Length - 1)
                
                    Console.Write(", ");

            }



            // Remover itens
            Console.WriteLine();

            Console.Write("Digite o número para remover:");

            int numeroparaRemover = Convert.ToInt32(Console.ReadLine());

            int qtdNumerosparaRemover = 0;

            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                if (sequenciaNumeros[i] == numeroparaRemover)
                {
                    qtdNumerosparaRemover++;

                }
            }

            int[] novaSequenciaNumeros = new int[sequenciaNumeros.Length - qtdNumerosparaRemover];

            int j = 0;

            for (int i = 0; i < sequenciaNumeros.Length; i++)
            {
                if (sequenciaNumeros[i] != numeroparaRemover)
                {
                    novaSequenciaNumeros[j] = sequenciaNumeros[i];
                    j++;
                }
            }

            for (int i = 0; i < novaSequenciaNumeros.Length; i++)
            {
                Console.Write(novaSequenciaNumeros[i]);

                if (i != novaSequenciaNumeros.Length - 1)

                    Console.Write(", ");
            }

            Console.ReadLine();

        }
    }
}