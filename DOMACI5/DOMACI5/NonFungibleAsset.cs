using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class NonFungibleAsset : Asset
    {
        public double Vrijednost;
        public string AdresaFungibleAssetaNaKojuSeTaVrijednostOdnosi { get; }

        public NonFungibleAsset(string ime, double vrijednost, Guid adresaFungibleAssetaNaKojuSeTaVrijednostOdnosi) : base(ime)
        {
            Vrijednost= vrijednost;
            AdresaFungibleAssetaNaKojuSeTaVrijednostOdnosi = adresaFungibleAssetaNaKojuSeTaVrijednostOdnosi;
        }


    }
}
