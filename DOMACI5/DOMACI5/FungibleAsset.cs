using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class FungibleAsset : Asset
    {
        public string Oznaka { get; set; } //nije moguce imat 2 fungible asseta s istom oznakom, BTC za Bitcoin
        public double VrijednostUOdnosuNaDolar { get; private set; } //nije je moguce mijenjati van klase ali ju je moguce dohvatit

        public FungibleAsset(string ime, string oznaka, double vrijednostUOdnosuNaDolar) : base(ime) 
        { 
            Oznaka = oznaka;
            VrijednostUOdnosuNaDolar = vrijednostUOdnosuNaDolar;
        }

    }
}
