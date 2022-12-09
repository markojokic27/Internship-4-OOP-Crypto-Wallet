using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallet
{
    public class BitcoinWallet : Wallet
    {
        public static List<Guid> SupportedFungibleAssets { get; } = new List<Guid>()
        {
            ListsAndMethods.fungibleAssetsList[0].Address,
            ListsAndMethods.fungibleAssetsList[1].Address,
            ListsAndMethods.fungibleAssetsList[2].Address,
            ListsAndMethods.fungibleAssetsList[3].Address,
            ListsAndMethods.fungibleAssetsList[4].Address,
        };
        public BitcoinWallet(Dictionary<Guid, double> fungibleAssetBalance) : base(fungibleAssetBalance) { }
        public override string ToString()
        {
            return base.ToString()
                + $"  Wallet type: Bitcoin\n"
                + $"  Value: {GetWalletValue} USD\n";

        }
        public override double GetWalletValue(){
            double walletValue = 0;
            foreach (var item in SupportedFungibleAssets)
                foreach (var a in ListsAndMethods.fungibleAssetsList)
                    if (item == a.Address)
                        walletValue += a.ValueInUSD;
            return walletValue;
        }
        public override string Type(Guid address)
        {
            return "Bitcoin";
        }
        public override void PrintAllAssets()
        {
            base.PrintAllAssets();
        }
        public override List<Guid> GetSupportedAssets()
        {
            return SupportedFungibleAssets;
        }




    }
}
