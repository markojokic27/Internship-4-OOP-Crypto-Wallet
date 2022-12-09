using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transaction
{
    public class FungibleAssetTransaction:Transaction
    {
        public double StartedBalanceOfTheSendingWallet { get; set; }
        public double EndingBalanceOfTheSendingWallet { get; set; }
        public double StartedBalanceOfTheReceivingWallet { get; set; }
        public double EndingBalanceOfTheReceivingWallet { get; set; }
        int Marker { get; set; }
        public FungibleAssetTransaction(Guid assetAddress, DateTime date, Guid theSendingWalletAddress, Guid theReceivingWalletAddress, int marker, double startedBalanceOfTheSendingWallet, double endingBalanceOfTheSendingWallet, double startedBalanceOfTheReceivingWallet, double endingBalanceOfTheReceivingWallet) : base(assetAddress, date, theSendingWalletAddress, theReceivingWalletAddress)
        {
            StartedBalanceOfTheReceivingWallet = startedBalanceOfTheReceivingWallet; ;
            StartedBalanceOfTheSendingWallet = startedBalanceOfTheSendingWallet;
            EndingBalanceOfTheReceivingWallet = endingBalanceOfTheReceivingWallet;
            EndingBalanceOfTheSendingWallet = endingBalanceOfTheSendingWallet;
            foreach (var wallet in ListsAndMethods.walletList)
                if (wallet.Address == TheSendingWalletAddress)
                {
                    int checker = 0;
                    if (Marker > 0)
                    {
                        foreach (var asset in wallet.FungibleAssetBalance)
                            if (asset.Key == assetAddress)
                            {
                                var a = (asset.Key, asset.Value - Marker);
                                //wallet.FungibleAssetBalance[assetAddress] = a; //Greska 
                                if (wallet.FungibleAssetBalance[assetAddress] == 0)
                                    wallet.FungibleAssetBalance.Remove(assetAddress);
                                checker = 1;
                                break;
                            }
                        if (checker == 0)
                        {
                            wallet.FungibleAssetBalance.Add(assetAddress, Marker);
                        }
                    }
                }
        }
        public override string ToString()
        {

            return base.ToString()
                + $"\n  Kolicina: {Marker}";
                

        }

    }
}
