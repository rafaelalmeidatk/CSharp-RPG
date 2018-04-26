using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Money
    {
        public int HexCoins { get; set; }
        public int Silver { get; set; }
        public int Scrap { get; set; }

        public Money(int hexAmount, int silverAmount, int scrapAmount)
        {
            this.HexCoins = hexAmount;
            this.Silver = silverAmount;
            this.Scrap = scrapAmount;
        }
    }
}
