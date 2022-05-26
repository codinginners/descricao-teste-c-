using static System.Console;
using System.Collections.Generic;

namespace descricao_teste_c_
{
    class Program
    {
    public static void plusMinus(List<int> arr, ref float positivo, ref float negativo, ref float zero)
        {
            int a = 0, b = 0, c = 0;
            float porcentagem = 0, tamanhoLista = arr.Count;
            
            for (int i = 0; i < tamanhoLista; i++)
            {
                if (arr[i] > 0)
                    a++;             
                else if (arr [i] < 0)
                    b++;
                else if (arr[i] == 0)
                    c++;   
            }
            
            porcentagem = a / tamanhoLista;
            positivo = porcentagem;
            
            porcentagem = b / tamanhoLista;
            negativo = porcentagem;
            
            porcentagem = c / tamanhoLista;
            zero = porcentagem;
        }
        public static void Main()
        {
            List<int> arr = new List<int>(){1,1,0,-1,-1};
            float nPositivo = 0, nNegativo = 0, nZero = 0;
            
            plusMinus(arr, ref nPositivo, ref nNegativo, ref nZero );
            
            WriteLine($@"Porcetagem de numeros:
            Positivos {nPositivo}
            Negativos {nNegativo}
            Zeros {nZero}");        
        }
    }
}
