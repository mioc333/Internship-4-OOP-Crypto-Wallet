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
        public Dictionary<Guid, double> BalansiFungibleAsseta { get; }=new Dictionary<Guid, double>();
        public List<Guid> AdreseTransakcija { get; } = new List<Guid>();

        public List<Guid> AdresePodrzanihAsseta { get; set; }=new List<Guid>();
        public Wallet()
        {
            Adresa= Guid.NewGuid();
        }


        public override string ToString()
        {
            return $"Adresa: {Adresa}\n"       
        }

    }
}
