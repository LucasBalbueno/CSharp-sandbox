using System;

namespace HelloWorld.Colecoes;

public class Listas
{
    static void Main () {
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
    }
}
