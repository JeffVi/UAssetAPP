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

namespace UAssetAPP.OT2.DataBases.AbilityData
{
    public class AbilityData : UAssetDB
    {
        public AbilityData(string path) : base(path, EngineVersion.VER_UE4_27) { }

        public Ability GetAbility(int index)
        {
            return new Ability(data[index]);
        }

        public Ability GetAbility(string name)
        {
            return new Ability(data[names.IndexOf(name)]);
        }

        public void SetAbility(Ability ability)
        {
            int index = names.IndexOf(ability.Name);
            if (index < 0)
                return;

            List<PropertyData> abilityToUpdate = (List<PropertyData>)data[index].Value;

            /***** Enum *****/

            EnumPropertyData abiAbilityType = (EnumPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.AbilityType];
            abiAbilityType.FromString(new string[] {AbilityTypeString.ENUM_TYPE, AbilityTypeString.AbilityTypeDic[ability.AbilityType] }, uAsset);

            EnumPropertyData abiAttribute = (EnumPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.Attribute];
            abiAttribute.FromString(new string[] {AttributeString.ENUM_TYPE, AttributeString.AbilityTypeDic[ability.Attribute] }, uAsset);

            EnumPropertyData abiRestrictWeapon = (EnumPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.RestrictWeapon];
            abiRestrictWeapon.FromString(new string[] {RestrictWeaponString.ENUM_TYPE, RestrictWeaponString.AbilityTypeDic[ability.RestrictWeapon] }, uAsset);

            EnumPropertyData abiTargetType = (EnumPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.TargetType];
            abiTargetType.FromString(new string[] {TargetTypeString.ENUM_TYPE, TargetTypeString.AbilityTypeDic[ability.TargetType] }, uAsset);

            EnumPropertyData abiCostType = (EnumPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.CostType];
            abiCostType.FromString(new string[] {CostTypeString.ENUM_TYPE, CostTypeString.AbilityTypeDic[ability.CostType] }, uAsset);

            EnumPropertyData abiOrderType = (EnumPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EstimateOrderType];
            abiOrderType.FromString(new string[] { EstimateOrderTypeString.ENUM_TYPE, EstimateOrderTypeString.AbilityTypeDic[ability.EstimateOrderType] }, uAsset);

            /***** String *****/

            SoftObjectPropertyData abiComAct = (SoftObjectPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.CommandActor];
            abiComAct.FromString(new string[] { ability.CommandActor, string.Empty }, uAsset);
            
            SoftObjectPropertyData abiActComSeq = (SoftObjectPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.ActionCommandSequencer];
            abiActComSeq.FromString(new string[] { ability.ActionCommandSequencer, string.Empty }, uAsset);

            /***** Int *****/

            IntPropertyData abiCostValue = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.CostValue];
            abiCostValue.FromString(new string[] { $"{ability.CostValue}" }, uAsset);

            IntPropertyData abiHitRatio = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.HitRatio];
            abiHitRatio.FromString(new string[] { $"{ability.HitRatio}" }, uAsset);

