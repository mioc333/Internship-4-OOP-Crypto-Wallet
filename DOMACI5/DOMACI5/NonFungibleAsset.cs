using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class NonFungibleAsset : Asset
    {
        public double Vrijednost { get; set; }
        public Guid AdresaFungibleAssetaNaKojuSeTaVrijednostOdnosi { get; }
        public double VrijednostUUSD { get; set; } = 0;

        public NonFungibleAsset(string ime, double vrijednost, Guid adresaFungibleAssetaNaKojuSeTaVrijednostOdnosi) : base(ime)
        {
            Vrijednost= vrijednost;
            AdresaFungibleAssetaNaKojuSeTaVrijednostOdnosi = adresaFungibleAssetaNaKojuSeTaVrijednostOdnosi;

                foreach (var t in AssetsStore.FungibleAssets)
                {
                    if (t.Adresa == AdresaFungibleAssetaNaKojuSeTaVrijednostOdnosi)
                    {
                    VrijednostUUSD = t.VrijednostUOdnosuNaDolar * Vrijednost;
                    }
                }
            
        }
        

        public override string ToString()
        {
            return base.ToString() + $"Vrijednost: {Vrijednost}"+$"Vrijednost u USD: {VrijednostUUSD}";

        }


    }
}
