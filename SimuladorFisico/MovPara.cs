using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimuladorFisico
{
    class MovPara
    {

        private double vi;        
        private double ang;
        private double g;
        /// <summary>
        /// Crea un objeto que calcula los valores correspondientes al movimiento parabolico
        /// </summary>
        /// <param name="velocidad_inicial"></param>
        /// <param name="angulo"></param>
        /// <param name="gravedad"></param>
        public MovPara(double velocidad_inicial, double angulo, double gravedad = 9.81)
        {
            vi = velocidad_inicial;
            ang = angulo;
            g = gravedad;
        }
        /// <summary>
        /// Obtiene la posicion en x en determinado tiempo
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns></returns>
        public double getX(double segundos)
        {
            return (vi*Math.Cos(CGRad(ang)) * segundos);
        }
        /// <summary>
        /// Obtiene la posicion en y en determinado tiempo
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns></returns>
        public double getY(double segundos)
        {
            return (vi * Math.Sin(CGRad(ang)) * segundos - (g / 2) * Math.Pow(segundos, 2));
        }
        /// <summary>
        /// Obtiene la velocidad de la componente x
        /// </summary>
        /// <returns></returns>
        public double Vx()
        {
            return (vi * Math.Cos(CGRad(ang)));
        }
        /// <summary>
        /// Obtiene la velocidad en la componente y en un segundo determinado
        /// </summary>
        /// <param name="segundos"></param>
        /// <returns></returns>
        public double Vy(double segundos)
        {
            return (vi *Math.Sin(CGRad(ang)) - g* segundos);
        }
        /// <summary>
        /// Obtiene el valor maximo de desplazamiento horizontal
        /// </summary>
        public double Xmax
        {
            get
            {
                return (Math.Pow(vi,2)*Math.Sin(2* CGRad(ang)))/g;
            }
        }
        /// <summary>
        /// Obtiene el valor maximo de elevacion vertical
        /// </summary>
        public double Ymax
        {
            get
            {
                return (Math.Pow(vi, 2) * Math.Pow(Math.Sin(CGRad(ang)),2)) / (2*g);
            }
        }
        /// <summary>
        /// Devuelve el tiempo que el cuerpo se mantendra en movimiento
        /// </summary>
        public double Secmax
        {
            get
            {
                return (2*vi*Math.Sin(CGRad(ang)))/g;
            }
        }
        /// <summary>
        /// Convierte grados a radianes
        /// </summary>
        /// <param name="grad"></param>
        /// <returns></returns>
        private double CGRad(double grad)
        {
            return (Math.PI / 180) * grad;
        }
        
    }
}
