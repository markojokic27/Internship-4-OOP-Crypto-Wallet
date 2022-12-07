using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public static class Menus
    {
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("  GLAVNI IZBORNIK\n" +
                "  1 - Kreiraj wallet\n" +
                "  2 - Pristupi walletu\n" +
                "  0 - Izlaz iz aplikacije\n" +
                "  Unesite broj kraj zeljne opcije: ");
            int.TryParse(Console.ReadLine(), out int command);
            return command;
        }
        public static int MenuCreateWallet()
        {
            Console.Clear();
            Console.WriteLine("  IZBOR TIPA WALLET-A\n" +
                "  1 - Bitcoin wallet\n" +
                "  2 - Etherium wallet\n" +
                "  3 - Solana wallet\n" +
                "  0 - Povratak na glavni izbornik\n");
            int command;
            do
            {
                Console.WriteLine("  Unesite broj kraj zeljne opcije: ");
                int.TryParse(Console.ReadLine(), out command);
            }
            while (command >3 && command < 0);
            return command;
        }
        public static int Menu2()
        {

            Console.Clear();
            Console.WriteLine("  IZBOR RADNJI S WALLET-OM\n" +
                "  1 - Portfolio\n" +
                "  2 - Transfer\n" +
                "  3 - Povijest Transakcija\n" +
                "  0 - Povratak na glavni izbornik\n");
            int command;
            do
            {
                Console.WriteLine("  Unesite broj kraj zeljne opcije: ");
                int.TryParse(Console.ReadLine(), out command);
            }
            while (command > 3 && command < 0);
            return command;
        }
    }
}