            IntPropertyData abiCriticalRatio = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.CriticalRatio];
            abiCriticalRatio.FromString(new string[] { $"{ability.CriticalRatio}" }, uAsset);

            IntPropertyData abiCriticalPower = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.CriticalPower];
            abiCriticalPower.FromString(new string[] { $"{ability.CriticalPower}" }, uAsset);

            IntPropertyData abiAbilityRatio = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.AbilityRatio];
            abiAbilityRatio.FromString(new string[] { $"{ability.AbilityRatio}" }, uAsset);

            IntPropertyData abiBaseCount = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.BaseCount];
            abiBaseCount.FromString(new string[] { $"{ability.BaseCount}" }, uAsset);

            IntPropertyData abiMinimumCount = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.MinimumCount];
            abiMinimumCount.FromString(new string[] { $"{ability.MinimumCount}" }, uAsset);

            IntPropertyData abiRandomCountMin = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.RandomCountMin];
            abiRandomCountMin.FromString(new string[] { $"{ability.RandomCountMin}" }, uAsset);

            IntPropertyData abiRandomCountMax = (IntPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.RandomCountMax];
            abiRandomCountMax.FromString(new string[] { $"{ability.RandomCountMax}" }, uAsset);

            /***** Bool *****/

            BoolPropertyData abiAlwaysDisable = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.AlwaysDisable];
            abiAlwaysDisable.FromString(new string[] { $"{ability.AlwaysDisable}" }, uAsset);

            BoolPropertyData abiDependWeapon = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.DependWeapon];
            abiDependWeapon.FromString(new string[] { $"{ability.DependWeapon}" }, uAsset);

            BoolPropertyData abiExceptEnforcer = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.ExceptEnforcer];
            abiExceptEnforcer.FromString(new string[] { $"{ability.ExceptEnforcer}" }, uAsset);

            BoolPropertyData abiKeepBoostEffect = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.KeepBoostEffect];
            abiKeepBoostEffect.FromString(new string[] { $"{ability.KeepBoostEffect}" }, uAsset);

            BoolPropertyData abiEnableItemAll = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableItemAll];
            abiEnableItemAll.FromString(new string[] { $"{ability.EnableItemAll}" }, uAsset);

            BoolPropertyData abiEnableSkillAll = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableSkillAll];
            abiEnableSkillAll.FromString(new string[] { $"{ability.EnableSkillAll}" }, uAsset);

            BoolPropertyData abiEnableConvergence = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableConvergence];
            abiEnableConvergence.FromString(new string[] { $"{ability.EnableConvergence}" }, uAsset);

            BoolPropertyData abiEnableDiffusion = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableDiffusion];
            abiEnableDiffusion.FromString(new string[] { $"{ability.EnableDiffusion}" }, uAsset);

            BoolPropertyData abiEnableReflection = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableReflection];
            abiEnableReflection.FromString(new string[] { $"{ability.EnableReflection}" }, uAsset);

            BoolPropertyData abiEnableCounter = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableCounter];
            abiEnableCounter.FromString(new string[] { $"{ability.EnableCounter}" }, uAsset);

            BoolPropertyData abiEnableHideOut = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableHideOut];
            abiEnableHideOut.FromString(new string[] { $"{ability.EnableHideOut}" }, uAsset);

            BoolPropertyData abiEnableRepeat = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableRepeat];
            abiEnableRepeat.FromString(new string[] { $"{ability.EnableRepeat}" }, uAsset);

            BoolPropertyData abiEnableCover = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableCover];
            abiEnableCover.FromString(new string[] { $"{ability.EnableCover}" }, uAsset);

            BoolPropertyData abiEnableProvoke = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableProvoke];
            abiEnableProvoke.FromString(new string[] { $"{ability.EnableProvoke}" }, uAsset);

            BoolPropertyData abiEnableDisableMagic = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableDisableMagic];
            abiEnableDisableMagic.FromString(new string[] { $"{ability.EnableDisableMagic}" }, uAsset);

            BoolPropertyData abiEnableEnchant = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableEnchant];
            abiEnableEnchant.FromString(new string[] { $"{ability.EnableEnchant}" }, uAsset);

            BoolPropertyData abiEnableChaseAttack = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableChaseAttack];
            abiEnableChaseAttack.FromString(new string[] { $"{ability.EnableChaseAttack}" }, uAsset);

            BoolPropertyData abiEnableWeakCheckAll = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableWeakCheckAll];
            abiEnableWeakCheckAll.FromString(new string[] { $"{ability.EnableWeakCheckAll}" }, uAsset);

            BoolPropertyData abiEnableNormalAttackAll = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableNormalAttackAll];
            abiEnableNormalAttackAll.FromString(new string[] { $"{ability.EnableNormalAttackAll}" }, uAsset);

            BoolPropertyData abiEnableSession = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableSession];
            abiEnableSession.FromString(new string[] { $"{ability.EnableSession}" }, uAsset);

            BoolPropertyData abiEnableBusinessSupport = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableBusinessSupport];
            abiEnableBusinessSupport.FromString(new string[] { $"{ability.EnableBusinessSupport}" }, uAsset);

            BoolPropertyData abiEnableForceWeakness = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableForceWeakness];
            abiEnableForceWeakness.FromString(new string[] { $"{ability.EnableForceWeakness}" }, uAsset);

            BoolPropertyData abiEnableNoUseMaterial = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableNoUseMaterial];
            abiEnableNoUseMaterial.FromString(new string[] { $"{ability.EnableNoUseMaterial}" }, uAsset);

            BoolPropertyData abiEnableSwitchWeapon = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableSwitchWeapon];
            abiEnableSwitchWeapon.FromString(new string[] { $"{ability.EnableSwitchWeapon}" }, uAsset);

            BoolPropertyData abiEnableCompensationMagic = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableCompensationMagic];
            abiEnableCompensationMagic.FromString(new string[] { $"{ability.EnableCompensationMagic}" }, uAsset);

            BoolPropertyData abiEnableExcitement = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableExcitement];
            abiEnableExcitement.FromString(new string[] { $"{ability.EnableExcitement}" }, uAsset);

            BoolPropertyData abiSongAbilityFlag = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.SongAbilityFlag];
            abiSongAbilityFlag.FromString(new string[] { $"{ability.SongAbilityFlag}" }, uAsset);

            BoolPropertyData abiDanceAbilityFlag = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.DanceAbilityFlag];
            abiDanceAbilityFlag.FromString(new string[] { $"{ability.DanceAbilityFlag}" }, uAsset);

            BoolPropertyData abiEnableAutoTameMonster = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.EnableAutoTameMonster];
            abiEnableAutoTameMonster.FromString(new string[] { $"{ability.EnableAutoTameMonster}" }, uAsset);

            BoolPropertyData abiUseAbilityCamera = (BoolPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.UseAbilityCamera];
            abiUseAbilityCamera.FromString(new string[] { $"{ability.UseAbilityCamera}" }, uAsset);

            /***** Ailment list *****/

            SetAilmentArraySize(ref abilityToUpdate, ability.AilmentsList);

            // Need to update the asset after changing the size...
            UpdateAsset();

            SetAilmentArrayData(index, ability.AilmentsList);

            UpdateAsset();
        }
        
        private void SetAilmentArraySize(ref List<PropertyData> abilityToUpdate, List<Ailment> abilityAilments)
        {
            List<PropertyData> newData = new List<PropertyData>();
            PropertyData? template = UAsset.DeserializeJsonObject("{\"$type\":\"UAssetAPI.PropertyTypes.Structs.StructPropertyData, UAssetAPI\",\"StructType\":\"AilmentHandler\",\"SerializeNone\":true,\"StructGUID\":\"00000000-0000-0000-0000-000000000000\",\"Name\":\"Ailment\",\"DuplicationIndex\":0,\"Value\":[{\"$type\":\"UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI\",\"Name\":\"AilmentName\",\"DuplicationIndex\":0,\"Value\":\"None\"},{\"$type\":\"UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI\",\"Name\":\"InvocationValue\",\"DuplicationIndex\":0,\"Value\":0},{\"$type\":\"UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI\",\"Name\":\"InvocationTurn\",\"DuplicationIndex\":0,\"Value\":0},{\"$type\":\"UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI\",\"Name\":\"DiseaseRate\",\"DuplicationIndex\":0,\"Value\":0}]}") as PropertyData;

            if (template is null)
                return;

            foreach (var ailment in abilityAilments)
            {
                newData.Add(template);
            }

            ArrayPropertyData arrayData = (ArrayPropertyData)abilityToUpdate[(int)AbilityPropertiesEnum.Ailment];
            arrayData.Value = newData.ToArray();
        }

        private void SetAilmentArrayData(int index, List<Ailment> abilityAilments)
        {
            List<PropertyData> abilityToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(abilityToUpdate[(int)AbilityPropertiesEnum.Ailment]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < abilityAilments.Count; i++)
            {
                SetAilmentData(arrayDataValue[i], abilityAilments[i]);
            }

        }

        private void SetAilmentData(PropertyData ailmentData, Ailment abilityAilment)
        {
            StructPropertyData? ailment = ailmentData as StructPropertyData;

            if (ailment is null)
                return;

            NamePropertyData name = (NamePropertyData)ailment.Value[0];
            IntPropertyData invocVal = (IntPropertyData)ailment.Value[1];
            IntPropertyData invocTurn = (IntPropertyData)ailment.Value[2];
            IntPropertyData disRate = (IntPropertyData)ailment.Value[3];

            name.FromString(new string[] { abilityAilment.Name }, uAsset);
            invocVal.FromString(new string[] { $"{abilityAilment.InvocationValue}" }, uAsset);
            invocTurn.FromString(new string[] { $"{abilityAilment.InvocationTurn}" }, uAsset);
            disRate.FromString(new string[] { $"{abilityAilment.DiseaseRate}" }, uAsset);
        }
        
        public List<string> GetAllAilmentNames()
        {
            var list = new List<string>();

            foreach (var propertyData in data)
            {
                List<PropertyData> propertyDatas = (List<PropertyData>)propertyData.Value;
                foreach (PropertyData ailmentPropertyData in (List<PropertyData>)GetData(propertyDatas[(int)AbilityPropertiesEnum.Ailment]))
                {
                    var ailment = new Ailment((StructPropertyData)ailmentPropertyData);
                    if (!list.Contains(ailment.Name))
                        list.Add(ailment.Name);
                }
            }
            return list;
        }
        
    }
}
