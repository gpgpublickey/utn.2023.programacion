using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private IOperacion Suma;
        private IOperacion Resta;
        private IOperacion Multiplicacion;
        private IOperacion Division;
        private IOperacion Modulo;
        private IOperacion Potencia;

        public Calculadora( IOperacion suma, 
                            IOperacion resta, 
                            IOperacion multiplicacion, 
                            IOperacion division,
                            IOperacion modulo,
                            IOperacion potencia) {
            this.Suma = suma;
            this.Resta = resta;
            this.Multiplicacion = multiplicacion;
            this.Division = division;   
            this.Modulo = modulo;   
            this.Potencia = potencia;
        }

        public double Sumar(double value1, double value2) { 
            return Suma.RealizarCalculo(value1, value2);
        }

        public double Restar(double value1, double value2)
        {
            return Resta.RealizarCalculo(value1, value2);
        }

        public double Multiplicar(double value1, double value2)
        {
            return Multiplicacion.RealizarCalculo(value1, value2);
        }

        public double Dividir(double value1, double value2)
        {
            return Division.RealizarCalculo(value1, value2);
        }

        public double CalcularModulo(double value1, double value2)
        {
            return Modulo.RealizarCalculo(value1, value2);
        }

        public double CalcularPotencia(double value1, double value2)
        {
            return Potencia.RealizarCalculo(value1, value2);
        }


    }
}
