using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class FungibleAssetTransakcija
    {
        public Guid Id { get; }
        public string AdresaFungibleAsstea { get; }
        public DateTime Datum { get; }
        public string AdresaWalletaKojiSaljeFungibleAsset { get; }
        public string AdresaWalletaKojiPrimaFungibleAsset { get; }
        public string PocetniBalansKojiSalje;
        public string KrajnjiBalansKojiSalje;
        public string PocetniBalansKojiPrima;
        public string KrajnjiBalansKojiPrima;

        public FungibleAssetTransakcija(string adresaFungibleAsstea, DateTime datum, string adresaWalletaKojiSaljeFungibleAsset, string adresaWalletaKojiPrimaFungibleAsset)
        {
            Id = Guid.NewGuid();
            AdresaFungibleAsstea = adresaFungibleAsstea;
            Datum = datum;
            AdresaWalletaKojiSaljeFungibleAsset = adresaWalletaKojiSaljeFungibleAsset;
            AdresaWalletaKojiPrimaFungibleAsset = adresaWalletaKojiPrimaFungibleAsset;
        }

        public bool Opozvana()
        {
            return false;
        }



    }
}
