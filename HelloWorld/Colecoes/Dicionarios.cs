using System;

namespace HelloWorld.Colecoes;

public class Dicionarios
{
    static void Main () {
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
    }
}
