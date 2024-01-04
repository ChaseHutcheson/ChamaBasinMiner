using System;
using System.Drawing.Text;

namespace ChamaBasinMiner
{
    internal class Minerals
    {
        String symbol;
        String name;
        double marketRate;
        int tonnage;
        int min = 1;
        int max = 200;

        public Minerals()
        {
            symbol = "";
            name = "";
            marketRate = setMarketRate();
            tonnage = 0;
        }

        public Minerals(String symbol, String name, int tonnage)
        {
            this.symbol = symbol;
            this.name = name;
            this.tonnage = tonnage;
            marketRate = setMarketRate();
        }

        
        private double setMarketRate()
        {
            // Code below needs replaced.
            return 1;
        }
        
        public double getValue()  
        {
            // Code below needs replaced.
            return 1;
        }
        //STUDENT POINT
        public String toString()  
        {
            // Code below needs replaced.
            return "";
        }
    }
}
