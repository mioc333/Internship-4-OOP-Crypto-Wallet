using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public static class WalletStore
    {
        public static List<Wallet> Wallets { get; } = new List<Wallet>();
        public static void Add(Wallet newWallet)
        {
            Wallets.Add(newWallet);
        }
        public static bool Remove(Wallet wallet) 
        {
            if (Wallets.Contains(wallet))
            {
                Wallets.Remove(wallet);
                return true;
            }
            return false;
        }
        public static void PrintWallets()
        {
            foreach(var wallet in Wallets)
            { 
                Console.WriteLine(wallet.ToString());
            }
        }

    }
}
