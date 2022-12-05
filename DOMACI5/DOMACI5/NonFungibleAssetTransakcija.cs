using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class NonFungibleAssetTransakcija
    {
        public Guid Id { get; }
        public string AdresaNonFungibleAsstea { get; }
        public DateTime Datum { get; }
        public string AdresaWalletaKojiSaljeNonFungibleAsset { get; }
        public string AdresaWalletaKojiPrimaNonFungibleAsset { get; }
        public string PocetniBalansKojiSalje;
        public string KrajnjiBalansKojiSalje;
        public string PocetniBalansKojiPrima;
        public string KrajnjiBalansKojiPrima;

        public NonFungibleAssetTransakcija(string adresaNonFungibleAsstea, DateTime datum, string adresaWalletaKojiSaljeNonFungibleAsset, string adresaWalletaKojiPrimaNonFungibleAsset)
        {
            Id = Guid.NewGuid();
            AdresaNonFungibleAsstea = adresaNonFungibleAsstea;
            Datum = datum;
            AdresaWalletaKojiSaljeNonFungibleAsset = adresaWalletaKojiSaljeNonFungibleAsset;
            AdresaNonFungibleAsstea = adresaNonFungibleAsstea;
        }

        public bool Opozvana()
        {
            return false;
        }
    }
}
