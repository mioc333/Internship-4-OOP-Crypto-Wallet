using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public abstract class Transakcija
    {
        public Guid Id { get; }
        public Guid AdresaAsseta { get; }
        public DateTime Datum { get; }
        public Guid AdresaWalletaKojiSaljeAsset { get; }
        public Guid AdresaWalletaKojiPrimaAsset { get; }

        public Transakcija(Guid adresaAsseta, DateTime datum, Guid adresaWalletaKojiSaljeAsset, Guid adresaWalletaKojiPrimaAsset)
        {
            Id = Guid.NewGuid();
            AdresaAsseta = adresaAsseta;
            Datum = datum;
            AdresaWalletaKojiSaljeAsset = adresaWalletaKojiSaljeAsset;
            AdresaWalletaKojiPrimaAsset = adresaWalletaKojiPrimaAsset;
        }

        public bool Opozvana()
        {
            return false;
        }


    }
}
