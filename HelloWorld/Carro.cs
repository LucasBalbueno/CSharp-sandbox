namespace HelloWorld;

// na classe podemos ter uma class public que ficará visivel para todas as outras classes seja dentro do mesmo projeto ou não;
// e internal, que fica visivel apenas para classes do mesmo projeto;
// por padrão, se não escreer modificador de acesso na classe ela será internal;
public class Carro
{
    // public quer dizer que a função pode ser executada fora dessa classe. se não colocarmos nada, ela só pode ser executada nessa class;
    //  void não retorna nada
    public void Ligar () {
        Console.WriteLine("Carro ligado!");
    }

    // private fica visível apenas para essa classe (Carro) podendo ser chamada dentro de outras funções;
    private void Desligar () {
        Console.WriteLine("Carro desligado!");
    }

    // internal ficar vísvel apenas para esse mesmo projeto, ainda podemos acessar ela de outras classes mas só se
    // essa classe estiver dentro do mesmo projeto
    internal void Teste1 () {
        Console.WriteLine("Carro desligado!");
    }

    // por padrão, se não escrever o modificador de acesso na função, ela será private.
    void Teste2 () {
        Console.WriteLine("Carro desligado!");
    }
}
