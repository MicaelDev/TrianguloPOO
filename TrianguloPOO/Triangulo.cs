using System;

namespace TrianguloPOO
{
    class Triangulo
    {
        //Atributos da classe
        public double A;
        public double B;
        public double C;

        //Método da classe
        public double CalculaArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
