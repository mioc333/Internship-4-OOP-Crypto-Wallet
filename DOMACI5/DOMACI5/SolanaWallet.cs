using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public class SolanaWallet : Wallet
    {
        public List<Guid> AdreseNonFungibleAssetaKojePosjeduje { get; set; } = new List<Guid>();
        public SolanaWallet() : base() { }
    }
}
