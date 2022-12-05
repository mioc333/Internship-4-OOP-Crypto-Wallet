using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public abstract class Wallet
    {
        public Guid Adresa { get; private set; }
        public Dictionary<Guid, double> BalansiFungibleAsseta { get; }
        public List<Guid> AdreseTransakcija { get; }

        public List<Guid> AdresePodrzanihAsseta;
        public Wallet()
        {
            Adresa= Guid.NewGuid();
        }

    }
}
