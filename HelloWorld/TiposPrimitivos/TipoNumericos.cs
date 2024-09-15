using System;

namespace HelloWorld.TiposPrimitivos;

public class TipoNumericos
{
    static void Main() {
        // TIPOS PRIMITIVOS NUMERICOS INTEIROS;
        // VARIAM APENAS O SEU INTERVALO DE VALORES, ALGUNS TIPOS ACEITAM VALORES MENORES E OUTROS MAIORES;

        // inteiros positivos e negativos;
        int numero1 = -7;

        // inteiros unsigned (sem sinal). Apenas inteiros positivos;
        uint numero2 = 1;

        // inteito positivos e negativos com um intervalo muito extenso;
        long numero3 = 8;


        // TIPOS PRIMITIVOS NUMERICOS FLUTUANTES / DECIMAIS
        // VARIAM APENAS A SUA PRECISÃO DAS CASAS FLUTUANTES;

        // decimal com precisão de 15 a 17 digitos após o . (equivalente a 8 bytes);
        double numero4 = 3.14;

        // decimal com precisão de 6 a 9 digitos após o . (equivalente a 4 bytes);
        // precisa adicionar o sufixo f para implicitar que é float;
        float numero5 = 3.14f;

        // decimal com precisão de 28 a 29 digitos após o . (equivalente a 16 bytes);
        // precisa adicionar o sufixo m para implicitar que é um decimal;
        decimal numero6 = 3.14m;
    }
}
