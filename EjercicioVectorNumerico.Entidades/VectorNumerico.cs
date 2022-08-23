using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVectorNumerico.Entidades
{
    public class VectorNumerico
    {

        private int[] Numeros;
        public int Dimension { get; set; }
        public VectorNumerico(int dimension)
        {
            Dimension = dimension;
        }

        public VectorNumerico():this(10)
        {

        }
        public bool Validar()
        {
            return Dimension > 1;
        }

        private void  NumeroAzar()
        {
            int NumeroAzar=0;
            Random random = new Random();
            for (int i = 1; i < 50; i++)
            {
                NumeroAzar = random.Next(1, 50);
            }
            Console.WriteLine($"{NumeroAzar}");
        }

        public void MostrarContenido()
        {
            Numeros = new int[Dimension];
            var numeroA = 1;
            var numeroB = 2;
            Numeros[0] = numeroA;
            Numeros[1] = numeroB;
            for (int contador = 2; contador < Dimension; contador++)
            {
                Numeros[contador] = Numeros[contador - 2] + Numeros[contador - 1];
            }
        }
        public override string ToString()
        {
            StringBuilder linea = new StringBuilder();
            foreach (var numero in Numeros)
            {
                linea.AppendLine($"{numero}");
            }
            return linea.ToString();
        }

        public string MostrarEnLinea()
        {
            StringBuilder vector = new StringBuilder();
            foreach (var numero in Numeros)
            {
                vector.Append($"{numero}");
            }
            return vector.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj==null  || !(obj is VectorNumerico))
            {
                return false;
            }
            return this.Dimension == ((VectorNumerico)obj).Dimension;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(VectorNumerico dimension1,VectorNumerico dimension2)
        {
            return dimension1.Equals(dimension2);
        }

        public static bool operator !=(VectorNumerico dimension1, VectorNumerico dimension2)
        {
            return !(dimension1 == dimension2);
        }

        public static VectorNumerico operator +(VectorNumerico dimension, VectorNumerico dimension2)
        {
            return dimension + dimension2;
        }

        public static VectorNumerico operator -(VectorNumerico dimension, VectorNumerico dimension2)
        {
            return dimension - dimension2;
        }

        public static VectorNumerico operator *(VectorNumerico vectorNumerico, int numero)
        {
            return vectorNumerico * numero;
        }

    

    }
}
