using CryptoWallet.Classes.Asset;
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

        public override void PrintAllAssets()
        {
            base.PrintAllAssets();

            Console.WriteLine("Non-Fungible imovina:\n");
            foreach (var assetAddress in NonFungibleAssetAddresses)
            {
                Console.WriteLine($"  Adresa: {assetAddress}");
                foreach (var nonFungiA in ListsAndMethods.nonFungibleAssetsList)
                {
                    double ValueOfFungibleAssetWhichIsVolume=0;
                    if (assetAddress == nonFungiA.Address)
                    {
                        Console.WriteLine($"  Ime: {nonFungiA.Name}");
                        string symbol = "";
                        foreach (var symbolAddress in ListsAndMethods.fungibleAssetsList)
                        {
                            if (symbolAddress.Address == nonFungiA.AddressOfFungibleAsset) { 
                                symbol = symbolAddress.Symbol;
                                ValueOfFungibleAssetWhichIsVolume = symbolAddress.ValueInUSD;
                            }
                        }

                        Console.WriteLine($"  Vrijednost u fungible assetu: {nonFungiA.Value} {symbol}");
                        Console.WriteLine($"  Vrijednost: {Math.Round(nonFungiA.Value*ValueOfFungibleAssetWhichIsVolume,2)} USD\n");

                    }
                }

            }

        }
        public override List<Guid> GetSupportedAssets()
        {
            return new List<Guid>();
        }


    }
}
