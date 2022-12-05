using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public abstract class Asset
    {
        public Guid Adresa { get; }
        public string Ime { get; set; }//nije moguce imat 2 fungible asseta s istim imenon       
        public Asset(string ime)
        {
            Adresa = Guid.NewGuid();
            Ime = ime;
        }
    }
}
