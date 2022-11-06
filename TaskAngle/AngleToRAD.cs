using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAngle

{
    class AngleToRAD
    {
        int g;
        int m;
        int s;

        
        public int G
        {
            get
            {                            
                return g;                               
            }
            set
            {                
                if (g>359)
                {                    
                    g = 360;
                }
                else if (g < -359)
                {                    
                    g = -360;
                }
                else
                {                    
                    g = value;
                }                
            }
        }
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                G += value / 60;
                m = value % 60;
            }
        }
        public int S
        {
            get
            {
                return s;
            }
            set
            {
                M += value / 60;
                s = value % 60;
            }
        }

        public AngleToRAD(int g, int m, int s)
        {
            this.G = g;
            this.M = m;
            this.S = s;
        }

        public int ToGRad()
        {
            //sG - сумма градусов из исходных данных
            int sG = g + m / 60 + s / 3600;
            return sG;
        }
        public double ToRad()
        {            
            double sG = (double)g + (double)m / 60 + (double)s / 3600;            
            double gR = sG * Math.PI / 180;
            return gR;
        }
    }
}