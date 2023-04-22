using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using static UAssetAPP.OT2.CommonDB.DatabaseProperties;

namespace UAssetAPP.OT2.DataBases.EnemyDB
{
    public struct Enemy
    {
        public string Name;
        public int EnemyID;
        public string DisplayNameID;
        public string RessourceLabel;
        public int DisplayRank;
        public int EnemyLevel;
        public float DamageRatio;
        public SizeEnum Size;
        public bool NPCFlag;
        public WeaponStanceEnum WeaponStance;
        public string WeaponItemLabel;
        public bool DeadEffectSlow;
        public bool MainEnemy;
        public bool NonPartBattle;
        public bool UseCatDamageType;
        public bool DisableDeadKnockBack;
        public List<int> Param;
        public int Exp;
        public int JobPoint;
        public int Money;
        public int StealMoney;
        public bool TameEnable;
        public float DefaultTameRate;
        public string InvadeMonsterId;
        public int FirstBP;
        public DeadTypeEnum DeadType;
        public List<AttributeResistEnum> AttributeResist;
        public List<AttributeResistEnum> WeaponResist;
        public List<AttributeResistEnum> DiseaseResist;
        public bool StealGuard;
        public string HaveItemID;
        public int DropProbability;
        public string EnemyAI;
        public List<string> EnemyAbility;
        public List<double> DiseaseEffectOffset;    // size 3
        public List<double> EnemyEffectOffset;      // size 3
        public List<double> StatusUIOffset;         // size 3
        public List<double> DamageUIOffset;         // size 3
        public List<double> IconL_UV;               // size 2
        public List<double> PixelScaleL;            // size 2
        public List<double> IconS_UV;               // size 2
        public List<double> PixelScaleS;            // size 2
        public List<double> SPDiseaseEffectOffset;  // size 3
        public List<double> SPEnemyEffectOffset;    // size 3
        public List<double> SPStatusUIOffset;       // size 3
        public List<double> SPDamagneUIOffset;      // size 3
        public bool StealMoneyGuard;
        public string StealItemID;
        public float AbilitySEDelay;
        public string TextInfoLabel;
        public bool BribeGuard;
        public int BribeMoney;
        public int RevealShieldPoint;
        public string RevealEnemyAI;
        public string DismantlingLabel;
        public List<double> WarpOffset;             // size 3
        public bool LegendTameMonster;
        public List<string> ActionModeRessourceList;
        public int WaitEnemyActionFrame;
        public bool DisableBreakSlow;
        public int ID;
        public bool NotInsertOrderWithCallEnemy;
        public BreakCameraTypeEnum BreakCameraType;
        
