using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class FungibleAssetTransakcija : Transakcija
    {  
        public double PocetniBalansKojiSalje;
        public double KrajnjiBalansKojiSalje;
        public double PocetniBalansKojiPrima;
        public double KrajnjiBalansKojiPrima;
        public FungibleAssetTransakcija(Guid adresaAsseta, DateTime datum, Guid adresaWalletaKojiSaljeAsset, Guid adresaWalletaKojiPrimaAsset) : base(adresaAsseta, datum, adresaWalletaKojiSaljeAsset, adresaWalletaKojiPrimaAsset)
        {

        }
    }
}
