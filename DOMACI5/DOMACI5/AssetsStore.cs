using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMACI5
{
    public static class AssetsStore
    {
        public static List<FungibleAsset> FungibleAssets { get; } = new List<FungibleAsset>();
        public static List<NonFungibleAsset> NonFungibleAssets { get; } = new List<NonFungibleAsset>();
        
        
    }
}
