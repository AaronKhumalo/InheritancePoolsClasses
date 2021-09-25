using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplishSplushPools
{
    public class Heated_Pool : Basic_Pool //Heated_Pool is a Child Class
    {

        private double HeatingCost;

        public double propHeatingCost
        {
            get { return HeatingCost; }
            set { HeatingCost = value; }
        }


        public Heated_Pool()
        {
            base.propLength = 0;
            base.propWidth = 0;
            base.propDepth = 0;
            propHeatingCost = 0;

        }
        public Heated_Pool(double L, double W, double D, double hc)
        {
            base.propLength = L;
            base.propWidth = W;
            base.propDepth = D;
            propHeatingCost = hc;

        }

        public override double CalcBasicCost()
        {
            return (base.CalcBasicCost() + propHeatingCost);
        }





    }
}
