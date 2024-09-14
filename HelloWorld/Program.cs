// o using serve como um import. Ele diz que vamos usar outro nameSpace;
using HelloWorld.Teste;

// Damos o namespace o nome do projeto
namespace HelloWorld;

// Damos à classe o nome do arquivo;
class Program {

    // Em um projeto Console a função executavel deve se chamar Main;
    static void Main () {
        // instanciando a classe Carro
        // Essa intancia não é preciso usar o using (import) pois o namespace de ambas é a mesma;
        Carro meuCarro = new Carro();

        // executando as funções da class Carro
        meuCarro.Ligar();

        // a função Desligar não está mais visível pois ela é private;
        // meuCarro.Desligar();

        // Teste1 é um método internal, está visivel apenas para classes do mesmo projeto;
        meuCarro.Teste1();

        // não está visivel pois quando não colocamos modificador por padrão é private;
        // meuCarro.Teste2();

        // Para instanciar a class Biscoito e usar suas funções devemos fazer o uso de using e dizer qual o nameSpace
        // para dizer que estamos usando uma classe de um nameSpace diferente;
        Biscoito meuBiscoito = new Biscoito();
        meuBiscoito.Temperatura();
    }
}