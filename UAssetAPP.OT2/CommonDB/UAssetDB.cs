using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using UAssetAPI.UnrealTypes;

namespace UAssetAPP.OT2.CommonDB
{
    public class UAssetDB : IUAssetDB
    {
        private readonly string assetPath;
        protected readonly UAsset uAsset;
        protected List<StructPropertyData> data = new();
        protected List<string> names = new();

        public UAssetDB(string path, EngineVersion engineVersion)
        {
            assetPath = path;
            uAsset = new UAsset(path, engineVersion);
            ParseAsset();
        }

        public UAsset UAsset => uAsset;

        public int dbSize => data.Count;

        private void ParseAsset()
        {
            data.Clear();
            names.Clear();
            if (uAsset.Exports.Count == 1)
            {
                if (uAsset.Exports[0] is NormalExport us)
                {
                    if (us is DataTableExport us4)
                    {
                        data = us4.Table.Data;
                        foreach (var item in data)
                        {
                            names.Add(item.Name.ToString());
                        }
                    }
                }
            }
        }

        public void UpdateAsset()
        {
            var MStream = uAsset.WriteData();
            uAsset.Read(new AssetBinaryReader(MStream));
            ParseAsset();
        }

        public void Save()
        {
            uAsset.Write(assetPath);
        }

        public void SaveTo(string path)
        {
            uAsset.Write(path);
        }
    }
}
