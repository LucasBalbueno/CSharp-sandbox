using System;

namespace HelloWorld.Colecoes;

public class HashSets
{
    static void Main() {
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
