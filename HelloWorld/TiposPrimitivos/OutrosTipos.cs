using System;

namespace HelloWorld.TiposPrimitivos;

public class OutrosTipos
{
    // TIPO ENUM
    // No tipo enum definimos as opções possiveis para escolher;
    // O Enum deve ser criar fora de uma função
    enum nivelDeDificuldade {Baixo, Médio, Alto}; // Não devemos colocar entres "";

    // também podemos atribuir numeros aos valores do enum. Contando que os numeros sejam positivos e não repetidos;
    enum nivelDeDificuldade2 {
        Baixo = 0,
        Médio = 1,
        Alto = 2
    }; // Não devemos colocar entres "";

    static void Main() {
        // ENUM

        // devemos instanciar o enum dentro da função para usá-lo;
        nivelDeDificuldade2 dificuldade = nivelDeDificuldade2.Alto;

        // podemos exibir o número correspondente do enum se fizermos um cast:
        int dificuldadeInteiro = (int)dificuldade;

        Console.WriteLine(dificuldade); //imprime "Alto";
        Console.WriteLine(dificuldadeInteiro); //imprime "2";

        // ===============================

        // TIPOS BOOLEANOS

        // retornam apenas valores verdadeiros e falsos, é como representar 0 e 1, apagado e acesso;
        bool value1 = true;
        bool value2 = false;

        // ===============================

        // TIPO NULL;
        // para permitir que a variavel receba o valor null devemos usar o ?;
        int? idade = null;
        
        // retorna true ou false se idade possui valor diferente de null;
        bool informouIdade = idade.HasValue;
    }
}
