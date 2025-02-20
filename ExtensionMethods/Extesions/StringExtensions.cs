namespace ExtensionMethods.Extesions;

// Todo o Extension methods precisa ser static, pois não iremos instanciar essa classe
public static class StringExtensions
{
    // Quando colocamos this no parâmetro estamos tranformando o parâmetro num extensionMethod
    // Isso quer dizer que quando chamamos o método Rever() não precisamos colocar o valor como parâmetro
    // O parâmetro será a própria variavel que chamou o método
   public static string Revert(this string value) 
   //Aqui usamos a expressáo para curtar o método com apenas uma linha de retorno. o => é a mesma coisa que return
      => new string(value.ToCharArray().Reverse().ToArray());
}