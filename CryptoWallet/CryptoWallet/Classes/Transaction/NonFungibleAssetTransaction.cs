using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transaction
{
    public class NonFungibleAssetTransaction:Transaction
    {
        public NonFungibleAssetTransaction(Guid assetAddress, DateTime date, Guid theSendingWalletAddress, Guid theReceivingWalletAddress) : base(assetAddress, date, theSendingWalletAddress, theReceivingWalletAddress) { }

    }
}
