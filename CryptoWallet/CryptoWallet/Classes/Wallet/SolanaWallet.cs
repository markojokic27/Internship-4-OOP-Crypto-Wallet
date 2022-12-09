using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallet
{
    public class SolanaWallet:SuportedNonFungibleAssetWallet
    {
        public static List<Guid> SupportedFungibleAssets { get; } = new List<Guid>()
        {
            ListsAndMethods.fungibleAssetsList[0].Address,
            ListsAndMethods.fungibleAssetsList[2].Address,
            ListsAndMethods.fungibleAssetsList[3].Address,
            ListsAndMethods.fungibleAssetsList[4].Address,
            ListsAndMethods.fungibleAssetsList[5].Address,
            ListsAndMethods.fungibleAssetsList[9].Address,
        };
        public static List<Guid> SupportedNonFungibleAssets { get; } = new List<Guid>() {

            ListsAndMethods.nonFungibleAssetsList[0].Address,
            ListsAndMethods.nonFungibleAssetsList[1].Address,
            ListsAndMethods.nonFungibleAssetsList[4].Address,
            ListsAndMethods.nonFungibleAssetsList[5].Address,
            ListsAndMethods.nonFungibleAssetsList[6].Address,
            ListsAndMethods.nonFungibleAssetsList[10].Address,
            ListsAndMethods.nonFungibleAssetsList[11].Address,
            ListsAndMethods.nonFungibleAssetsList[12].Address,
            ListsAndMethods.nonFungibleAssetsList[18].Address,
            ListsAndMethods.nonFungibleAssetsList[19].Address,
        };
        public SolanaWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses) : base(fungibleAssetBalance, nonFungibleAssetAddresses) { }

        public override string ToString()
        {
            double walletValue = 0;
            Guid save;
            foreach (var item in SupportedFungibleAssets)
                foreach (var a in ListsAndMethods.fungibleAssetsList)
                    if (item == a.Address)
                        walletValue += a.ValueInUSD;
            foreach (var item in SupportedNonFungibleAssets)
                foreach (var a in ListsAndMethods.nonFungibleAssetsList)
                    if (item == a.Address)
                    {
                        save = a.AddressOfFungibleAsset;
                        foreach (var b in ListsAndMethods.fungibleAssetsList)
                            if (save == b.Address)
                                walletValue += a.Value * b.ValueInUSD;
                    }
            return base.ToString()
                + $"  Wallet type: Solana\n"
                + $"  Value: {Math.Round(walletValue,2)} USD\n";

        }
        public override string Type(Guid address)
        {
            return "Solana";
        }
        public override void PrintAllAssets()
        {
            base.PrintAllAssets();
        }
        public override List<Guid> GetSupportedAssets()
        {
            List<Guid> list = new List<Guid>();
            list = SupportedFungibleAssets;
            foreach (var item in SupportedNonFungibleAssets)
                list.Add(item);
            return list;
        }
        public override double GetWalletValue()
        {
            double walletValue = 0;
            Guid save;
            foreach (var item in SupportedFungibleAssets)
                foreach (var a in ListsAndMethods.fungibleAssetsList)
                    if (item == a.Address)
                        walletValue += a.ValueInUSD;
            foreach (var item in SupportedNonFungibleAssets)
                foreach (var a in ListsAndMethods.nonFungibleAssetsList)
                    if (item == a.Address)
                    {
                        save = a.AddressOfFungibleAsset;
                        foreach (var b in ListsAndMethods.fungibleAssetsList)
                            if (save == b.Address)
                                walletValue += a.Value * b.ValueInUSD;
                    }
            return walletValue;
        }
    }
}
