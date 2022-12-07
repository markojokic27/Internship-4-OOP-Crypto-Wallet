using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallet
{
    public class EtheriumWallet : SuportedNonFungibleAssetWallet
    {
        public static List<Guid> SupportedFungibleAssets { get; } = new List<Guid>()
        {
            ListsAndMethods.fungibleAssetsList[0].Address,
            ListsAndMethods.fungibleAssetsList[2].Address,
            ListsAndMethods.fungibleAssetsList[7].Address,
            ListsAndMethods.fungibleAssetsList[8].Address,
            ListsAndMethods.fungibleAssetsList[9].Address
        };
        public static List<Guid> SupportedNonFungibleAssets { get; } = new List<Guid>() { 
            ListsAndMethods.nonFungibleAssetsList[2].Address,
            ListsAndMethods.nonFungibleAssetsList[3].Address,
            ListsAndMethods.nonFungibleAssetsList[4].Address,
            ListsAndMethods.nonFungibleAssetsList[5].Address,
            ListsAndMethods.nonFungibleAssetsList[6].Address,
            ListsAndMethods.nonFungibleAssetsList[15].Address,
            ListsAndMethods.nonFungibleAssetsList[16].Address,
            ListsAndMethods.nonFungibleAssetsList[17].Address,
            ListsAndMethods.nonFungibleAssetsList[18].Address,
            ListsAndMethods.nonFungibleAssetsList[19].Address

        };
        public EtheriumWallet(Dictionary<Guid, double> fungibleAssetBalance, List<Guid> nonFungibleAssetAddresses):base(fungibleAssetBalance, nonFungibleAssetAddresses) { }


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
                                walletValue += a.Value*b.ValueInUSD;
                    }
            return base.ToString()
                + $"  Wallet type: Eterium\n"
                + $"  Value: {walletValue} USD\n";

        }
        public override string Type(Guid address)
        {
            return "Etherium";
        }
    }
}
