using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using UAssetAPP.OT2.DataBases.AbilityData;
using static UAssetAPP.OT2.CommonDB.DatabaseProperties;

namespace UAssetAPP.OT2.DataBases.JobData
{
    public struct Job
    {
        public string Name;
        public int ID;
        public int JobID;
        public string DisplayName;
        public string Detail;
        public int DisplayOrder;
        public string MenuJobIcon;
        public string AbilityJobIcon;
        public int PermissionFlag;
        public string EquipJobItem;
        public List<bool> ProperEquipment;
        public List<int> ParameterRevision;
        public string JobCommandName;
        public string JobCommandDetail;
        public List<JobCommandAbility> JobCommandAbility;
        public List<JobSupportAbility> JobSupportAbility;
        public List<int> JPCost;

        public Job(StructPropertyData propertyDataStruct)
        {
            List<PropertyData> propertyDatas = propertyDataStruct.Value as List<PropertyData>;

            if (propertyDatas.Count != Enum.GetValues(typeof(JobPropertiesEnum)).Length)
                throw new Exception("Invalid Property Data!");

            Name = propertyDataStruct.Name.ToString();
            ID = (int)GetData(propertyDatas[(int)JobPropertiesEnum.ID]);
            JobID = (int)GetData(propertyDatas[(int)JobPropertiesEnum.JobID]);
            DisplayName = (string)GetData(propertyDatas[(int)JobPropertiesEnum.DisplayName]);
            Detail = (string)GetData(propertyDatas[(int)JobPropertiesEnum.Detail]);
            DisplayOrder = (int)GetData(propertyDatas[(int)JobPropertiesEnum.DisplayOrder]);
            MenuJobIcon = (string)GetData(propertyDatas[(int)JobPropertiesEnum.MenuJobIcon]);
            AbilityJobIcon = (string)GetData(propertyDatas[(int)JobPropertiesEnum.AbilityJobIcon]);
            PermissionFlag = (int)GetData(propertyDatas[(int)JobPropertiesEnum.PermissionFlag]);
            EquipJobItem = (string)GetData(propertyDatas[(int)JobPropertiesEnum.EquipJobItem]);
            ProperEquipment = new List<bool>();
            foreach (BoolPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)JobPropertiesEnum.ProperEquipment]))
            {
                ProperEquipment.Add(propertyData.Value);
            }
            ParameterRevision = new List<int>();
            foreach (IntPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)JobPropertiesEnum.ParameterRevision]))
            {
                ParameterRevision.Add(propertyData.Value);
            }
            JobCommandName = (string)GetData(propertyDatas[(int)JobPropertiesEnum.JobCommandName]);
            JobCommandDetail = (string)GetData(propertyDatas[(int)JobPropertiesEnum.JobCommandDetail]);
            JobCommandAbility = new List<JobCommandAbility>();
            foreach (StructPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)JobPropertiesEnum.JobCommandAbility]))
            {
                JobCommandAbility.Add(new JobCommandAbility(propertyData));
            }
            JobSupportAbility = new List<JobSupportAbility>();
            foreach (StructPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)JobPropertiesEnum.JobSupportAbility]))
            {
                JobSupportAbility.Add(new JobSupportAbility(propertyData));
            }
            JPCost = new List<int>();
            foreach (IntPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)JobPropertiesEnum.JPCost]))
            {
                JPCost.Add(propertyData.Value);
            }
        }
    }

    public struct JobCommandAbility
    {
        public string Name;
        public JobCommandAbilityParamEnum Param;

        public JobCommandAbility(StructPropertyData propertyData)
        {
            NamePropertyData name = (NamePropertyData)propertyData.Value[0];
            IntPropertyData getParam = (IntPropertyData)propertyData.Value[1];

            Name = name.Value.ToString();
            Param = (JobCommandAbilityParamEnum)getParam.Value;
        }
    }

    public enum JobCommandAbilityParamEnum
    {
        Locked_CostJP = 0,
        Unlocked_FromStart = 1,
        LockedDivine_UnlockLast = 2,
    }

    public struct JobSupportAbility
    {
        public string Name;
        public int NumberOfLearnedAbilitiesToUnlock;

        public JobSupportAbility(StructPropertyData propertyData)
        {
            NamePropertyData name = (NamePropertyData)propertyData.Value[0];
            IntPropertyData getParam = (IntPropertyData)propertyData.Value[1];

            Name = name.Value.ToString();
            NumberOfLearnedAbilitiesToUnlock = getParam.Value;
        }
    }

    public enum JobPropertiesEnum
    {
        ID = 0,
        JobID = 1,
        DisplayName = 2,
        Detail = 3,
        DisplayOrder = 4,
        MenuJobIcon = 5,
        AbilityJobIcon = 6,
        PermissionFlag = 7,
        EquipJobItem = 8,
        ProperEquipment = 9,
        ParameterRevision = 10,
        JobCommandName = 11,
        JobCommandDetail = 12,
        JobCommandAbility = 13,
        JobSupportAbility = 14,
        JPCost = 15,
    }

    public enum JobEquipmentEnum
    {
        Sword = 0,
        Spear = 1,
        Dagger = 2,
        Axe = 3,
        Bow = 4,
        Staff = 5,
        Shield = 6,
        UNKNOWN_1 = 7,
        UNKNOWN_2 = 8,
        Head = 9,
        Body = 10,
        UNKNOWN_3 = 11,
        UNKNOWN_4 = 12,
        Accessories = 13,
    }

    public enum JobParameterEnum
    {
        HP = 0,
        MP = 1,
        BP = 2,
        SP = 3,
        POT = 4,
        ATK = 5,
        DEF = 6,
        MATK = 7,
        MDEF = 8,
        ACC = 9,
        EVA = 10,
        CON = 11,
        AGI = 12,
    }
}
