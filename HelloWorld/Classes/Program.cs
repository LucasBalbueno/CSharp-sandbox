using System;

namespace HelloWorld.Classes;

public class Program
{
    public void Main () {
        // Agora ao instanciar é obrigatório passar o atributo modelo como parâmetro pois é uma propriedade do construtor;
        // o restante dos atributos são opcionais, a não ser que tenham o required ou que estejam no construtor;
        ClasseComValores teste = new ClasseComValores("BMW M3") {
            // Essa é uma outra forma de inserir valores nos atributos da classe com sets;
            Cor = Cor.branco,
            DataLancamento = new DateOnly(2024, 9, 16)
        };

        // GETTER E SETTER;

        // Para usarmos o get e o set quando a classe está instanciada basta usar duas sintaxes;
        // essa chama o set pois estamos atribuindo um valor à propriedade;
        teste.Modelo = "BMW M2";
        // essa é uma forma de adicionar valores aos atributos de uma classe;
        // a outra forma é abrindo {} depois de new e definir dentro desse bloco de código, como mostrando acima;
        teste.DataLancamento = new DateOnly(2024, 12, 1);

        // essa chama o get, pois estamos apenas lendo o valor da propriedade e atribuindo a uma variável;
        string verValor = teste.Modelo;

        // chamando uma função que le a propriedade (como um get);
        teste.nomeDoModelo();
    }
}
