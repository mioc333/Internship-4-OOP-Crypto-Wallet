using DOMACI5;
using System.Globalization;
using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace DOMACI5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //napravila sam jako mali dio domaceg jer vecinu stvari nisam ni znala kako bih napravila
            //uglavnom sam pokusala napravit ono sta sam vidila na predavanju al vecina toga se jako zakomplicira 
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

            AssetsStore.FungibleAssets.Add(fungibleAsset1);
            AssetsStore.FungibleAssets.Add(fungibleAsset2);
            AssetsStore.FungibleAssets.Add(fungibleAsset3);
            AssetsStore.FungibleAssets.Add(fungibleAsset4);
            AssetsStore.FungibleAssets.Add(fungibleAsset5);
            AssetsStore.FungibleAssets.Add(fungibleAsset6);
            AssetsStore.FungibleAssets.Add(fungibleAsset7);
            AssetsStore.FungibleAssets.Add(fungibleAsset8);
            AssetsStore.FungibleAssets.Add(fungibleAsset9);
            AssetsStore.FungibleAssets.Add(fungibleAsset10);

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

            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset1);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset2);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset3);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset4);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset5);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset6);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset7);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset8);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset9);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset10);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset11);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset12);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset13);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset14);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset15);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset16);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset17);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset18);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset19);
            AssetsStore.NonFungibleAssets.Add(nonFungibleAsset20);

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
            wallet2.BalansiFungibleAsseta.Add(fungibleAsset1.Adresa, 10);
            wallet2.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 0);
            wallet2.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 3);
            wallet2.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 82);
            wallet2.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 7);

            var wallet3 = new BitcoinWallet();
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset1.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset2.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset3.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset4.Adresa);
            wallet3.AdresePodrzanihAsseta.Add(fungibleAsset5.Adresa);
            wallet3.BalansiFungibleAsseta.Add(fungibleAsset1.Adresa, 52);
            wallet3.BalansiFungibleAsseta.Add(fungibleAsset2.Adresa, 61);
            wallet3.BalansiFungibleAsseta.Add(fungibleAsset3.Adresa, 100);
            wallet3.BalansiFungibleAsseta.Add(fungibleAsset4.Adresa, 8);
            wallet3.BalansiFungibleAsseta.Add(fungibleAsset5.Adresa, 87);

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

            WalletStore.Add(wallet1);
            WalletStore.Add(wallet2);
            WalletStore.Add(wallet3);
            WalletStore.Add(wallet4);
            WalletStore.Add(wallet5);
            WalletStore.Add(wallet6);
            WalletStore.Add(wallet7);
            WalletStore.Add(wallet8);
            WalletStore.Add(wallet9);

            Metode.Izbornik();

        }
    }
}




