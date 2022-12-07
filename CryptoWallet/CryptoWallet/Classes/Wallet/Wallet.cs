using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallet
{
    public abstract class Wallet
    { 
        public Guid Address { get; }
        public Dictionary<Guid, double> FungibleAssetBalance { get; }
        public List<Guid> TransactionAddresses { get; }


        public Wallet( Dictionary<Guid, double> fungibleAssetBalance)
        {
            Address = Guid.NewGuid();
            FungibleAssetBalance = fungibleAssetBalance;
            TransactionAddresses = new List<Guid>();
        }
        public override string ToString()
        {

            return $"\n  Wallet address: {Address}\n";
        }
        public virtual string Type(Guid address)
        {
            return "Bitcoin";
        }
    }
}
