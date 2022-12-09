using CryptoWallet.Classes;
using CryptoWallet.Classes.Asset;
using CryptoWallet.Classes.Wallet;
using CryptoWallet.Classes.Transaction;
using CryptoWallet;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        ListsAndMethods.fungibleAssetsList = new List<FungibleAsset>()
        {
            new FungibleAsset("Bitcoin", "BTC",16826.27),
            new FungibleAsset("Ethereum", "ETH", 1231.94),
            new FungibleAsset("Tether", "USDT", 1),
            new FungibleAsset("BNB", "BNB", 283.19),
            new FungibleAsset("USD Coin", "USDC", 0.99),
            new FungibleAsset("Binance USD", "BUSD", 0.998),
            new FungibleAsset("Dogecoin", "DOGE", 0.09589),
            new FungibleAsset("Polygon", "MATIC", 0.8863),
            new FungibleAsset("Cardano", "ADA", 0.3108),
            new FungibleAsset("Litecoin", "LTC", 76.56)
        };
        ListsAndMethods.nonFungibleAssetsList = new List<NonFungibleAsset>()
        {
            new NonFungibleAsset("CryptoPunks",1.048, ListsAndMethods.fungibleAssetsList[1].Address),
            new NonFungibleAsset("Dori Samurai",607, ListsAndMethods.fungibleAssetsList[1].Address),
            new NonFungibleAsset("Azuki",344, ListsAndMethods.fungibleAssetsList[1].Address),
            new NonFungibleAsset("CloneX",0.087, ListsAndMethods.fungibleAssetsList[1].Address),
            new NonFungibleAsset("Nouns",55.02, ListsAndMethods.fungibleAssetsList[3].Address),
            new NonFungibleAsset("REAL BORED APE",7.6, ListsAndMethods.fungibleAssetsList[3].Address),
            new NonFungibleAsset("BORED APE GOLD",5.38, ListsAndMethods.fungibleAssetsList[3].Address),
            new NonFungibleAsset("CRYPTO PANDAS",79.58, ListsAndMethods.fungibleAssetsList[3].Address),
            new NonFungibleAsset("Sorare",10.08, ListsAndMethods.fungibleAssetsList[5].Address),
            new NonFungibleAsset("yOOt",13.875, ListsAndMethods.fungibleAssetsList[5].Address),
            new NonFungibleAsset("Doodles",765.04, ListsAndMethods.fungibleAssetsList[5].Address),
            new NonFungibleAsset("BAYC",134.94, ListsAndMethods.fungibleAssetsList[5].Address),
            new NonFungibleAsset("LILY",1344.83, ListsAndMethods.fungibleAssetsList[7].Address),
            new NonFungibleAsset("RENGA",873.4, ListsAndMethods.fungibleAssetsList[7].Address),
            new NonFungibleAsset("BOOGLE",165.13, ListsAndMethods.fungibleAssetsList[7].Address),
            new NonFungibleAsset("ENS",74.583, ListsAndMethods.fungibleAssetsList[7].Address),
            new NonFungibleAsset("sharx",63.022, ListsAndMethods.fungibleAssetsList[9].Address),
            new NonFungibleAsset("SuperRare",3045.94, ListsAndMethods.fungibleAssetsList[9].Address),
            new NonFungibleAsset("Raft",311.93, ListsAndMethods.fungibleAssetsList[9].Address),
            new NonFungibleAsset("Character",11020.3, ListsAndMethods.fungibleAssetsList[9].Address)
        };
        ListsAndMethods.walletList = new List<Wallet>(){
        new BitcoinWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[0].Address,10 },
            {ListsAndMethods.fungibleAssetsList[2].Address,201 },
            {ListsAndMethods.fungibleAssetsList[3].Address,59 },
            {ListsAndMethods.fungibleAssetsList[4].Address,112 }
        }),
        new BitcoinWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[0].Address,110 },
            {ListsAndMethods.fungibleAssetsList[2].Address,20 },
            {ListsAndMethods.fungibleAssetsList[4].Address,59 }
        }),
        new BitcoinWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[1].Address,77 },
            {ListsAndMethods.fungibleAssetsList[5].Address,169 }
        }),
        new EtheriumWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[0].Address,560 },
            {ListsAndMethods.fungibleAssetsList[2].Address,32 },
            {ListsAndMethods.fungibleAssetsList[7].Address,329 }
        },new List<Guid>
        {
            ListsAndMethods.nonFungibleAssetsList[16].Address,
            ListsAndMethods.nonFungibleAssetsList[17].Address,
            ListsAndMethods.nonFungibleAssetsList[18].Address,
            ListsAndMethods.nonFungibleAssetsList[19].Address,

        }),
        new EtheriumWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[0].Address,3553 },
            {ListsAndMethods.fungibleAssetsList[7].Address,32 },
            {ListsAndMethods.fungibleAssetsList[8].Address,32 },
            {ListsAndMethods.fungibleAssetsList[9].Address,329 }
        },new List<Guid>
        {
            ListsAndMethods.nonFungibleAssetsList[2].Address,
            ListsAndMethods.nonFungibleAssetsList[3].Address,
            ListsAndMethods.nonFungibleAssetsList[4].Address
        }),
        new EtheriumWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[2].Address,1112 },
            {ListsAndMethods.fungibleAssetsList[7].Address,345 },
        },new List<Guid>
        {
            ListsAndMethods.nonFungibleAssetsList[15].Address,
            ListsAndMethods.nonFungibleAssetsList[16].Address,
        }),
        new SolanaWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[0].Address,560 },
            {ListsAndMethods.fungibleAssetsList[2].Address,32 },
            {ListsAndMethods.fungibleAssetsList[4].Address,329 }
        },new List<Guid>
        {
            ListsAndMethods.nonFungibleAssetsList[0].Address,
            ListsAndMethods.nonFungibleAssetsList[1].Address,
            ListsAndMethods.nonFungibleAssetsList[18].Address,
            ListsAndMethods.nonFungibleAssetsList[19].Address,

        }),
        new SolanaWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[2].Address,353 },
            {ListsAndMethods.fungibleAssetsList[4].Address,532 },
            {ListsAndMethods.fungibleAssetsList[3].Address,55 },
            {ListsAndMethods.fungibleAssetsList[9].Address,127 }
        },new List<Guid>
        {
            ListsAndMethods.nonFungibleAssetsList[10].Address,
            ListsAndMethods.nonFungibleAssetsList[11].Address,
            ListsAndMethods.nonFungibleAssetsList[12].Address
        }),
        new SolanaWallet(new Dictionary<Guid, double>
        {
            {ListsAndMethods.fungibleAssetsList[0].Address,1132 },
            {ListsAndMethods.fungibleAssetsList[5].Address,1345 },
        },new List<Guid>
        {
            ListsAndMethods.nonFungibleAssetsList[4].Address,
            ListsAndMethods.nonFungibleAssetsList[5].Address,
        }),
        };
        int command;
        do
        {
            command = Menus.MainMenu();
            switch (command)
            {
                case 1:
                    int commandCreateWallet = 0;
                    commandCreateWallet = Menus.MenuCreateWallet();
                    if (commandCreateWallet == 1) 
                    {
                        Dictionary<Guid, double> newFunigbleAssets= ListsAndMethods.CreateNewFungibleAssets("Bitcoin");
                        ListsAndMethods.walletList.Add(new BitcoinWallet(newFunigbleAssets)); 
                    }
                    if (commandCreateWallet == 2)
                    { 
                        Dictionary<Guid, double> newFunigbleAssets = ListsAndMethods.CreateNewFungibleAssets("Etherium");
                        List<Guid> newNonFungibleList = ListsAndMethods.CreateNewNonFungibleList("Etherium");
                        ListsAndMethods.walletList.Add(new EtheriumWallet(newFunigbleAssets, newNonFungibleList));
                    }
                    if (commandCreateWallet == 3)
                    {
                        Dictionary<Guid, double> newFunigbleAssets = ListsAndMethods.CreateNewFungibleAssets("Solana");
                        List<Guid> newNonFungibleList = ListsAndMethods.CreateNewNonFungibleList("Solana");
                        ListsAndMethods.walletList.Add(new EtheriumWallet(newFunigbleAssets, newNonFungibleList));
                    }

                    break;
                case 2:
                    Console.WriteLine("POPIS SVIH WALLET-A:\n");
                    ListsAndMethods.PrintAll();
                    Guid address = ListsAndMethods.AddressReceiving();
                    int command2 = 0;
                    command2 = Menus.Menu2();
                    switch(command2)
                    {
                        case 0:break;

                        case 1:
                            Console.Clear();
                            ListsAndMethods.PrintAllAssetsForThisAddress(address);
                            Console.WriteLine("\nUnesite bilo koju tipku za povratak na glavni izbornik:");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("  Adrese walleta su:");
                            foreach(var wallet in ListsAndMethods.walletList)
                                Console.WriteLine($"  {wallet.Address}");
                            Guid senderWallet = ListsAndMethods.GetAddressOfSender();
                            Guid receiverWallet;
                            do
                            {
                                receiverWallet = ListsAndMethods.GetAddressOfReceiver();
                            }
                            while (senderWallet==receiverWallet);
                            
                            Guid addressOfAsset=ListsAndMethods.GetAddressOfAAsset(senderWallet);
                            string typeOfTransaction = ListsAndMethods.GetTypeOfTransaction(addressOfAsset);
                            int b = ListsAndMethods.GetNumberOfAsset(senderWallet,addressOfAsset);
                            //mozda sam triba koristit Contains()
                            double senderWalletValueAtStart=0, senderWalletValueAtEnd=0;
                            double receiverWalletValueAtStart = 0, receiverWalletValueAtEnd = 0;
                            foreach (var wallet in ListsAndMethods.walletList)
                                if (senderWallet == wallet.Address)
                                {
                                    senderWalletValueAtStart = wallet.GetWalletValue();
                                    senderWalletValueAtEnd = ListsAndMethods.GetValueAtEnd(addressOfAsset, senderWalletValueAtStart);
                                }
                            foreach (var wallet in ListsAndMethods.walletList)
                                if (receiverWallet == wallet.Address)
                                {
                                    receiverWalletValueAtStart = wallet.GetWalletValue();
                                    receiverWalletValueAtEnd = receiverWalletValueAtStart+(senderWalletValueAtStart-senderWalletValueAtStart);
                                }


                            //Sad napravi nesto za dohvacanje ovih pocetnih i zavrsnih stanja walleta nakon transakcija

                            Console.WriteLine("Jeste li sigurni da zelite izvrsiti transakciju: (y)");
                            string y= Console.ReadLine();
                            if (!String.Equals(y, "y"))
                            {
                                Console.WriteLine("Proces prekinut. (Dodirnite bilo koju tipku za vracanje na glavni izbornik)");
                                Console.ReadKey();
                                break;

                            }

                                


                            if (String.Equals(typeOfTransaction, "FungibleAssetTransaction"))
                                ListsAndMethods.transactionsList.Add(
                                    new FungibleAssetTransaction(addressOfAsset, DateTime.Now, senderWallet, receiverWallet,b, senderWalletValueAtStart, senderWalletValueAtEnd, receiverWalletValueAtStart, receiverWalletValueAtEnd));
                            else
                                ListsAndMethods.transactionsList.Add(
                                    new NonFungibleAssetTransaction(addressOfAsset, DateTime.Now, senderWallet, receiverWallet, b));
                            Console.WriteLine("Transakcija uspjesno obavljena. (Dodirnite bilo koju tipku za vracanje na glavni izbornik)");
                            Console.ReadKey();
                            break;
                            

                        case 3:
                            ListsAndMethods.PrintAllTransaction();
                            break;

                        default: break;
                    }
                    break;
                case 3:
                    command = 0;
                    break;
                case 0:
                    Console.WriteLine("Krivi unos.(Pritisnite bilo koju tipku za vracanje na glavni izbornik)");
                    Console.ReadKey();
                    command = 1;
                    break;
                default:
                    break;
            }
        }
        while (command!=0);
       
    }
}
