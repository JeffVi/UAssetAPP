using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAssetAPI;
using UAssetAPI.PropertyTypes.Objects;

namespace UAssetAPP.OT2.CommonDB
{
    public interface IUAssetDB
    {
        UAsset UAsset { get; }
        int dbSize { get; }

        void UpdateAsset();
        void Save();
        void SaveTo(string path);
    }
}
