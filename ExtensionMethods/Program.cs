using ExtensionMethods.Extesions;

var mensagem = "Hello World!";

// Perceba que não precisamos passar parâmetro para o Revert(), a própria variável mensagem que foi quem chamou será o parâmetro  
var novaMensagem = mensagem.Revert();

Console.WriteLine(novaMensagem);