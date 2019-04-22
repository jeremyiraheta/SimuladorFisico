using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimuladorFisico
{
    class FCentri
    {
        double r, m, v, p, a;
        public FCentri(double masa, double radio, double periodo = 0, double velocidad = 0, double aceleracion = 0)
        {
            m = masa;
            r = radio;
            p = periodo;
            v = velocidad;
            a = aceleracion;
            if (v == 0 && a != 0)//obtiene la velocidad de la aceleracion
                v = Math.Sqrt(a * r);
            if (p == 0 && v == 0 && a == 0)
                throw new Exception("Debe definirse uno de los 3 parametros opcionales");
        }
        /// <summary>
        /// Aceleracion si no hay definida velocidad usa la formula A = (4*PI^2*R)/(T^2) si no usa A = (V^2)/R
        /// </summary>
        public double Aceleracion
        {
            get
            {
                if (v == 0)
                    return (4 * Math.Pow(Math.PI, 2) * r) / Math.Pow(p, 2);
                else if (a == 0)
                    return Math.Pow(v, 2) / r;
                else
                    return a;
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
        public PointF Posicion(double segundos)
        {
            return new PointF((float)(r * Math.Cos(VelocidadAngular * segundos)), (float)(r * Math.Sin(VelocidadAngular * segundos)));
        }

        /// <summary>
        /// Posicion en X con respecto al plano cartesiano
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public float X(double grados, float xi = 0)
        {
            return xi + (float)(r * Math.Cos(GradToRad(grados)));
        }
        /// <summary>
        /// Posicion en Y con respecto al plano cartesiano
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public float Y(double grados, float yi = 0)
        {
            return yi + (float)(r * Math.Sin(GradToRad(grados)));
        }
        /// <summary>
        /// Determina el angulo a los n segundos
        /// </summary>
        /// <param name="nsegundos"></param>
        /// <param name="anguloinicial"></param>
        /// <returns></returns>
        public double AnguloEnNSegundos(double nsegundos, double anguloinicial)
        {
            return anguloinicial + VelocidadAngular * nsegundos;
        }
        public double Radio
        {
            get
            {
                return r;
            }
        }
        /// <summary>
        /// Convierte grados a radianes
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public static double GradToRad(double grados)
        {
            return grados * (Math.PI / 180);
        }
    }
}
