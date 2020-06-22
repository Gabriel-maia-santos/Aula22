namespace Aula22
{
    public class Conversor
    {
        public static float CotacaoDolar = 1.5f;
        public static float CotacaoEuro = 5.93f; 
        public static float CotacaoEuro2 = 1.13f;
        public static float ConverterDolarParaReal(float valor){
            return valor * CotacaoDolar;
        }

        public static float ConverterRealparaDolar(float valor){
            return valor / CotacaoDolar;
        }

        public static float ConverterRealparaEuro(float valor){
            return valor * CotacaoEuro;
        }

         public static float ConverterEuroparaReal(float valor){
            return valor / CotacaoEuro;
        }

         public static float ConverterDolarParaEuro(float valor){
            return valor * CotacaoEuro2;
        }

        public static float ConverterEuroParaDolar(float valor){
            return valor / CotacaoEuro2;
        }
    }
}