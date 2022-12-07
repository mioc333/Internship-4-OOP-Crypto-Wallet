using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public abstract class Wallet
    {
        public string typeOfWallet = "";
        public Guid Adresa { get; private set; }
        public Dictionary<Guid, double> BalansiFungibleAsseta { get; }=new Dictionary<Guid, double>();
        public List<Guid> AdreseTransakcija { get; } = new List<Guid>();

        public List<Guid> AdresePodrzanihAsseta { get; set; }=new List<Guid>();
        public Wallet()
        {
            Adresa= Guid.NewGuid();
        }
        public virtual double UkupnaVrijednostSvihAssetaKojePosjedujeuUSD()
        {
            double suma = 0;
            foreach(var k in BalansiFungibleAsseta.Keys) 
            { 
                foreach(var t in AssetsStore.FungibleAssets)
                {
                    if(t.Adresa==k)
                    {
                        suma += t.VrijednostUOdnosuNaDolar * BalansiFungibleAsseta[k];
                    }
                }
            }
            return suma;
        }


        public override string ToString()
        {
            return $"Adresa: {Adresa}\n" +
                $"Ukupna vrijednost svih asseta koje posjeduje u USD: {UkupnaVrijednostSvihAssetaKojePosjedujeuUSD()}\n";
        }

    }
}
