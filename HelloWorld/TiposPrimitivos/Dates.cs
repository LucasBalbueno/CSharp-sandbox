using System.Globalization;

namespace HelloWorld.TiposPrimitivos;

public class Dates
{
    static void Main () {
        //  DATAS 
        // Dentro das datas temos duas funções principais, o DateOnly() e o DateTime();
        // A principal diferença deles é que o DateOnly sempre mostrará a data que foi definida e não pode ser formatada nem alterada por fusos horáios;
        // Já o DateTime mostrará uma data que pode ser formatada, mostrar outro dia, a data atual e ser dinâmica com os fusos;

        // quando não passamos nenhum parâmetro pegará a data padrão de 01/01/0001;
        // se passarmos parâmetro ela sempre será a data definida;
        DateOnly data = new DateOnly(2024, 12, 1);

        // mostra a data no formato curto (12/1/2024)
        string dataEmTexto1 = data.ToShortDateString();
        // mostra a data longa (nome do dia, nome do mes e o ano)
        string dataEmTexto2 = data.ToLongDateString();
        // ToString() retorna a mesma coisa do formato curto se não passamos parâmetros;
        // ToString() pode receber dois parâmetros, a formatação e a linguagem culture;
        // para fazer isso usamos new CultureInfo("linguagem");
        string dataEmTexto3 = data.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

        // Console.WriteLine(data);
        // Console.WriteLine(dataEmTexto3);
        // Console.WriteLine(dataEmTexto2);
        // Console.WriteLine(dataEmTexto3);

        // o dateTIme quando colocamos apenas data como parâmetro ele tambem passará o tempo mas com padrão 00h
        // mas também podemos passar a hora como parâmetro;
        DateTime data1 = new DateTime(2024, 12, 1, 16, 47, 34);

        // Com Today pegamos o dia atual e o horário vem padrão 00h;
        DateTime hoje = DateTime.Today;

        // Com now pegamos a data e hora atual da máquina (do servidor);
        // repare que não usamos o new;
        DateTime agora = DateTime.Now;

        // Com UtcNow pegamos a dara e a hora 0 dos fusos horários (para chegar ao horário do BR -3h por exemplo)
        DateTime agoraUTC = DateTime.UtcNow;

        // Também tem como adicionar dias, meses, anos, horas, minutos e segundos no DateTime;
        DateTime novaData1 = agoraUTC.AddDays(1); // -1 para retroceder o dia;
        DateTime novaData2 = agoraUTC.AddMonths(1);

        Console.WriteLine(novaData1);
        Console.WriteLine(novaData2);
    }
}
