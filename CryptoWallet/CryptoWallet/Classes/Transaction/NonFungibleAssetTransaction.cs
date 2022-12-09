using CryptoWallet.Classes.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transaction
{
    
    public class NonFungibleAssetTransaction:Transaction
    {
        int Marker { get; set; }
        public NonFungibleAssetTransaction(Guid assetAddress, DateTime date, Guid theSendingWalletAddress, Guid theReceivingWalletAddress,int marker) : base(assetAddress, date, theSendingWalletAddress, theReceivingWalletAddress)
        { 
            Marker = marker;

            
        }
        public override string ToString()
        {

            return base.ToString()
                + $"\n  Adresa NonFungible asseta: {AssetAddress}\n";

        }

    }
}
