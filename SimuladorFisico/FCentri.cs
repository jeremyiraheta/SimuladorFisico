using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFisico
{
    class FCentri
    {
        double r, m, v, p;
        public FCentri(double masa, double radio, double periodo = 0, double velocidad = 0)
        {
            m = masa;
            r = radio;
            p = periodo;
            v = velocidad;
            if (p == 0 && v == 0)
                throw new Exception("Debe definirse uno de los 2 parametros opcionales");
        }

        public double Aceleracion
        {
            get
            {
                if (v == 0)
                    return (4 * Math.Pow(Math.PI, 2) * r) / Math.Pow(p, 2);
                else
                    return Math.Pow(v, 2) / r;                
            }
        }
        /// <summary>
        /// Magnitud del vector de fuerza centrifuga 
        /// </summary>
        public double FuerzaCentrifuga
        {
            get
            {                
                return (m * Aceleracion);
            }
        }
        /// <summary>
        /// Tiempo en completar un ciclo completo
        /// </summary>
        public double Periodo
        {
            get
            {
                if (p == 0)
                    return (2 * Math.PI * r) / v;
                else
                    return p;
            }
        }
        /// <summary>
        /// Ciclo completado en un determinado tiempo
        /// </summary>
        public double Frecuencia
        {
            get
            {
                return 1 / Periodo;
            }
        }
        /// <summary>
        /// Arco recorrido expresado en radianes por unidad de tiempo
        /// </summary>
        public double VelocidadAngular
        {
            get
            {
                return 2 * Math.PI * Frecuencia;
            }
        }
        /// <summary>
        /// Velocidad tangente a la trayectoria
        /// </summary>
        public double VelocidadTangencial
        {
            get
            {
                return VelocidadAngular * r;
            }
        }
        /// <summary>
        /// Devuelve la posicion del objeto en un determinado tiempo
        /// </summary>
        /// <param name="segundos"></param>
        /// <param name="posicioninicial"></param>
        /// <returns></returns>
        public System.Drawing.Point Posicion(double segundos, System.Drawing.Point posicioninicial)
        {
            return new System.Drawing.Point((int)(posicioninicial.X + r * Math.Cos(VelocidadAngular * segundos)), (int)(posicioninicial.Y + r * Math.Sin(VelocidadAngular * segundos)));
        }

        /// <summary>
        /// Posicion en X con respecto al plano cartesiano
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public int X(double grados, int xi = 0)
        {
            return xi + (int)(r * Math.Cos(GradToRad(grados)));
        }
        /// <summary>
        /// Posicion en Y con respecto al plano cartesiano
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public int Y(double grados, int yi = 0)
        {
            return yi + (int)(r * Math.Sin(GradToRad(grados)));
        }
        /// <summary>
        /// Convierte grados a radianes
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public double GradToRad(double grados)
        {
            return grados * (Math.PI / 180);
        }
    }
}
