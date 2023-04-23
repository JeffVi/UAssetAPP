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

        public void SetEnemy(Enemy enemy)
        {
            int index = names.IndexOf(enemy.Name);
            if (index < 0)
                return;

            List<PropertyData> enemyToUpdate = (List<PropertyData>)data[index].Value;

            /***** Float *****/

            FloatPropertyData eneDmgRat = (FloatPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.DamageRatio];
            eneDmgRat.FromString(new string[] { $"{enemy.DamageRatio}" }, uAsset);

            /***** Int *****/

            IntPropertyData eneDisplayRank = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.DisplayRank];
            eneDisplayRank.FromString(new string[] { $"{enemy.DisplayRank}" }, uAsset);

            IntPropertyData eneEnemyLevel = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.EnemyLevel];
            eneEnemyLevel.FromString(new string[] { $"{enemy.EnemyLevel}" }, uAsset);

            IntPropertyData eneExp = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.Exp];
            eneExp.FromString(new string[] { $"{enemy.Exp}" }, uAsset);

            IntPropertyData eneJobPoint = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.JobPoint];
            eneJobPoint.FromString(new string[] { $"{enemy.JobPoint}" }, uAsset);

            IntPropertyData eneMoney = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.Money];
            eneMoney.FromString(new string[] { $"{enemy.Money}" }, uAsset);

            IntPropertyData eneStealMoney = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.StealMoney];
            eneStealMoney.FromString(new string[] { $"{enemy.StealMoney}" }, uAsset);

            IntPropertyData eneDropProbability = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.DropProbability];
            eneDropProbability.FromString(new string[] { $"{enemy.DropProbability}" }, uAsset);

            IntPropertyData eneBribeMoney = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.BribeMoney];
            eneBribeMoney.FromString(new string[] { $"{enemy.BribeMoney}" }, uAsset);

            IntPropertyData eneRevealShieldPoint = (IntPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.RevealShieldPoint];
            eneRevealShieldPoint.FromString(new string[] { $"{enemy.RevealShieldPoint}" }, uAsset);

            /***** Bool *****/

            BoolPropertyData eneDeadEffectSlow = (BoolPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.DeadEffectSlow];
            eneDeadEffectSlow.FromString(new string[] { $"{enemy.DeadEffectSlow}" }, uAsset);

            BoolPropertyData eneMainEnemy = (BoolPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.MainEnemy];
            eneMainEnemy.FromString(new string[] { $"{enemy.MainEnemy}" }, uAsset);

            BoolPropertyData eneNonPartBattle = (BoolPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.NonPartBattle];
            eneNonPartBattle.FromString(new string[] { $"{enemy.NonPartBattle}" }, uAsset);

            BoolPropertyData eneUseCatDamageType = (BoolPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.UseCatDamageType];
            eneUseCatDamageType.FromString(new string[] { $"{enemy.UseCatDamageType}" }, uAsset);

            BoolPropertyData eneDisableDeadKnockBack = (BoolPropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.DisableDeadKnockBack];
            eneDisableDeadKnockBack.FromString(new string[] { $"{enemy.DisableDeadKnockBack}" }, uAsset);

            /***** String *****/

            NamePropertyData eneHaveItemID = (NamePropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.HaveItemID];
            eneHaveItemID.FromString(new string[] { enemy.HaveItemID }, uAsset);

            NamePropertyData eneStealItemID = (NamePropertyData)enemyToUpdate[(int)EnemyPropertiesEnum.StealItemID];
            eneStealItemID.FromString(new string[] { enemy.StealItemID }, uAsset);

            /***** List *****/

            SetParamArrayData(index, enemy.Param);
            SetAttributeResistArrayData(index, enemy.AttributeResist);
            SetWeaponResistArrayData(index, enemy.WeaponResist);
            SetDiseaseResistArrayData(index, enemy.DiseaseResist);

            UpdateAsset();
        }

        private void SetParamArrayData(int index, List<int> enemyParams)
        {
            List<PropertyData> enemyToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(enemyToUpdate[(int)EnemyPropertiesEnum.Param]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < enemyParams.Count; i++)
            {
                IntPropertyData stat = (IntPropertyData)arrayDataValue[i];
                stat.FromString(new string[] { $"{enemyParams[i]}" }, uAsset);
            }

        }

        private void SetAttributeResistArrayData(int index, List<AttributeResistEnum> enemyAttributeResists)
        {
            List<PropertyData> enemyToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(enemyToUpdate[(int)EnemyPropertiesEnum.AttributeResist]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < enemyAttributeResists.Count; i++)
            {
                EnumPropertyData attributeRes = (EnumPropertyData)arrayDataValue[i];
                attributeRes.FromString(new string[] { AttributeResistString.ENUM_TYPE, AttributeResistString.TypeDic[enemyAttributeResists[i]] }, uAsset);
            }

        }

        private void SetWeaponResistArrayData(int index, List<AttributeResistEnum> enemyWeaponResist)
        {
            List<PropertyData> enemyToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(enemyToUpdate[(int)EnemyPropertiesEnum.WeaponResist]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < enemyWeaponResist.Count; i++)
            {
                EnumPropertyData weaponRes = (EnumPropertyData)arrayDataValue[i];
                weaponRes.FromString(new string[] { AttributeResistString.ENUM_TYPE, AttributeResistString.TypeDic[enemyWeaponResist[i]] }, uAsset);
            }

        }

        private void SetDiseaseResistArrayData(int index, List<AttributeResistEnum> enemyDiseaseResist)
        {
            List<PropertyData> enemyToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(enemyToUpdate[(int)EnemyPropertiesEnum.DiseaseResist]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < enemyDiseaseResist.Count; i++)
            {
                EnumPropertyData diseaseRes = (EnumPropertyData)arrayDataValue[i];
                diseaseRes.FromString(new string[] { AttributeResistString.ENUM_TYPE, AttributeResistString.TypeDic[enemyDiseaseResist[i]] }, uAsset);
            }

        }

    }
}