        public Enemy(StructPropertyData propertyDataStruct)
        {
            List<PropertyData> propertyDatas = propertyDataStruct.Value as List<PropertyData>;

            if (propertyDatas.Count != Enum.GetValues(typeof(EnemyPropertiesEnum)).Length)
                throw new Exception("Invalid Property Data!");

            Name = propertyDataStruct.Name.ToString();
            EnemyID = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.EnemyID]);
            DisplayNameID = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.DisplayNameID]);
            RessourceLabel = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.RessourceLabel]);
            DisplayRank = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.DisplayRank]);
            EnemyLevel = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.EnemyLevel]);
            DamageRatio = (float)GetData(propertyDatas[(int)EnemyPropertiesEnum.DamageRatio]);
            Size = SizeString.TypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.Size])).Key;
            NPCFlag = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.NPCFlag]);
            WeaponStance = WeaponStanceString.TypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.WeaponStance])).Key;
            WeaponItemLabel = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.WeaponItemLabel]);
            DeadEffectSlow = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.DeadEffectSlow]);
            MainEnemy = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.MainEnemy]);
            NonPartBattle = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.NonPartBattle]);
            UseCatDamageType = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.UseCatDamageType]);
            DisableDeadKnockBack = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.DisableDeadKnockBack]);
            Param = new List<int>();
            foreach (IntPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.Param]))
            {
                Param.Add(propertyData.Value);
            }
            Exp = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.Exp]);
            JobPoint = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.JobPoint]);
            Money = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.Money]);
            StealMoney = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.StealMoney]);
            TameEnable = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.TameEnable]);
            DefaultTameRate = (float)GetData(propertyDatas[(int)EnemyPropertiesEnum.DefaultTameRate]);
            InvadeMonsterId = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.InvadeMonsterId]);
            FirstBP = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.FirstBP]);
            DeadType = DeadTypeString.TypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.DeadType])).Key;
            AttributeResist = new List<AttributeResistEnum>();
            foreach (EnumPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.AttributeResist]))
            {
                AttributeResist.Add(AttributeResistString.TypeDic.FirstOrDefault(x => x.Value == propertyData.Value.Value.Value).Key);
            }
            WeaponResist = new List<AttributeResistEnum>();
            foreach (EnumPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.WeaponResist]))
            {
                WeaponResist.Add(AttributeResistString.TypeDic.FirstOrDefault(x => x.Value == propertyData.Value.Value.Value).Key);
            }
            DiseaseResist = new List<AttributeResistEnum>();
            foreach (EnumPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.DiseaseResist]))
            {
                DiseaseResist.Add(AttributeResistString.TypeDic.FirstOrDefault(x => x.Value == propertyData.Value.Value.Value).Key);
            }
            StealGuard = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.StealGuard]);
            HaveItemID = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.HaveItemID]);
            DropProbability = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.DropProbability]);
            EnemyAI = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.EnemyAI]);
            EnemyAbility = new List<string>();
            foreach (NamePropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.EnemyAbility]))
            {
                EnemyAbility.Add(propertyData.Value.Value.Value);
            }
            DiseaseEffectOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.DiseaseEffectOffset]))
            {
                DiseaseEffectOffset.Add(propertyData.Value.X);
                DiseaseEffectOffset.Add(propertyData.Value.Y);
                DiseaseEffectOffset.Add(propertyData.Value.Z);
            }
            EnemyEffectOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.EnemyEffectOffset]))
            {
                EnemyEffectOffset.Add(propertyData.Value.X);
                EnemyEffectOffset.Add(propertyData.Value.Y);
                EnemyEffectOffset.Add(propertyData.Value.Z);
            }
            StatusUIOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.StatusUIOffset]))
            {
                StatusUIOffset.Add(propertyData.Value.X);
                StatusUIOffset.Add(propertyData.Value.Y);
                StatusUIOffset.Add(propertyData.Value.Z);
            }
            DamageUIOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.DamageUIOffset]))
            {
                DamageUIOffset.Add(propertyData.Value.X);
                DamageUIOffset.Add(propertyData.Value.Y);
                DamageUIOffset.Add(propertyData.Value.Z);
            }
            IconL_UV = new List<double>();
            foreach (Vector2DPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.IconL_UV]))
            {
                IconL_UV.Add(propertyData.X);
                IconL_UV.Add(propertyData.Y);
            }
            PixelScaleL = new List<double>();
            foreach (Vector2DPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.PixelScaleL]))
            {
                PixelScaleL.Add(propertyData.X);
                PixelScaleL.Add(propertyData.Y);
            }
            IconS_UV = new List<double>();
            foreach (Vector2DPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.IconS_UV]))
            {
                IconS_UV.Add(propertyData.X);
                IconS_UV.Add(propertyData.Y);
            }
            PixelScaleS = new List<double>();
            foreach (Vector2DPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.PixelScaleS]))
            {
                PixelScaleS.Add(propertyData.X);
                PixelScaleS.Add(propertyData.Y);
            }
            SPDiseaseEffectOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.SPDiseaseEffectOffset]))
            {
                SPDiseaseEffectOffset.Add(propertyData.Value.X);
                SPDiseaseEffectOffset.Add(propertyData.Value.Y);
                SPDiseaseEffectOffset.Add(propertyData.Value.Z);
            }
            SPEnemyEffectOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.SPEnemyEffectOffset]))
            {
                SPEnemyEffectOffset.Add(propertyData.Value.X);
                SPEnemyEffectOffset.Add(propertyData.Value.Y);
                SPEnemyEffectOffset.Add(propertyData.Value.Z);
            }
            SPStatusUIOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.SPStatusUIOffset]))
            {
                SPStatusUIOffset.Add(propertyData.Value.X);
                SPStatusUIOffset.Add(propertyData.Value.Y);
                SPStatusUIOffset.Add(propertyData.Value.Z);
            }
            SPDamagneUIOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.SPDamagneUIOffset]))
            {
                SPDamagneUIOffset.Add(propertyData.Value.X);
                SPDamagneUIOffset.Add(propertyData.Value.Y);
                SPDamagneUIOffset.Add(propertyData.Value.Z);
            }
            StealMoneyGuard = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.StealMoneyGuard]);
            StealItemID = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.StealItemID]);
            AbilitySEDelay = (float)GetData(propertyDatas[(int)EnemyPropertiesEnum.AbilitySEDelay]);
            TextInfoLabel = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.TextInfoLabel]);
            BribeGuard = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.BribeGuard]);
            BribeMoney = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.BribeMoney]);
            RevealShieldPoint = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.RevealShieldPoint]);
            RevealEnemyAI = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.RevealEnemyAI]);
            DismantlingLabel = (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.DismantlingLabel]);
            WarpOffset = new List<double>();
            foreach (VectorPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.WarpOffset]))
            {
                WarpOffset.Add(propertyData.Value.X);
                WarpOffset.Add(propertyData.Value.Y);
                WarpOffset.Add(propertyData.Value.Z);
            }
            LegendTameMonster = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.LegendTameMonster]);
            ActionModeRessourceList = new List<string>();
            foreach (NamePropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)EnemyPropertiesEnum.ActionModeRessourceList]))
            {
                ActionModeRessourceList.Add(propertyData.Value.Value.Value);
            }
            WaitEnemyActionFrame = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.WaitEnemyActionFrame]);
            DisableBreakSlow = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.DisableBreakSlow]);
            ID = (int)GetData(propertyDatas[(int)EnemyPropertiesEnum.ID]);
            NotInsertOrderWithCallEnemy = (bool)GetData(propertyDatas[(int)EnemyPropertiesEnum.NotInsertOrderWithCallEnemy]);
            BreakCameraType = BreakCameraTypeString.TypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)EnemyPropertiesEnum.BreakCameraType])).Key;
        }
    }

    public struct SizeString
    {
        public const string ENUM_TYPE = "ECHARACTER_SIZE";
        public const string LARGE = "ECHARACTER_SIZE::eLARGE";
        public const string MEDIUM = "ECHARACTER_SIZE::eMEDIUM";
        public const string SMALL = "ECHARACTER_SIZE::eSMALL";

        public static readonly Dictionary<SizeEnum, string> TypeDic = new Dictionary<SizeEnum, string>()
        {
            {SizeEnum.LARGE, LARGE },
            {SizeEnum.MEDIUM, MEDIUM},
            {SizeEnum.SMALL, SMALL},
        };
    }

    public enum SizeEnum
    {
        LARGE,
        MEDIUM,
        SMALL,
    }

    public struct WeaponStanceString
    {
        public const string ENUM_TYPE = "EWEAPON_STANCE";
        public const string NONE = "EWEAPON_STANCE::NONE";
        public const string MALE = "EWEAPON_STANCE::MALE";
        public const string FEMALE = "EWEAPON_STANCE::FEMALE";
        public const string MALE_LARGE = "EWEAPON_STANCE::MALE_LARGE";

        public static readonly Dictionary<WeaponStanceEnum, string> TypeDic = new Dictionary<WeaponStanceEnum, string>()
        {
            {WeaponStanceEnum.NONE, NONE },
            {WeaponStanceEnum.MALE, MALE},
            {WeaponStanceEnum.FEMALE, FEMALE},
            {WeaponStanceEnum.MALE_LARGE, MALE_LARGE},
        };
    }

    public enum WeaponStanceEnum
    {
        NONE,
        MALE,
        FEMALE,
        MALE_LARGE,
    }

    public struct DeadTypeString
    {
        public const string ENUM_TYPE = "EENEMY_DEAD_TYPE";
        public const string BOSS_L = "EENEMY_DEAD_TYPE::eBOSS_L";
        public const string NORMAL_M = "EENEMY_DEAD_TYPE::eNORMAL_M";
        public const string DESTRUCTION = "EENEMY_DEAD_TYPE::eDESTRUCTION";
        public const string NORMAL_S = "EENEMY_DEAD_TYPE::eNORMAL_S";
        public const string RETURN = "EENEMY_DEAD_TYPE::eRETURN";
        public const string BOSS_M = "EENEMY_DEAD_TYPE::eBOSS_M";
        public const string NORMAL_L = "EENEMY_DEAD_TYPE::eNORMAL_L";
        public const string NO_KNOCKBACK_M = "EENEMY_DEAD_TYPE::eNO_KNOCKBACK_M";
        public const string GALDERA_VANISH = "EENEMY_DEAD_TYPE::eGALDERA_VANISH";

        public static readonly Dictionary<DeadTypeEnum, string> TypeDic = new Dictionary<DeadTypeEnum, string>()
        {
            {DeadTypeEnum.BOSS_L, BOSS_L },
            {DeadTypeEnum.NORMAL_M, NORMAL_M},
            {DeadTypeEnum.DESTRUCTION, DESTRUCTION},
            {DeadTypeEnum.NORMAL_S, NORMAL_S},
            {DeadTypeEnum.RETURN, RETURN},
            {DeadTypeEnum.BOSS_M, BOSS_M},
            {DeadTypeEnum.NORMAL_L, NORMAL_L},
            {DeadTypeEnum.NO_KNOCKBACK_M, NO_KNOCKBACK_M},
            {DeadTypeEnum.GALDERA_VANISH, GALDERA_VANISH},
        };
    }

    public enum DeadTypeEnum
    {
        BOSS_L,
        NORMAL_M,
        DESTRUCTION,
        NORMAL_S,
        RETURN,
        BOSS_M,
        NORMAL_L,
        NO_KNOCKBACK_M,
        GALDERA_VANISH,
    }

    public struct AttributeResistString
    {
        public const string ENUM_TYPE = "null";
        public const string NONE = "EATTRIBUTE_RESIST::eNONE";
        public const string WEAK = "EATTRIBUTE_RESIST::eWEAK";
        public const string REDUCE = "EATTRIBUTE_RESIST::eREDUCE";
        public const string INVALID = "EATTRIBUTE_RESIST::eINVALID";

        public static readonly Dictionary<AttributeResistEnum, string> TypeDic = new Dictionary<AttributeResistEnum, string>()
        {
            {AttributeResistEnum.NONE, NONE },
            {AttributeResistEnum.WEAK, WEAK},
            {AttributeResistEnum.REDUCE, REDUCE},
            {AttributeResistEnum.INVALID, INVALID},
        };
    }

    public enum AttributeResistEnum
    {
        NONE,
        WEAK,
        REDUCE,
        INVALID,
    }

    public struct BreakCameraTypeString
    {
        public const string ENUM_TYPE = "EBREAK_CAMERA_TYPE";
        public const string NORMAL = "EBREAK_CAMERA_TYPE::eNORMAL";
        public const string WIDE = "EBREAK_CAMERA_TYPE::eWIDE";
        public const string WIDE_TILTUP = "EBREAK_CAMERA_TYPE::eWIDE_TILTUP";
        public const string VIDE_SECOND = "EBREAK_CAMERA_TYPE::eVIDE_SECOND";

        public static readonly Dictionary<BreakCameraTypeEnum, string> TypeDic = new Dictionary<BreakCameraTypeEnum, string>()
        {
            {BreakCameraTypeEnum.NORMAL, NORMAL },
            {BreakCameraTypeEnum.WIDE, WIDE},
            {BreakCameraTypeEnum.WIDE_TILTUP, WIDE_TILTUP},
            {BreakCameraTypeEnum.VIDE_SECOND, VIDE_SECOND},
        };
    }

    public enum BreakCameraTypeEnum
    {
        NORMAL,
        WIDE,
        WIDE_TILTUP,
        VIDE_SECOND,
    }

    public enum EnemyParamEnum
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

    public enum EnemyPropertiesEnum
    {
        EnemyID = 0,
        DisplayNameID = 1,
        RessourceLabel = 2,
        DisplayRank = 3,
        EnemyLevel = 4,
        DamageRatio = 5,
        Size = 6,
        NPCFlag = 7,
        WeaponStance = 8,
        WeaponItemLabel = 9,
        DeadEffectSlow = 10,
        MainEnemy = 11,
        NonPartBattle = 12,
        UseCatDamageType = 13,
        DisableDeadKnockBack = 14,
        Param = 15,
        Exp = 16,
        JobPoint = 17,
        Money = 18,
        StealMoney = 19,
        TameEnable = 20,
        DefaultTameRate = 21,
        InvadeMonsterId = 22,
        FirstBP = 23,
        DeadType = 24,
        AttributeResist = 25,
        WeaponResist = 26,
        DiseaseResist = 27,
        StealGuard = 28,
        HaveItemID = 29,
        DropProbability = 30,
        EnemyAI = 31,
        EnemyAbility = 32,
        DiseaseEffectOffset = 33,
        EnemyEffectOffset = 34,
        StatusUIOffset = 35,
        DamageUIOffset = 36,
        IconL_UV = 37,
        PixelScaleL = 38,
        IconS_UV = 39,
        PixelScaleS = 40,
        SPDiseaseEffectOffset = 41,
        SPEnemyEffectOffset = 42,
        SPStatusUIOffset = 43,
        SPDamagneUIOffset = 44,
        StealMoneyGuard = 45,
        StealItemID = 46,
        AbilitySEDelay = 47,
        TextInfoLabel = 48,
        BribeGuard = 49,
        BribeMoney = 50,
        RevealShieldPoint = 51,
        RevealEnemyAI = 52,
        DismantlingLabel = 53,
        WarpOffset = 54,
        LegendTameMonster = 55,
        ActionModeRessourceList = 56,
        WaitEnemyActionFrame = 57,
        DisableBreakSlow = 58,
        ID = 59,
        NotInsertOrderWithCallEnemy = 60,
        BreakCameraType = 61,
    }
}
