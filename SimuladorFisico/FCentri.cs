using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimuladorFisico
{
    /// <summary>
    /// Realiza los calculos matematicos para calcular posicion de proyectil en N segundos para el MCU
    /// </summary>
    class FCentri
    {
        double r, m, v, p, a;
        /// <summary>
        /// Crea instancia del objeto que hace los calculos del movimiento circular uniforme para calcular fuerza centrifuga,
        /// Los dos primero parametros son obligatorios
        /// El tercero debe elejirse almenos uno de los parametros opcionales
        /// </summary>
        /// <param name="masa">Masa del proyectil</param>
        /// <param name="radio">Radio entre el centro del movimiento y el proyectil</param>
        /// <param name="periodo">Segundos que tarda en dar una vuelta completa</param>
        /// <param name="velocidad">Velocidad tangencial</param>
        /// <param name="aceleracion">Constante de Aceleracion</param>
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
        /// <param name="segundos">Segundos totales transcurridos</param>
        /// <param name="posicioninicial">Posicion inicial</param>
        /// <returns></returns>
        public PointF Posicion(double segundos)
        {
            return new PointF((float)(r * Math.Cos(VelocidadAngular * segundos)), (float)(r * Math.Sin(VelocidadAngular * segundos)));
        }
        /// <summary>
        /// Radio
        /// </summary>
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

        public Centrifuga Centrifuga
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
