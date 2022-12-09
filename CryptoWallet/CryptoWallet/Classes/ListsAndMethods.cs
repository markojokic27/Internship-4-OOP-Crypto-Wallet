using CryptoWallet.Classes;
using CryptoWallet.Classes.Asset;
using CryptoWallet.Classes.Transaction;
using CryptoWallet.Classes.Wallet;
using CryptoWallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public static class ListsAndMethods
    {
        public static List<NonFungibleAsset> nonFungibleAssetsList=new List<NonFungibleAsset>();
        public static List<FungibleAsset> fungibleAssetsList=new List<FungibleAsset>();
        public static List<Wallet> walletList =new List<Wallet>();
        public static List<Transaction> transactionsList=new List<Transaction>();

        public static Dictionary<Guid, double> CreateNewFungibleAssets(string walletType)
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
                Guid newAdress;
                bool h=Guid.TryParse(Console.ReadLine(),out newAdress);
                if (!h)
                {
                    Console.WriteLine("Krivi unos");
                    Console.ReadKey();
                    break;
                }
                   
                if (String.Equals("Bitcoin", walletType))
                {
                    foreach (var address in BitcoinWallet.SupportedFungibleAssets)
                        if (newAdress == address)
                            test = 1;
                }
                if (String.Equals("Etherium", walletType))
                {
                    foreach (var address in EtheriumWallet.SupportedFungibleAssets)
                        if (newAdress == address)
                            test = 1;
                }
                if (String.Equals("Solana", walletType))
                {
                    foreach (var address in SolanaWallet.SupportedFungibleAssets)
                        if (newAdress == address)
                            test = 1;
                }
                foreach(var address in newFunigbleAssets.Keys)//NE IZBACIVA
                    if(address==newAdress)
                    {
                        Console.WriteLine("Krivi unos, taj asset je vec unesen! (unesite bilo koju tipku za povratak na glavni izbornik)");
                        Console.ReadKey();
                        break; 
                    }
                if (test == 0)
                {
                    Console.WriteLine("Krivi unos! (unesite bilo koju tipku za povratak na glavni izbornik)");
                    Console.ReadKey();
                    break;
                }
                int b = 0;
                do
                {
                    Console.WriteLine("Koliko ima te fungible imovine (>1): ");
                    int.TryParse(Console.ReadLine(), out b);
                }
                while (b < 1);
                newFunigbleAssets.Add(newAdress, b);
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
                    Console.WriteLine("Krivi unos (Unesite bilo koju tipku za nastavakk)");
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
                    Console.WriteLine("Krivi unos! (Unesite bilo koju tipku za nastavak)");
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
        public static void PrintAllAssetsForThisAddress(Guid address)
        {
            foreach (var item in ListsAndMethods.walletList)
            {
                if (item.Address == address)
                {
                    item.PrintAllAssets();
                }
            }
        }
        public static Guid GetAddressOfSender()
        {
            Guid a;
            bool h;
            bool check = false;
            do
            {
                Console.WriteLine("\n  Unesite adresu posiljatelja:");
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
        public static Guid GetAddressOfReceiver()
        {
            Guid a;
            bool h;
            bool check = false;
            do
            {
                Console.WriteLine("\n  Unesite adresu primatelja:");
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
        public static Guid GetAddressOfAAsset(Guid senderWallet)
        {
            Guid a;
            bool h;
            bool check = false;
            Console.Clear();
            Console.WriteLine("Moguci odabiri asseta: \n");
            foreach(var item in ListsAndMethods.walletList)
                if(item.Address== senderWallet)
                    item.PrintAllAssets();
            do
            {
                Console.WriteLine("\n  Unesite adresu asseta kojeg saljete:");
                h = Guid.TryParse(Console.ReadLine(), out a);
                foreach (var item in ListsAndMethods.walletList)
                    if (senderWallet == item.Address)
                        foreach(var asset in item.GetSupportedAssets())
                            if(a==asset)
                                check = true;
                if (check == false)
                    h = false;
            }
            while (h == false);
            return a;
        }
        public static string GetTypeOfTransaction(Guid AddressOfAAsset)
        {
            foreach (var asset in ListsAndMethods.fungibleAssetsList)
                if (asset.Address == AddressOfAAsset)
                    return "FungibleAssetTransaction";
            return "NonFungibleAssetTransaction";
        }
        public static double GetValueAtEnd(Guid addressOfAsset, double walletValueAtStart)
        {
            double valueAtEnd=walletValueAtStart;
            foreach(var asset in ListsAndMethods.fungibleAssetsList)
            {
                if(asset.Address==addressOfAsset)
                valueAtEnd += asset.ValueInUSD;
            }
            foreach (var asset in ListsAndMethods.nonFungibleAssetsList)
            {
                if (asset.Address == addressOfAsset)
                    valueAtEnd += asset.ValueInUSD;
            }
            return valueAtEnd;
        }
        public static int GetNumberOfAsset(Guid senderWallet,Guid addressOfAsset)
        {
            double MaxOfAsset = 0;
            foreach (var wallet in ListsAndMethods.walletList)
                if (wallet.Address == senderWallet)
                    foreach (var addres in wallet.FungibleAssetBalance)
                        if (addres.Key == addressOfAsset)
                            MaxOfAsset = addres.Value;

            int b = 0;
            do
            {
                Console.WriteLine("Koliko saljete odabranog fungible asseta (>1 i ne mozete poslati vise nego sto ga imate): ");
                int.TryParse(Console.ReadLine(), out b);
            }
            while (b < 1 && b > MaxOfAsset);
            return b;
        }
        public static void PrintAllTransaction()
        {
            Console.Clear();
            Console.WriteLine("Ispis svih transakcija: ");
            foreach(var t in ListsAndMethods.transactionsList)
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();
        }


    }
}
