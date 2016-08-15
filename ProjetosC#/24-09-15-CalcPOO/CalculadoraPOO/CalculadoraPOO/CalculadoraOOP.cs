using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
   public class CalculadoraOOP
    {
        // private double Valor1;
        #region Atributos e Propriedades
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }
        #endregion 
        public double Somar()
        {
            Resultado = Valor1 + Valor2;
            return Resultado;

        }
        public double Subtrair()
        {
            Resultado = Valor1 - Valor2;
            return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = Valor1 * Valor2;
            return Resultado;
        }
        public double Dividir()
        {
            Resultado = Valor1 / Valor2;
            return Resultado;
        }
        public double Quadrado()
        {
            Resultado = Valor1 * Valor1;
            return Resultado;
        }
        public double Retangulo()
        {
            Resultado = Valor1 * Valor2;
            return Resultado;
        }
       public double Circulo()
        {
            Resultado = 3.14 * Valor1;
            return Resultado;
        }

       //Isso Calcula raiz quadrada do valor 1

        public double RaizQuadrada()
        {
            return Math.Sqrt(Valor1);
        }
    }
   
}


