using System;

namespace HelloWorld.Funcoes;

public class Funcoes
{
    // Em uma função com parâmetros devemos determinar o tipo desses parâmetros antes de recebe-los. Não podemos colocar seu tipo var;
    public void funcaoComParametros (int param1, int param2) {
        int resultado = param1 + param2;

        Console.WriteLine(resultado);
    }

    // Podemos ter também funções que possuem parâmetros default ou opcionais;
    // O parâmetro default é um parâmetro que caso não receba nenhum valor ao ser chamado...
    // terá o valor definido pra ele, fazendo com que o seu parâmetro seja opcional
    // em C# podemos ter mais de um parâmetro opcional desde que eles sempre sejam os ultimos;
    public void funcaoComParametroDefault (int param1, int param2, int param3 = 7) {
        // linhas de códigos...
    }

    // Nas funções podemos devolver um valor ou não, já vimos que para as funções sem retorno usamos void;
    // Agora, para funções que retornam algo, basta colocarmos o seu tipo ao invés do void;
    public int funcaoComRetorno (int value) {
        return value;
    }

    // podemos também ter funções que retornam dois valores (ou mais) do mesmo tipo ou não;
    public (int, string) funcaoComDoisRetorno(int value1, string value2) {
        return (value1, value2);
    }
    // ainda na função com dois retonros podemos nomear os retornos
    public (int nome1, int nome2) funcaoComDoisRetornosNomeados (int value1, int value2) {
        return (value1, value2);
    }

    // Nas funções de uma linha de código tem uma forma mais simples de sintaxe para escreve-las;
    public void funcaoUmaLinha (bool value) => Console.WriteLine(value);

}