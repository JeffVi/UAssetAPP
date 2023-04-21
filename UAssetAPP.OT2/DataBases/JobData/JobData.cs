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

namespace UAssetAPP.OT2.DataBases.JobData
{
    public class JobData : UAssetDB
    {
        public JobData(string path) : base(path, EngineVersion.VER_UE4_27) { }

        public Job GetJob(int index)
        {
            return new Job(data[index]);
        }

        public Job GetJob(string name)
        {
            return new Job(data[names.IndexOf(name)]);
        }

        public void SetJob(Job job)
        {
            int index = names.IndexOf(job.Name);
            if (index < 0)
                return;
            
            /***** Lists *****/
            
            SetCommandAbilityArrayData(index, job.JobCommandAbility);
            SetSupportAbilityArrayData(index, job.JobSupportAbility);
            SetJPCostArrayData(index, job.JPCost);
            SetProperEquipmentArrayData(index, job.ProperEquipment);
            SetParameterRevisionArrayData(index, job.ParameterRevision);

            UpdateAsset();
        }

        private void SetCommandAbilityArrayData(int index, List<JobCommandAbility> jobCommandAbilities)
        {
            List<PropertyData> jobToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(jobToUpdate[(int)JobPropertiesEnum.JobCommandAbility]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < jobCommandAbilities.Count; i++)
            {
                SetCommandAbilityData(arrayDataValue[i], jobCommandAbilities[i]);
            }

        }

        private void SetCommandAbilityData(PropertyData commandAbilityData, JobCommandAbility jobCommandAbility)
        {
            StructPropertyData? commandAbility = commandAbilityData as StructPropertyData;

            if (commandAbility is null)
                return;

            NamePropertyData name = (NamePropertyData)commandAbility.Value[0];
            IntPropertyData getParam = (IntPropertyData)commandAbility.Value[1];

            name.FromString(new string[] { jobCommandAbility.Name }, uAsset);
            getParam.FromString(new string[] { $"{(int)jobCommandAbility.Param}" }, uAsset);
        }

        private void SetSupportAbilityArrayData(int index, List<JobSupportAbility> jobSupportbilities)
        {
            List<PropertyData> jobToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(jobToUpdate[(int)JobPropertiesEnum.JobSupportAbility]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < jobSupportbilities.Count; i++)
            {
                SetSupportAbilityData(arrayDataValue[i], jobSupportbilities[i]);
            }

        }

        private void SetSupportAbilityData(PropertyData supportAbilityData, JobSupportAbility jobCommandAbility)
        {
            StructPropertyData? supportAbility = supportAbilityData as StructPropertyData;

            if (supportAbility is null)
                return;

            NamePropertyData name = (NamePropertyData)supportAbility.Value[0];
            IntPropertyData getParam = (IntPropertyData)supportAbility.Value[1];

            name.FromString(new string[] { jobCommandAbility.Name }, uAsset);
            getParam.FromString(new string[] { $"{jobCommandAbility.NumberOfLearnedAbilitiesToUnlock}" }, uAsset);
        }

        private void SetJPCostArrayData(int index, List<int> jpCosts)
        {
            List<PropertyData> jobToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(jobToUpdate[(int)JobPropertiesEnum.JPCost]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < jpCosts.Count; i++)
            {
                IntPropertyData cost = (IntPropertyData)arrayDataValue[i];
                cost.FromString(new string[] { $"{jpCosts[i]}" }, uAsset);
            }

        }

        private void SetProperEquipmentArrayData(int index, List<bool> properEquipment)
        {
            List<PropertyData> jobToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(jobToUpdate[(int)JobPropertiesEnum.ProperEquipment]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < properEquipment.Count; i++)
            {
                BoolPropertyData equipment = (BoolPropertyData)arrayDataValue[i];
                equipment.FromString(new string[] { $"{properEquipment[i]}" }, uAsset);
            }

        }

        private void SetParameterRevisionArrayData(int index, List<int> parameterRevision)
        {
            List<PropertyData> jobToUpdate = (List<PropertyData>)data[index].Value;
            List<PropertyData> arrayDataValue = (List<PropertyData>)GetData(jobToUpdate[(int)JobPropertiesEnum.ParameterRevision]);

            if (arrayDataValue is null)
                return;

            if (arrayDataValue.Count < 1)
                return;

            for (int i = 0; i < parameterRevision.Count; i++)
            {
                IntPropertyData stat = (IntPropertyData)arrayDataValue[i];
                stat.FromString(new string[] { $"{parameterRevision[i]}" }, uAsset);
            }

        }

    }
}
