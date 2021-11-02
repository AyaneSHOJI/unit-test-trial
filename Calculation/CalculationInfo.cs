using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class CalculationInfo
    {       
        public int initialStock = 10;   
        public int currentStock;
        public bool transactionOk = false;

        public static CalculationInfo SellArticle(int articleQte)
        {
            CalculationInfo ci = new CalculationInfo(); // Simulation accès base de données
            if(ci.initialStock >= articleQte)
            {
                ci.currentStock = ci.initialStock - articleQte;
                ci.transactionOk = true;
            }
            else
            {
                // throw new ArgumentException("Article quantity exceeded");
                ci.transactionOk = false;
            }
            return ci;
        }
    }
}
