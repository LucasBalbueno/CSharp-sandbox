// Record possui os mesmos comportamentos de uma classe, mas tem alguns principios diferentes, como a referencia de memória alocada, imutabilidade e deconstruct
// Além disso Record não precisa de construtor ao ser criado, apenas passar as propriedades como parânetro
// A primeira diferença entre um Record e uma Classe, é que a Classe é do tipo complexo que quando instanciada ocupa um espaço maior na memória
// E o objeto da classe sempre usa uma referencia de memória
// Já com Record, a instancia faz a cópia do objeto
// A segunda grande diferença é que record trabalha o princípio ad imutabilidade
// Na instancia da classe conseguimos alterar-la, no Record não conseguimos

// O Record é muito usados para DTOs de acordo com o seu princípio da imutabilidade

var personClass = new Person("Lucas", 24); // Quando instanciamos um objeto de uma classe, estamos alocando isso na memória
var personClass2 = new Person(personClass.Name, personClass.Age); // Objeto com os memsmo valores do objeto anterior

personClass.Name = "Balbueno"; // Perceba que na classe conseguimos alterar a instancia

Console.WriteLine($"É igual: {personClass.Equals(personClass2)}"); // Dará false pois a cada instancia da classe, o objeto apontará para uma referencia de memória, sendo cada referencia de memória diferente


var personRecord = new PersonRecord("Lucas", 24); // Instancia de um Record
var personRecord2 = new PersonRecord(personRecord.Name, personRecord.Age); // Objeto com os memsmo valores do objeto anterior

// personRecord.Name = "Qualquer coisa"; // Perceba que não é possivel alterar uma propriedade do record;

// Se quisermos criar um outro objeto baseado em um já existente, conseguimos fazer isso sem o new
var personRecord3 = personRecord with {Age = 25}; // Nesse caso ele simplesmente irá copiar o personRecord e alterar o que foi passado no with

Console.WriteLine($"É igual: {personRecord.Equals(personRecord2)}"); // Dará true pois o record faz a cópia exata do objeto, se tornando igual




// Classe
public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string Name { get; set; }
    public int Age { get; set; }
}

// Record
// Não é necessário contrutor
record PersonRecord(string Name, int Age);