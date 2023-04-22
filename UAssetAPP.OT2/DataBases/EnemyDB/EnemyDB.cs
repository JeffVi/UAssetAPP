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

namespace UAssetAPP.OT2.DataBases.EnemyDB
{
    public class EnemyDB : UAssetDB
    {
        public EnemyDB(string path) : base(path, EngineVersion.VER_UE4_27) { }

        public Enemy GetEnemy(int index)
        {
            return new Enemy(data[index]);
        }

        public Enemy GetEnemy(string name)
        {
            return GetEnemy(names.IndexOf(name));
        }

        public void SetEnemy(Enemy ability)
        {
            int index = names.IndexOf(ability.Name);
            if (index < 0)
                return;

            List<PropertyData> enemyToUpdate = (List<PropertyData>)data[index].Value;

            UpdateAsset();
        }
        
    }
}
