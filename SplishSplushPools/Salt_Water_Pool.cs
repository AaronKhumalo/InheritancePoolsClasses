using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplishSplushPools
{
    public class Salt_Water_Pool : Basic_Pool //Salt_Water_Pool is a Child Class
    {


        public Salt_Water_Pool()
        {
            base.propLength = 0;
            base.propWidth = 0;
            base.propDepth = 0;
        }
        public Salt_Water_Pool(double L, double W, double D)
        {
            base.propLength = L;
            base.propWidth = W;
            base.propDepth = D;
        }

        public double CalcSaltCost()
        {
            return (base.CalcBasicCost()*15/100);
        }
        public override double CalcBasicCost()
        {
            return (base.CalcBasicCost() + CalcSaltCost());
        }

    }
}
