using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using UAssetAPI.UnrealTypes;
using UAssetAPP.OT2.CommonDB;
using static UAssetAPP.OT2.CommonDB.DatabaseProperties;

namespace UAssetAPP.OT2.DataBases.GameText
{
    public class GameText : UAssetDB
    {
        public GameText(string path) : base(path, EngineVersion.VER_UE4_27) { }

        public string? GetText(int index)
        {
            List<PropertyData> propertyDatas = data[index].Value as List<PropertyData>;
            FString? textPropertyData = (FString?)GetData(propertyDatas[1]);
            return textPropertyData?.Value;
        }

        public string? GetText(string name)
        {
            return GetText(names.IndexOf(name));
        }

        public void SetText(int index, string text)
        {
            List<PropertyData> propertyDatas = data[index].Value as List<PropertyData>;

            TextPropertyData textData = (TextPropertyData)propertyDatas[1];
            //textData.FromString(new string[] { "" }, uAsset); // Not yet implemented in UAssetGUI ! TODO
            textData.CultureInvariantString.Value = text;

            UpdateAsset();
        }

        public void SetText(string name, string text)
        {
            SetText(names.IndexOf(name), text);
        }
    }
}
