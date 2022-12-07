using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class SolanaWallet : Wallet
    {
        public List<Guid> AdreseNonFungibleAssetaKojePosjeduje { get; set; } = new List<Guid>();
        public SolanaWallet() : base()
        {
            typeOfWallet = "Solana Wallet";
        }

        public virtual double UkupnaVrijednostSvihAssetaKojePosjedujeuUSD()
        {
            double s = 0;
            foreach (var k in AdreseNonFungibleAssetaKojePosjeduje)
            {
                foreach (var t in AssetsStore.NonFungibleAssets)
                {
                    if (t.Adresa == k)
                    {
                        foreach (var l in AssetsStore.FungibleAssets)
                        {
                            if (t.AdresaFungibleAssetaNaKojuSeTaVrijednostOdnosi == l.Adresa)
                                s += t.Vrijednost * l.VrijednostUOdnosuNaDolar;
                        }
                    }
                }
            }
            s += base.UkupnaVrijednostSvihAssetaKojePosjedujeuUSD();
            return s;
        } 
        
    }
}
