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

        public FungibleAssetTransaction(Guid assetAddress, DateTime date, Guid theSendingWalletAddress, Guid theReceivingWalletAddress, double startedBalanceOfTheSendingWallet, double endingBalanceOfTheSendingWallet, double startedBalanceOfTheReceivingWallet, double endingBalanceOfTheReceivingWallet):base(assetAddress,date, theSendingWalletAddress,theReceivingWalletAddress)
        {
            StartedBalanceOfTheReceivingWallet= startedBalanceOfTheReceivingWallet; ;
            StartedBalanceOfTheSendingWallet= startedBalanceOfTheSendingWallet;
            EndingBalanceOfTheReceivingWallet= endingBalanceOfTheReceivingWallet;
            EndingBalanceOfTheSendingWallet= endingBalanceOfTheSendingWallet;

        }

    }
}
