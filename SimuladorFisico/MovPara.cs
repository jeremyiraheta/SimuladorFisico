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
        public MovPara(double velocidad_inicial, double angulo, double gravedad = 9.81)
        {
            vi = velocidad_inicial;
            ang = angulo;
            g = gravedad;
        }
        public double getX(double segundos)
        {
            return (vi*Math.Cos(CGRad(ang)) * segundos);
        }
        public double getY(double segundos)
        {
            return (vi * Math.Sin(CGRad(ang)) * segundos - (g / 2) * Math.Pow(segundos, 2));
        }
        public double Vx()
        {
            return (vi * Math.Cos(CGRad(ang)));
        }
        public double Vy(int segundos)
        {
            return (vi *Math.Sin(CGRad(ang)) - g* segundos);
        }
        public double Xmax
        {
            get
            {
                return (Math.Pow(vi,2)*Math.Sin(2* CGRad(ang)))/g;
            }
        }
        public double Ymax
        {
            get
            {
                return (Math.Pow(vi, 2) * Math.Pow(Math.Sin(CGRad(ang)),2)) / (2*g);
            }
        }
        public double Secmax
        {
            get
            {
                return (2*vi*Math.Sin(CGRad(ang)))/g;
            }
        }
        
        private double CGRad(double grad)
        {
            return (Math.PI / 180) * grad;
        }
        
    }
}
