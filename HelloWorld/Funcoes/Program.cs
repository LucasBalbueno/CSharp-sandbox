using System;

namespace HelloWorld.Funcoes;

public class Program
{
    static void Main() {
        // MODIFICADORES DE ACESSO

        // instanciando a classe ModificadoresDeAcesso;


        // Nessa intancia nào é preciso usar o using (import) pois o namespace desse arquivo para o arquivo da class é o mesmo;
        // Ao usar o using estamos dizendo de onde tirar essa class;
        // Caso o namespace da class seja diferente do arquivo atual, o using será necessário;
        ModificadoresDeAcesso teste = new ModificadoresDeAcesso();

        // executando as funções da class ModificadoresDeAcesso
        teste.FuncaoPublica();

        // a função FuncaoPrivada não está mais visível pois ela é private;
        // teste.FuncaoPrivada();

        // FuncaoInternal é um método internal, está visivel apenas para classes do mesmo projeto;
        teste.FuncaoInternal();

        // FuncaoDefault não está visivel pois quando não colocamos modificador por padrão é private;
        // teste.FuncaoDefault();

        // ==================================

        // FUNÇÕES COM PARÂMETROS

        // instanciando a classe Funcoes
        Funcoes teste2 = new Funcoes();

        // chamando a função com parâmetros;
        // ao chamar podemos simplesmente passar os seus parâmetros dessa forma:
        teste2.funcaoComParametros(1, 7);
        // mas também podemos nomear os parâmetros;
        teste2.funcaoComParametros(param1: 1, param2: 7);

        // chamando a função com retorno de dois tipos ou dois valores;
        // se usarmos var para retornar dois item, teremos a opção de esolher o item1 e item2 por default, mas essa nomeação é automática e pouco prática;
        var resultados1 = teste2.funcaoComDoisRetorno(1, "teste");
        Console.WriteLine(resultados1.Item1);
        Console.WriteLine(resultados1.Item2);

        // mas também podemos nomear esses dois retornos, e aqui vamos nos refereir pelo seus nome;
        var resultados2 = teste2.funcaoComDoisRetornosNomeados(1, 2);
        Console.WriteLine(resultados2.nome1);
        Console.WriteLine(resultados2.nome2);

        // uma última forma mais simples de é parecido com a "desestruturação", podemos criar as variaveis assim que já chamamos ela;
        (int nome1, int nome2) = teste2.funcaoComDoisRetornosNomeados(1, 2);
        Console.WriteLine(nome1);
        Console.WriteLine(nome2);
    }
}
