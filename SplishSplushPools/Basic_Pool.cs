using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplishSplushPools
{
    public class Basic_Pool //Parent Class
    {
        private double Length;
        private double Width;
        private double Depth;
       

        public double propLength
        {
            get { return Length; }
            set { Length = value; }
        }
        public double propWidth
        {
            get { return Width; }
            set { Width = value; }
        }
        public double propDepth
        {
            get { return Depth; }
            set { Depth = value; }
        }
        

        public Basic_Pool()
        {
            propLength = 0;
            propWidth = 0;
            propDepth = 0;
            
        }

        public Basic_Pool(double L, double W, double D)
        {
            propLength = L;
            propWidth = W;
            propDepth = D;
            

        }



        public double CalcVolume()
        {
            return (propLength * propWidth * propDepth);
        }
        public double CalcNumberOfLitres()
        {
            return (CalcVolume() / 0.13368);
        }

        public double CalcArea()
        {
            return (propLength * propWidth);
        }
        public virtual double CalcBasicCost()
        {
            return (CalcArea() * 500);
        }
      


    }
}
