using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TddDio
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

         public int Subtrair(int val1, int val2)
        {
             int res = val1 - val2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

         public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

         public int Dividr(int val1, int val2)
        {
             int res = val1 / val2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        //RETORNAR O HISTORICO
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}