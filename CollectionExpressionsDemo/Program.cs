using System;

namespace CollectionExpressionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Criar um array
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] numeros2 = [1, 2, 3, 4, 5, 6, 7, 8];


            //Criar uma lista
            List<string> contagem = new List<string> { "one", "two", "three" };
            List<string> contagem2 = ["one", "two", "three"];


            //Criar um span
            Span<char> letras = stackalloc char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'h', 'i' };
            Span<char> letras2 = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];


            //Criar um array bidimensional irregular
            int[][] twoD = new int[][]
              {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 }
              };

            int[][] twoD2 = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];



            //Criar um array bidimensional irregular a partir de variáveis

            int[] n1 = [1, 2, 3];
            int[] n2 = [4, 5, 6];
            int[] n3 = [7, 8, 9];

            int[][] todos = [n1, n2, n3];

            foreach (int[] i in todos)
            {
                foreach (int n in i)
                {
                    Console.WriteLine(n);
                }
            }


            //Operador spread
            int[] num = [.. n1, .. n2, .. n3];
            foreach (var item in num)
            {
                Console.WriteLine($"num = {item}");
            }

        }
    }
}
