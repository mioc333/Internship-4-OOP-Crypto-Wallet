using DOMACI5;
using System.Globalization;
using System;

namespace DOMACI5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fungibleAsset1 = new FungibleAsset("BitCoin", "BTC", 17101.38);
            var fungibleAsset2 = new FungibleAsset("Ethereum", "ETH", 1279.44);
            var fungibleAsset3 = new FungibleAsset("Tether", "USDT", 1);
            var fungibleAsset4 = new FungibleAsset("Dodgecoin", "DOGE", 0.1042);
            var fungibleAsset5 = new FungibleAsset("Polkadot", "DOT", 5.56);
            var fungibleAsset6 = new FungibleAsset("Litecoin", "LTC", 77.09);
            var fungibleAsset7 = new FungibleAsset("Solana", "SOL", 13.63);
            var fungibleAsset8 = new FungibleAsset("Cosmos", "ATOM", 10.24);
            var fungibleAsset9 = new FungibleAsset("Monero", "XMR", 144.81);
            var fungibleAsset10 = new FungibleAsset("Quant", "QNT", 128.75);


            var nonFungibleAsset1 = new NonFungibleAsset("PictureBTC1", 2, fungibleAsset1.Adresa);
            var nonFungibleAsset2 = new NonFungibleAsset("PictureBTC2", 5, fungibleAsset1.Adresa);
            var nonFungibleAsset3 = new NonFungibleAsset("PictureETH1", 6, fungibleAsset2.Adresa);
            var nonFungibleAsset4 = new NonFungibleAsset("PictureETH2", 3, fungibleAsset2.Adresa);
            var nonFungibleAsset5 = new NonFungibleAsset("PictureUSDT1", 9632, fungibleAsset3.Adresa);
            var nonFungibleAsset6 = new NonFungibleAsset("PictureBTC2", 7896, fungibleAsset3.Adresa);
            var nonFungibleAsset7 = new NonFungibleAsset("Tamadoge#19", 300, fungibleAsset4.Adresa);
            var nonFungibleAsset8 = new NonFungibleAsset("Tamadoge#28", 1500, fungibleAsset4.Adresa);
            var nonFungibleAsset9 = new NonFungibleAsset("PictureDOT1", 635, fungibleAsset5.Adresa);
            var nonFungibleAsset10 = new NonFungibleAsset("PictureDOT2", 258, fungibleAsset5.Adresa);
            var nonFungibleAsset11 = new NonFungibleAsset("PictureLTC1", 25, fungibleAsset6.Adresa);
            var nonFungibleAsset12 = new NonFungibleAsset("PictureLTC2", 52, fungibleAsset6.Adresa);
            var nonFungibleAsset13 = new NonFungibleAsset("PictureSOL1", 6, fungibleAsset7.Adresa);
            var nonFungibleAsset14 = new NonFungibleAsset("PictureSOL2", 3, fungibleAsset7.Adresa);
            var nonFungibleAsset15 = new NonFungibleAsset("PictureATOM1", 962, fungibleAsset8.Adresa);
            var nonFungibleAsset16 = new NonFungibleAsset("PictureATOM2", 786, fungibleAsset8.Adresa);
            var nonFungibleAsset17 = new NonFungibleAsset("PictureXMR1", 30, fungibleAsset9.Adresa);
            var nonFungibleAsset18 = new NonFungibleAsset("PictureXMR1", 15, fungibleAsset9.Adresa);
            var nonFungibleAsset19 = new NonFungibleAsset("PictureQNT1", 35, fungibleAsset10.Adresa);
            var nonFungibleAsset20 = new NonFungibleAsset("PictureQNT2", 58, fungibleAsset10.Adresa);

            var wallet1 = new BitcoinWallet();
            wallet1.AdresePodrzanihAsseta.Add(fungibleAsset1.Adresa);
            wallet1.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet1.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet1.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet1.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset1.Adresa, 91);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 50);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 11);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 0);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 7);


            var wallet2 = new BitcoinWallet();
            wallet2.AdresePodrzanihAsseta.Add(fungibleAsset1.Adresa);
            wallet2.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet2.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet2.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet2.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset1.Adresa, 10);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 0);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 3);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 82);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 7);

            var wallet3 = new BitcoinWallet();
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset1.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset1.Adresa, 52);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 61);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 100);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 8);
            wallet1.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 87);

            var wallet4 = new SolanaWallet();
            wallet4.AdresePodrzanihAsseta.Add(fungibleAsset7.Adresa);
            wallet4.AdresePodrzanihAsseta.Add(fungibleAsset8.Adresa);
            wallet4.AdresePodrzanihAsseta.Add(fungibleAsset9.Adresa);
            wallet4.AdresePodrzanihAsseta.Add(fungibleAsset10.Adresa);
            wallet4.BalansiFungibleAsseta.Add(fungibleAsset7.Adresa, 91);
            wallet4.BalansiFungibleAsseta.Add(fungibleAsset8.Adresa, 5);
            wallet4.BalansiFungibleAsseta.Add(fungibleAsset9.Adresa, 11);
            wallet4.BalansiFungibleAsseta.Add(fungibleAsset10.Adresa, 65);
            wallet4.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset13.Adresa);
            wallet4.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset15.Adresa);

            var wallet5 = new SolanaWallet();
            wallet5.AdresePodrzanihAsseta.Add(fungibleAsset7.Adresa);
            wallet5.AdresePodrzanihAsseta.Add(fungibleAsset8.Adresa);
            wallet5.AdresePodrzanihAsseta.Add(fungibleAsset9.Adresa);
            wallet5.AdresePodrzanihAsseta.Add(fungibleAsset10.Adresa);
            wallet5.BalansiFungibleAsseta.Add(fungibleAsset7.Adresa, 0);
            wallet5.BalansiFungibleAsseta.Add(fungibleAsset8.Adresa, 5);
            wallet5.BalansiFungibleAsseta.Add(fungibleAsset9.Adresa, 8);
            wallet5.BalansiFungibleAsseta.Add(fungibleAsset10.Adresa, 11);
            wallet5.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset14.Adresa);
            wallet5.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset16.Adresa);

            var wallet6 = new SolanaWallet();
            wallet6.AdresePodrzanihAsseta.Add(fungibleAsset7.Adresa);
            wallet6.AdresePodrzanihAsseta.Add(fungibleAsset8.Adresa);
            wallet6.AdresePodrzanihAsseta.Add(fungibleAsset9.Adresa);
            wallet6.AdresePodrzanihAsseta.Add(fungibleAsset10.Adresa);
            wallet6.BalansiFungibleAsseta.Add(fungibleAsset7.Adresa, 9);
            wallet6.BalansiFungibleAsseta.Add(fungibleAsset8.Adresa, 5);
            wallet6.BalansiFungibleAsseta.Add(fungibleAsset9.Adresa, 45);
            wallet6.BalansiFungibleAsseta.Add(fungibleAsset10.Adresa, 31);
            wallet6.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset17.Adresa);
            wallet6.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset20.Adresa);

            var wallet7 = new EthereumWallet();
            wallet7.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet7.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet7.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet7.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet7.AdresePodrzanihAsseta.Add(fungibleAsset6.Adresa);
            wallet7.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 0);
            wallet7.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 5);
            wallet7.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 0);
            wallet7.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 65);
            wallet7.BalansiFungibleAsseta.Add(fungibleAsset6.Adresa, 43);
            wallet7.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset3.Adresa);
            wallet7.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset5.Adresa);

            var wallet8 = new EthereumWallet();
            wallet8.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet8.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet8.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet8.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet8.AdresePodrzanihAsseta.Add(fungibleAsset6.Adresa);
            wallet8.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 89);
            wallet8.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 5);
            wallet8.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 0);
            wallet8.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 0);
            wallet8.BalansiFungibleAsseta.Add(fungibleAsset6.Adresa, 43);
            wallet8.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset4.Adresa);
            wallet8.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset6.Adresa);

            var wallet9 = new EthereumWallet();
            wallet9.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet9.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet9.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet9.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet9.AdresePodrzanihAsseta.Add(fungibleAsset6.Adresa);
            wallet9.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 8);
            wallet9.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 5);
            wallet9.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 52);
            wallet9.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 45);
            wallet9.BalansiFungibleAsseta.Add(fungibleAsset6.Adresa, 43);
            wallet9.AdreseNonFungibleAssetaKojePosjeduje.Add(nonFungibleAsset11.Adresa);
           
            List<Wallet> listWallets= new List<Wallet>() { wallet1, wallet2, wallet3, wallet4, wallet5, wallet6, wallet7, wallet8, wallet9 };








            Console.WriteLine($"Adresa: {fungibleAsset1.Adresa}\n"
                + $"Ime: {fungibleAsset1.Ime}\n"
                + $"Oznaka: {fungibleAsset1.Oznaka}\n"
                + $"Vrijednost: {fungibleAsset1.VrijednostUOdnosuNaDolar} \n");








            void IzadiIzPrograma()
            {
                Console.Clear();
                Console.WriteLine("Izasli ste iz aplikacije.");
            }
            void KreirajWallet()
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
            void PristupiWalletu()
            {

            }
            void Izbornik()
            {
                string unos;
                do
                {
                    Console.WriteLine("Odaberi:\n1-Kreiraj wallet\n2-Pristupi walletu");
                    unos = Console.ReadLine();
                }
                while (unos != "1" && unos != "2");
                int odabir = int.Parse(unos);
                switch (odabir)
                {
                    case 1:
                        KreirajWallet();
                        Izbornik();
                        break;
                    case 2:
                        PristupiWalletu();
                        break;
                }
            }

        }
    }
}




