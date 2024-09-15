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

        // ====================================

        // LISTAS

        // a Coleção mais usada no dia a dia;
        // Nas listas não precisamos já pré-definir um tamanho para ela, pois ela faz o resize automaticamente;
        // A lista só pode ter uma dimensão, ou seja não existe matriz com listas;
        // Chamamos o tipo List e dentro dos <> colocaremos o seu tipo. Depois new List<Tipo>();
        List<int> inteiros3 = new List<int>();

        // nas listas usaremos o Count para saber o seu tamanho
        Console.WriteLine(inteiros3.Count());

        // para adicionar um elemento nessa lista usaremos Add(). Assim será adicionado em ordem;
        inteiros3.Add(4);
        inteiros3.Add(2);

        // para ler uma lista fazemos do mesmo modo que um Array. Entretanto, não podemos ler um indice que não existe;
        Console.WriteLine(inteiros3[0]);
        
        // para remover um elemento da Lista usaremos o Remove() passando como parâmetro o elemento;
        // quando removemos de uma lista um elemento, aquele indice não fica fácil, os elementos posteriores do elemento removido voltando um indice;
        inteiros3.Remove(4);
        Console.WriteLine(inteiros3[0]); // retorna 2 pois ele estava no indice 1 mas quando o elemento do indice 0 foi removido, o 2 acabou se tornando o indice 0;

        // pega o primeiro elemento da lista;
        int primeiroElemento = inteiros3.First();

        // pega o ultimo elemento da lista
        int ultimoElemento = inteiros3.First();

        // pega o elemento do indice passado como parâmetro;
        int elementoPosicionado = inteiros3.ElementAt(0);

        // remove o elemento do indice passado como parâmetro, ao contrário do Remove() que remove o elemento passado como parâmetro;
        inteiros3.RemoveAt(0);

        // remove todos os elementos da lista;
        inteiros3.Clear();

        // remove todos os elementos que corresponde a especificação passada como parâmetro;
        // parecido com uma função callback onde cada elemento será x e irá remover os x igual a 4;
        inteiros3.RemoveAll(x => x == 4);

        // As listas com tipagem podem armazenar apenas elementos e valores daquele tipo;
        // Para criar uma lista com uma tipagem misturada, onde teremos strings, numeros, booleanos e etc... usaremos o tipo object;
        // usa-se muito pouco esse tipo de lista;
        List<object> objetos = new List<object>();

        objetos.Add(2);
        objetos.Add("string");
        objetos.Add(true);

        Console.WriteLine(objetos[0]);

        // em uma lista de strings ainda podemos concatenar todos os elementos e transformas em uma lista só;
        // Faremos isso usando Join(), que recebe dois parâmetros;
        // o primeiro parâmetro é o separadaor, o que irá ficar entre um elemento e outro;
        // o segundo parâmetro é o a coleção que queremos concatenar;

        List<string> listaStrings = new List<string>();

        listaStrings.Add("Hello");
        listaStrings.Add("World!");


        string novaString = string.Join(" ", listaStrings); // retorna "Hello World!"

        // ====================================

        // DICIONÁRIOS
        
        // Os dicionários possuem um valor associado a uma chave, sendo que a chave deve ter um valor único, sem ter duplicatas;
        Dictionary<int, string> DicionarioTeste = new Dictionary<int, string>();

        // a chave 1 possui seu valor "primeiro" atribuido a ela;
        DicionarioTeste.Add(1, "Primeiro");
        DicionarioTeste.Add(2, "Segundo");
        DicionarioTeste.Add(5, "Terceiro");

        // Não podemos definir um novo valor a uma chave já existente;
        // DicionarioTeste.Add(1, "Teste");

        // Para ler ou pegar um valor de um dicionário usaremos a chave daquele valor;
        string value = DicionarioTeste[1];
        Console.WriteLine(value); // retorna a string Primeiro;

        // pode confundir um pouco com uma lista ou um array, mas lembrando que as chaves não são indices, podemos colocar qualquer chave para fazer referencia ao valor;
        // para exemplicar vamos criar as chaves com outro tipo;

        Dictionary<string, int> DicionarioInvertido = new Dictionary<string, int>();

        DicionarioInvertido.Add("Primeiro", 56);
        DicionarioInvertido.Add("Segundo", 78);
        DicionarioInvertido.Add("Terceiro", 100);

        // agora teremos acesso ao valor int usando a chave string;
        int valueInvertido = DicionarioInvertido["Primeiro"]; // retorna o int 56;

        // CountaysKey retorna true ou false se existir a chave passada como parâmetro;
        bool existe = DicionarioInvertido.ContainsKey("Maria"); // retorna false
        bool existe2 = DicionarioInvertido.ContainsKey("Terceiro"); // retorna true

        // ====================================

        // HASH SETS

        // Hash Sets é uma lista de valores unicos
        // Os Hash Sets são muito semelhantes a uma lista, mas a sua principal diferença é que todos os elementos presentes devem ser unicos;
        // Os Hash Sets não possuem duplicatas;
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);

        // Quando temos valores duplicados não teremos erros, excessões. Entretanto, irá contar apenas valores unicos.
        set.Add(2);

        Console.WriteLine(set.Count()); // retorna 2 pois o terceiro elemento não conta;
    }
}