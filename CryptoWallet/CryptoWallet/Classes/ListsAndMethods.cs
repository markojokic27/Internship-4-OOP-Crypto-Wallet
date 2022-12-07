using CryptoWallet.Classes;
using CryptoWallet.Classes.Asset;
using CryptoWallet.Classes.Transaction;
using CryptoWallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWallet.Classes.Wallet;

namespace CryptoWallet.Classes.Wallet
{
    public static class ListsAndMethods
    {
        public static List<NonFungibleAsset> nonFungibleAssetsList;
        public static List<FungibleAsset> fungibleAssetsList;
        public static List<Wallet> walletList;

        public static Dictionary<Guid, double> CreateNewFungibleAsset(string walletType)
        {
            Console.Clear();
            Dictionary<Guid, double> newFunigbleAssets = new Dictionary<Guid, double>();
            Console.WriteLine("Moguće funigble imovine za ovaj novcnik: ");
            if (String.Equals("Bitcoin", walletType))
            {
                foreach (var address in BitcoinWallet.SupportedFungibleAssets)
                    Console.WriteLine($"  " + address);
            }
            if (String.Equals("Etherium", walletType))
            {
                foreach (var address in EtheriumWallet.SupportedFungibleAssets)
                    Console.WriteLine($"  " + address);
            }
            if (String.Equals("Solana", walletType))
            {
                foreach (var address in SolanaWallet.SupportedFungibleAssets)
                    Console.WriteLine($"  " + address);
            }
            while (true)
            {
                int test = 0;
                Console.WriteLine("Odaberite koje ce funigble imovine posjedovati novcnik (za prestanak unesite bilo sto osim guida): ");
                Guid a;
                bool h=Guid.TryParse(Console.ReadLine(),out a);
                if (!h)
                {
                    Console.WriteLine("Krivi unos");
                    Console.ReadKey();
                    break;
                }
                   
                if (String.Equals("Bitcoin", walletType))
                {
                    foreach (var address in BitcoinWallet.SupportedFungibleAssets)
                        if (a == address)
                            test = 1;
                }
                if (String.Equals("Etherium", walletType))
                {
                    foreach (var address in EtheriumWallet.SupportedFungibleAssets)
                        if (a == address)
                            test = 1;
                }
                if (String.Equals("Solana", walletType))
                {
                    foreach (var address in SolanaWallet.SupportedFungibleAssets)
                        if (a == address)
                            test = 1;
                }
                if (test == 0)
                {
                    Console.WriteLine("Krivi unos!");
                    break;
                }
                int b = 0;
                do
                {
                    Console.WriteLine("Koliko ima te fungible imovine (>1): ");
                    int.TryParse(Console.ReadLine(), out b);
                }
                while (b < 1);
                newFunigbleAssets.Add(a, b);
            }
            return newFunigbleAssets;
            
        }
        
        
        public static List<Guid> CreateNewNonFungibleList(string walletType)
        {
            Console.Clear();
            List<Guid> newNonFungibleAssets=new List<Guid>();
            Console.WriteLine("Moguće non-funigble imovine za ovaj novcnik: ");
            if (String.Equals("Etherium", walletType))
            {
                foreach (var address in EtheriumWallet.SupportedNonFungibleAssets)
                    Console.WriteLine($"  " + address);
            }
            if (String.Equals("Solana", walletType))
            {
                foreach (var address in SolanaWallet.SupportedNonFungibleAssets)
                    Console.WriteLine($"  " + address);
            }
            while (true)
            {
                int test = 0;
                Console.WriteLine("Odaberite koje ce non-funigble imovine posjedovati novcnik (za prestanak unesite bilo sto osim guida): ");
                Guid a;
                bool h = Guid.TryParse(Console.ReadLine(), out a);
                if (!h)
                {
                    Console.WriteLine("Krivi unos");
                    Console.ReadKey();
                    break;
                }


                if (String.Equals("Etherium", walletType))
                {
                    foreach (var address in EtheriumWallet.SupportedNonFungibleAssets)
                        if (a == address)
                            test = 1;
                }
                if (String.Equals("Solana", walletType))
                {
                    foreach (var address in SolanaWallet.SupportedNonFungibleAssets)
                        if (a == address)
                            test = 1;
                }
                if (test == 0)
                {
                    Console.WriteLine("Krivi unos!");
                    Console.ReadKey();
                    break;
                }
                newNonFungibleAssets.Add(a);
            }
            return newNonFungibleAssets;
        }


        public static void PrintAll()
        {
            foreach(var wallet in ListsAndMethods.walletList)
            {
                Console.WriteLine(wallet.ToString());
            }
        }

        public static Guid AddressReceiving()
        {
            Guid a;
            bool h;
            bool check = false;
            do
            {
                Console.WriteLine("Unesite adresu walleta s kojim zelite nastaviti:");
                h = Guid.TryParse(Console.ReadLine(), out a);
                foreach (var item in ListsAndMethods.walletList)
                    if (a == item.Address)
                        check = true;
                if (check == false)
                    h = false;
            }
            while (h == false);
            return a;
        }
        public static void PrintAllAssets(Guid address)
        {
            foreach (var item in ListsAndMethods.walletList)
            {
                if (item.Address == address)
                {
                    if (String.Equals(item.Type, "Bitcoin"))
                        PrintAllFungibleAsset(address);
                    else
                        PrintAllFungibleAsset(address);
                    PrintAllNonFungibleAsset(address);
                }
            }
        }

            public static void PrintAllFungibleAsset(Guid address)
            {
                foreach (var item in ListsAndMethods.walletList)
                    if (address == item.Address)
                        foreach (var h in item.FungibleAssetBalance)
                        {
                            Console.WriteLine($"\n  Adresa Fungible asseta: {h.Key}\n" +
                                $"  Vrijednost: {h.Value}\n");
                        }
            }
            public static void PrintAllNonFungibleAsset(Guid address)
            {
                foreach (var item in ListsAndMethods.walletList)
                    if (address == item.Address)
                        foreach (var l in ListsAndMethods.nonFungibleAssetsList)
                        {
                            if(l.Address==item.Address)
                            Console.WriteLine($"\n  Adresa NonFungible asseta: {l.Address}\n" +
                                $"  Vrijednost: {l.Value}\n");
                        }
            }
        public static Guid GetAddressOfSender()
        {
            Guid a;
            bool h;
            bool check = false;
            do
            {
                Console.WriteLine("Unesite adresu posiljatelja:");
                h = Guid.TryParse(Console.ReadLine(), out a);
                foreach (var item in ListsAndMethods.walletList)
                    if (a == item.Address)
                        check = true;
                if (check == false)
                    h = false;
            }
            while (h == false);
            return a;
        }
        public static Guid GetARecieverOfSender()
        {
            Guid a;
            bool h;
            bool check = false;
            do
            {
                Console.WriteLine("Unesite adresu posiljatelja:");
                h = Guid.TryParse(Console.ReadLine(), out a);
                foreach (var item in ListsAndMethods.walletList)
                    if (a == item.Address)
                        check = true;
                if (check == false)
                    h = false;
            }
            while (h == false);
            return a;
        }


    }
}
