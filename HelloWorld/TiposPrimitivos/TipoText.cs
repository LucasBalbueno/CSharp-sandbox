using System;
using System.Text;

namespace HelloWorld.TiposPrimitivos;

public class TipoText
{
    static void Main() {
        // TIPOS DE TEXTO

        // tipo que armazena apenas um caractere da tabela ASCII (letra ou numero) desde que esteja em aspas simples;
        char letra = 'A';

        // tipo que armazena um texto, que é uma lista de chars dentro de aspas duplas;
        // cada char na string representa uma posição começando em 0;
        string texto = "Aprenendo tipos primitivos com C#";
        
        //como string é uma lista de char podemos acessar qualquer char da variavel string;
        char primeiraLetraDoTexto = texto[0];

        // para tipo string podemos fazer uso de funções nativas da linguagem;
        string textoComEspaco = "    Espaço    ";
        // Trim() devolve uma nova string sem espaços no final e no começo;
        string textoSemEspaco = textoComEspaco.Trim();
        // StartsWith() devolve true ou false se o texto começa com a string passada por parâmetro, com senstive case;
        bool textoComecaComE = textoSemEspaco.StartsWith("Esp");
        bool textoTerminaComE = textoSemEspaco.EndsWith("E"); // mesma lógica para o final;
        // Replace() recebe dois parâmetros e substitui na string todos os char do primeiro parâmetro pelo char do segundo;
        string textoSubstituido = textoSemEspaco.Replace('s', '7');
        // Contains() retorna true ou false se a string possui o char/string passado como parâmetro;
        bool existe = textoSemEspaco.Contains("w");
        // Equals() retorna true ou false se a string é identico a string passada como parâmetro;
        bool igual = textoSemEspaco.Equals("Espaço");

        // ===================================

        // OPERAÇOES COM TEXTOS

        // CONCATENAÇÃO;
        string text1 = "Olá";
        string text2 = "Lucas";
        Console.WriteLine(text1 + text2);

        // INTERPOLAÇÃO;
        Console.WriteLine($"{text1}, meu nome é {text2}!");

        // STRINGBUILDER
        // para usar a classe String Builder devemos importar com using System.Text;
        // ela pode começar vazia se dentro dos () for vazio e pode começar já com um valor se dentro dos ("valor") tiver um valor
        StringBuilder StringGrande = new StringBuilder();

        // Adiciona a variavel text1 na instancia da class.
        StringGrande.Append(text1);
        // Adiciona a variavel text2 na instancia da class.
        StringGrande.Append(text2);

        // armazena em uma nova variavel do tipo string a instancia da classe convertida para string com ToString();
        // imprime a string mas alocando menos memória
        string novaStringGrande = StringGrande.ToString();

        // TEXTO SEM CARACTERES SCAPE;
        // \t é reconhecido como um caractere scape que criará um TAB. Assim como \n pula a linha;
        string text3 = "C:\teste";
        // para fugir disso podemos colocar o @ antes das "";
        string text4 = @"C\teste";
        // ou colocar \\ que imprimirá apenas uma. Mas essa forma não é muito dinâmica;
        string text5 = "C:\\teste";


        // STRINGS DINÂMICAS, SEM SEREM ESTÁTICAS;

        // string estatica'
        string estatica = "Sou uma string estática";

        // string dinâmica''
        // perceba que não estamos fazendo a interpolação pois não temos o $ antes das "";
        string dinamica = "Sou uma string dinamica e isso irá mudar => {0} e isso também irá mudar => {1}";

        // com o {0} e {1} dizemos que nessa string esses valores são dinâmicos, podem ser alterados ou formatados;
        // com o Format temos que passar como primeiro parâmetro qual string iremos formatar e depois em ordem de indices, os valores a serem introduzidos na string.
        string dinamicaComValores = string.Format(dinamica, "Valor1", "Valor2");

        Console.WriteLine(dinamicaComValores);
        // Sou uma string dinamica e isso irá mudar => Valor1 e isso também irá mudar => Valor2
    }
}
