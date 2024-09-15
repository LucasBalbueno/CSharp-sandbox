using System;

namespace HelloWorld.Colecoes;

public class Arrays
{
    static void Main()
    {
        // ARRAYS

        // Arrays são coleções de dados com tamanho fixos, eles precisam ter tamanhos pré-definidos ao declarar o array;
        // nós até podemos aumentar o array depois de definir o tamanho dele mas isso consome muita memória no programa;
        // Para declarar um array devemos colocar o tipo de dados do array seguido de []. E após o new int[tamanho];
        int[] inteiros = new int[10];

        // definir valores para cada posição do array;
        inteiros[0] = 1;
        inteiros[1] = 2;
        inteiros[2] = 3;

        Console.WriteLine(inteiros.Length); // retorna 10 pois o seu tamanho ja foi definido;
        Console.WriteLine(inteiros[0]); // retorna o valor do indice 0;

        // outra forma de inserir valores em um array que já estão definidos é assim:
        int[] inteiros2 = [5, 6, 10];

        // podemos inserir mais valores no array, entretanto isso consome muita energia da máquina e por isso não é uma boa prática;
        inteiros2[3] = 2;

        // também podemos ter matrizes de arrays, arrays dentro de arrays (aninhados);
        // para declarar uma matriz de array devemos colocar o tipo do array seguido de [,] e depois new int[linhas, colunas];
        // a virgula dentro [] define mais de uma dimensão para o array;
        int[,] matriz = new int[10, 10]; // 10 linhas e 10 colunas;

        // Podemos definir quantas dimensões quisermos contando que definimos o tamanho também;
        int[,,] matriz2 = new int[10, 10, 10];

        // para definir os valores nos indices colocamos [indiceLinha, indiceColuna];
        matriz[0, 0] = 1;
        matriz[0, 4] = 2;

        // por default, em arrays do tipo int se não inserirmos um valor no indice do array, ele será 0;
        Console.WriteLine(matriz[0, 2]); // retorna 0;

        // usamos poucos arrays no dia a dia pela falta de dinâmica nessa coleção que já possui o seu tamanho definido;
    }
}