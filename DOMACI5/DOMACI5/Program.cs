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
                        break;
                    case 2:
                        PristupiWalletu();
                        break;
                }
            }

        }
    }
}




