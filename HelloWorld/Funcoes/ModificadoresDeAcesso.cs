using System;

namespace HelloWorld.Funcoes;

// MODIFICADORES DE ACESSO
// determinam quem tem acesso a uma função ou até mesmo uma classe, determinam a visibilidade;

// na classe podemos ter uma class public que ficará visivel para todas as outras classes seja dentro do mesmo projeto ou não;
// e internal, que fica visivel apenas para classes do mesmo projeto;
// por padrão, se não escreer modificador de acesso na classe ela será internal;
public class ModificadoresDeAcesso
{
    // As funções também possuem modificadores de acesso, que determinal a sua visibilidade;

    // public quer dizer que a função pode ser executada em qualquer classe, pertencente ao mesmo projeto ou não.
    //  void determina que a função não retorna nada
    public void FuncaoPublica () {
        Console.WriteLine("Funcionando a função publica!");
    }

    // private fica visível apenas para essa classe podendo ser chamada dentro de outras funções;
    private void FuncaoPrivada () {
        Console.WriteLine("Funcionando a função privada!");
    }

    // internal ficar vísvel apenas para esse mesmo projeto, ainda podemos acessar ela de outras classes mas só se essa classe estiver dentro do mesmo projeto
    internal void FuncaoInternal () {
        Console.WriteLine("Funcionando a função internal!");
    }

    // por padrão, se não escrever o modificador de acesso na função, ela será private.
    void FuncaoDefault () {
        Console.WriteLine("Funcionando a função default!");
    }
}
