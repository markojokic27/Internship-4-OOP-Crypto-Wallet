using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Asset
{
    public class NonFungibleAsset:Asset
    {
        public double Value { get; set; }
        public Guid AddressOfFungibleAsset { get; }

        public NonFungibleAsset(string name, double value, Guid addressOfFungibleAsset) : base(name)
        {
            Value= value;
            AddressOfFungibleAsset = addressOfFungibleAsset;
        }

    }
}
