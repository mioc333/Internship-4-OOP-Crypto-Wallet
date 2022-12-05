using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class NonFungibleAssetTransakcija : Transakcija
    {
        public NonFungibleAssetTransakcija(Guid adresaAsseta, DateTime datum, Guid adresaWalletaKojiSaljeAsset, Guid adresaWalletaKojiPrimaAsset) : base(adresaAsseta, datum, adresaWalletaKojiSaljeAsset, adresaWalletaKojiPrimaAsset) { }

    }
}
