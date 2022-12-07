using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public static class Metode
    {
        public static void Portfolio(string u)
        {
            foreach (var wallet in WalletStore.Wallets)
            {
                if (wallet.Adresa.ToString() == u)
                {
                    Console.WriteLine($"Ukupna vrijednost svih asseta u USD: {wallet.UkupnaVrijednostSvihAssetaKojePosjedujeuUSD}\n");
                    Console.WriteLine($"Fungible Asseti: \n");
                    foreach (var fungibleAsset in wallet.BalansiFungibleAsseta)
                    {
                        foreach (var k in wallet.BalansiFungibleAsseta.Keys)
                        {
                            foreach (var t in AssetsStore.FungibleAssets)
                            {
                                if (k == t.Adresa)
                                    Console.WriteLine(t.ToString());
                            }
                        }
                    }
                }
            }
        }
        public static void Transfer(string u)
        {
            foreach (var wallet in WalletStore.Wallets)
            {
                if (wallet.Adresa.ToString() == u)
                {
                    string unos = "";
                    bool netocanUnosAdrese = true;

                    do
                    {

                        Console.WriteLine("Unesite adresu walleta kojem saljete asset: ");
                        unos = Console.ReadLine();
                        foreach (var wallet1 in WalletStore.Wallets)
                        {
                            if (wallet1.Adresa.ToString() == unos)
                            {
                                //unos asseta
                                Console.WriteLine("Unesite adresu asseta kojeg zelite prenijeti: ");
                                string adresaAssetaKojiSePrenosi = Console.ReadLine();
                                foreach (var fungibleAsset in AssetsStore.FungibleAssets)
                                {
                                    if (adresaAssetaKojiSePrenosi == fungibleAsset.Adresa.ToString())
                                    {
                                        Console.WriteLine("Unesite kolicinu: ");
                                        string kolicinaString = Console.ReadLine();
                                        double kolicina = double.Parse(kolicinaString);
                                        wallet.BalansiFungibleAsseta[fungibleAsset.Adresa] = wallet.BalansiFungibleAsseta[fungibleAsset.Adresa] - kolicina;
                                        if (wallet1.BalansiFungibleAsseta.ContainsKey(fungibleAsset.Adresa))
                                            wallet1.BalansiFungibleAsseta[fungibleAsset.Adresa] = wallet1.BalansiFungibleAsseta[fungibleAsset.Adresa] + kolicina;
                                        else
                                        {
                                            wallet1.BalansiFungibleAsseta.Add(fungibleAsset.Adresa, kolicina);
                                        }

                                        FungibleAssetTransakcija transakcija = new FungibleAssetTransakcija(fungibleAsset.Adresa, DateTime.Now, wallet.Adresa, wallet1.Adresa);
                                        transakcija.PocetniBalansKojiPrima = wallet1.BalansiFungibleAsseta[fungibleAsset.Adresa] - kolicina;
                                        transakcija.KrajnjiBalansKojiPrima = wallet1.BalansiFungibleAsseta[fungibleAsset.Adresa];
                                        transakcija.PocetniBalansKojiSalje = wallet.BalansiFungibleAsseta[fungibleAsset.Adresa] + kolicina;
                                        transakcija.PocetniBalansKojiSalje = wallet.BalansiFungibleAsseta[fungibleAsset.Adresa];
                                    }
                                }
                                foreach (var nonFungibleAsset in AssetsStore.NonFungibleAssets)
                                {
                                    if (adresaAssetaKojiSePrenosi == nonFungibleAsset.Adresa.ToString())
                                    {



                                    }
                                }
                                netocanUnosAdrese = false;
                            }
                        }

                    }
                    while (netocanUnosAdrese);
                }
            }
        }
        public static void PovijestTransakcija() { }
        public static void OpozoviTransakciju() { }
        public static void IzadiIzPrograma()
        {
            Console.Clear();
            Console.WriteLine("Izasli ste iz aplikacije.");
        }
        public static void KreirajWallet()
        {
            string unos;
            do
            {
                Console.WriteLine("Odaberi:\n1-BitCoin wallet\n2-Ethereum walletu\n3-Solana walletu");
                unos = Console.ReadLine();
            }
            while (unos != "1" && unos != "2" && unos != "3");
            int odabir = int.Parse(unos);
            switch (odabir)
            {
                case 1:
                    Console.WriteLine("Odabrali ste BitCoin wallet.");
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste Ethereum wallet.");
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste Solana wallet.");
                    break;
            }

        }
        public static void PristupiWalletu()
        {
            foreach (var wallet in WalletStore.Wallets)
            {
                Console.WriteLine($"Tip: {wallet.typeOfWallet}\n"
                    + wallet.ToString()
                    + $"Postotak pada/povečanja ukupne USD vrijednosti svih asseta koje posjeduje u odnosu na prošli put kada se ta informacija prikazala: ");
            }
            string unos = "";
            bool netocanUnosAdrese = true;
            do
            {
                Console.WriteLine("Unesite adresu walleta kojeg zelite koristit: ");
                unos = Console.ReadLine();
                foreach (var wallet in WalletStore.Wallets)
                {
                    if (wallet.Adresa.ToString() == unos)
                    {
                        netocanUnosAdrese = false;
                    }
                }

            }
            while (netocanUnosAdrese);
            string unos1;
            do
            {
                Console.WriteLine("Odaberi:\n1-Portfolio\n2-Transfer\n3-Povijest transakcija\n4-Opozovi transakciju\n");
                unos1 = Console.ReadLine();
            }
            while (unos1 != "1" && unos1 != "2" && unos1 != "3" && unos1 != "4");
            int odabir = int.Parse(unos1);
            switch (odabir)
            {
                case 1:
                    Portfolio(unos);
                    break;
                case 2:
                    Transfer(unos);
                    break;
                case 3:
                    PovijestTransakcija();
                    break;
                case 4:
                    OpozoviTransakciju();
                    break;
            }


        }
        public static void Izbornik()
        {
            string unos;
            do
            {
                Console.WriteLine("Odaberi:\n1-Kreiraj wallet\n2-Pristupi walletu\n3-Izadi iz aplikacije");
                unos = Console.ReadLine();
            }
            while (unos != "1" && unos != "2" && unos != "3");
            int odabir = int.Parse(unos);
            switch (odabir)
            {
                case 1:
                    KreirajWallet();
                    Izbornik();
                    break;
                case 2:
                    PristupiWalletu();
                    Izbornik();
                    break;
                case 3:
                    IzadiIzPrograma();
                    break;
            }
        }
    }
}
