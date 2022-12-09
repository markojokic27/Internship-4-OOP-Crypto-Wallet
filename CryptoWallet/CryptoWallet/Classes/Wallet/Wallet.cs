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
        public Dictionary<Guid, double> FungibleAssetBalance { get; set; }
        public List<Guid> TransactionAddresses { get; }
        public double OldValue;

        public Wallet(Dictionary<Guid, double> fungibleAssetBalance)
        {
            Address = Guid.NewGuid();
            FungibleAssetBalance = fungibleAssetBalance;
            TransactionAddresses = new List<Guid>();
            OldValue = GetWalletValue();
        }
        public virtual string ToString()
        {

            return $"\n  Wallet address: {Address}\n";
        }
        public virtual string Type(Guid address)
        {
            return "Bitcoin";
        }

        public virtual void PrintAllAssets()
        {
            Console.WriteLine("Fungible imovina:\n");
            foreach (var asset in FungibleAssetBalance)
            {
                Console.WriteLine($"  Adresa: {asset.Key}");
                foreach (var fungiA in ListsAndMethods.fungibleAssetsList)
                {
                    if (asset.Key == fungiA.Address)
                    {
                        Console.WriteLine($"  Ime: {fungiA.Name}" +
                            $"\n  Oznaka: {fungiA.Symbol}" +
                            $"\n  Vrijednost: {fungiA.ValueInUSD} USD");

                    }
                }
                Console.WriteLine($"  Kolicina: {asset.Value}\n");

            }
        }
        public virtual double GetWalletValue()
        {
            double walletValue = 0;
            return walletValue;
        }
        public virtual List<Guid> GetSupportedAssets()
        {
            return new List<Guid>();

        }

    }
}
