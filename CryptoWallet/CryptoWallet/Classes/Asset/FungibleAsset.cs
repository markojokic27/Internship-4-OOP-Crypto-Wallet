using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Asset
{
    public class FungibleAsset:Asset
    {
        public string Symbol { get; set; } //unique
        public double ValueInUSD { get; private set;} 

        public FungibleAsset(string name, string symbol, double valueInUSD) : base(name)
        {
            Symbol = symbol;
            ValueInUSD=valueInUSD;
        }
    }
}
