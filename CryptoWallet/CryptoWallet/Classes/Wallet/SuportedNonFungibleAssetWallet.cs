using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallet
{
    abstract public class SuportedNonFungibleAssetWallet:Wallet
    {
        public List<Guid> NonFungibleAssetAddresses { get; set; }
        public SuportedNonFungibleAssetWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(fungibleAssetBalance) 
        {
            NonFungibleAssetAddresses = nonFungibleAssetAddresses;
        }

        public virtual string Type(Guid address)
        {
            return "Bitcoin";
        }
    }
}
