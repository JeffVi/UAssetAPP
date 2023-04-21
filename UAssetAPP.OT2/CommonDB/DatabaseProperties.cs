using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;

namespace UAssetAPP.OT2.CommonDB
{
    public static class DatabaseProperties
    {
        public static object GetData(PropertyData propertyData)
        {
            DataType dataType = GetDataType(propertyData.PropertyType.Value);

            switch (dataType)
            {
                case DataType.NameProperty:
                    NamePropertyData nameData = (NamePropertyData)propertyData;
                    return nameData.Value.Value.Value;  // Name as string

                case DataType.TextProperty:
                    TextPropertyData textData = (TextPropertyData)propertyData;
                    return textData.CultureInvariantString; // TextPropertyData may be null

                case DataType.EnumProperty:
                    EnumPropertyData enumData = (EnumPropertyData)propertyData;
                    return enumData.Value.Value.Value;

                case DataType.BoolProperty:
                    BoolPropertyData boolData = (BoolPropertyData)propertyData;
                    return boolData.Value;

                case DataType.IntProperty:
                    IntPropertyData intData = (IntPropertyData)propertyData;
                    return intData.Value;

                case DataType.FloatProperty:
                    FloatPropertyData floatData = (FloatPropertyData)propertyData;
                    return floatData.Value;

                case DataType.SoftObjectProperty:
                    SoftObjectPropertyData soData = (SoftObjectPropertyData)propertyData;
                    return soData.Value.AssetPathName.Value.Value;

                case DataType.ArrayProperty:
                    ArrayPropertyData arrayData = (ArrayPropertyData)propertyData;
                    return arrayData.Value.ToList();    // List of PropertyData

                case DataType.StructProperty:
                    StructPropertyData structData = (StructPropertyData)propertyData;
                    return structData.Value;     // List of PropertyData

                default:
                    throw new NotImplementedException();
            }
        }

        public static DataType GetDataType(string propertyType)
        {
            switch (propertyType)
            {
                case "NameProperty":
                    return DataType.NameProperty;
                case "TextProperty":
                    return DataType.TextProperty;
                case "EnumProperty":
                    return DataType.EnumProperty;
                case "BoolProperty":
                    return DataType.BoolProperty;
                case "IntProperty":
                    return DataType.IntProperty;
                case "FloatProperty":
                    return DataType.FloatProperty;
                case "SoftObjectProperty":
                    return DataType.SoftObjectProperty;
                case "ArrayProperty":
                    return DataType.ArrayProperty;
                case "StructProperty":
                    return DataType.StructProperty;
                default:
                    throw new NotImplementedException();
            }
        }

        public enum DataType
        {
            NameProperty,
            TextProperty,
            EnumProperty,
            BoolProperty,
            IntProperty,
            FloatProperty,
            SoftObjectProperty,
            ArrayProperty,
            StructProperty,
        }
    }
}
