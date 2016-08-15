using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedimentos_Funções
{
    public class Calculadora
    {
        public string val1 { get; set; }
        public string val2 { get; set; }
        private string resultado;

        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
        public string Somar()
        {
            Resultado=(double.Parse(val1) + double.Parse(val2).ToString());
            return Resultado;


        }
        public string Raizquadrada()
        {
            Resultado = (Math.Sqrt(double.Parse(val1))).ToString();
            return Resultado;
        }


    }
}
