using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora
{
    class Calculadora
    {
        private List<double> listNumero = new List<double>();

        public void addNumero(double num)
        {
            this.listNumero.Add(num);
        }

        public double somar()
        {
            double resultado = 0;
            foreach (double numero in this.listNumero)
            {
                resultado += numero;
            }
            this.listNumero.Clear();
            return resultado;

        }

        public double subtrair()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado -= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double multiplicar()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = resultado * numero;
            }
            this.listNumero.Clear();
            return resultado;

        }

        public double dividir()
        {
            double resultado = this.listNumero[0];
            resultado = 1;
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = resultado / numero;
            }
            this.listNumero.Clear();
            return resultado;

        }

        public double raiz()
        {
            double resultado = this.listNumero[0];
            resultado = 1;
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = Math.Sqrt(resultado);
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double logaritmo()
        {
            double resultado = this.listNumero[0];
            resultado = 1;
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = Math.Log(resultado);
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double cosseno()
        {
            double resultado = this.listNumero[0];
            resultado = 1;
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = Math.Cos(resultado);
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double arredondamentoPraBaixo()
        {
            double resultado = this.listNumero[0];
            resultado = 1;
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado = Math.Floor(resultado);
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double 
    }
}