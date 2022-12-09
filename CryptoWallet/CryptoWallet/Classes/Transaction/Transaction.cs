using CryptoWallet.Classes.Asset;
using CryptoWallet.Classes.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transaction
{
    abstract public class Transaction
    {
        public Guid Id { get; }
        public Guid AssetAddress { get; }
        public DateTime Date { get; }
        public Guid TheSendingWalletAddress { get; }
        public Guid TheReceivingWalletAddress { get; }
        public bool Revoked { get; set; }


        public Transaction(Guid assetAddress, DateTime date, Guid theSendingWalletAddress, Guid theReceivingWalletAddress)
        {
            Id = Guid.NewGuid();
            AssetAddress = assetAddress;
            Date = date;
            TheSendingWalletAddress = theSendingWalletAddress;
            TheReceivingWalletAddress = theReceivingWalletAddress;
            Revoked = false;                           
        }

        public virtual string ToString()
        {

            return $"\n  ID Transakcije: {Id}\n"+
                $"\n  Datum i vijeme transakcije: {Date}"+
                $"\n  Adresa Walleta posiljatelja: {TheSendingWalletAddress}" +
                $"\n  Adresa Walleta primatelja: {TheReceivingWalletAddress}";
        }

    }
}
