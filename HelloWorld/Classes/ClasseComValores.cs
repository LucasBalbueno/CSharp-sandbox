using System;

namespace HelloWorld.Classes;

public class ClasseComValores
{
    // PROPRIEDADES NAS CLASSES

    // Podemos definir propriedades nas classes com as propriedade get e set;
    // get serve para retornar o valor da nossa propriedade, ler ela;
    // set serve para atribuir ou alterar o valor da nossa propriedade;
    // Em C# temos uma propriedade automática, uma sintaxe que já define get e set básicos para as nossas propriedades:
    public string Modelo { get; set; }
    // há também como colocarmos propriedades obrigatórios, não podemos instanciar essa classe sem atribuir um valor a essa propriedade;
    public required DateOnly DataLancamento { get; set; }
    public Cor Cor { get; set; }

    // A outra forma de deixar uma propriedade obrigatória e colocar ela dentro de um construtor;
    // O construtuor é como uma função suprema da classe que irá auxiliar na criação do molde;
    // Para criar um construtor basta criar uma função com o mesmo nome da classe;
    // Todos os atributos passados como parâmetros do contrutor agora são obrigatórios a possuir valores no momento da instanciação da classe;
    public ClasseComValores(string modelo) {
        // Além de inserir o parâmetro que é o atributo obrigatório, também devemos atribuir esse parâmetro do construtor ao atributo da classe;
        Modelo = modelo;
    }

    public void nomeDoModelo () {
        Console.WriteLine(Modelo);
    }
}

public enum Cor {
    preto,
    branco,
    amarelo,
    vermelho,
    azul
}