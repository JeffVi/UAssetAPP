using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAssetAPI.PropertyTypes.Objects;
using UAssetAPI.PropertyTypes.Structs;
using static UAssetAPP.OT2.CommonDB.DatabaseProperties;

namespace UAssetAPP.OT2.DataBases.AbilityData
{
    public struct Ability
    {
        public string Name;
        public int ID;
        public int AbilityID;
        public string DisplayName;
        public string Detail;
        public string CommandActor;
        public AbilityTypeEnum AbilityType;
        public AbilityUseTypeEnum AbilityUseType;
        public bool AlwaysDisable;
        public AttributeEnum Attribute;
        public bool DependWeapon;
        public RestrictWeaponEnum RestrictWeapon;
        public TargetTypeEnum TargetType;
        public bool ExceptEnforcer;
        public CostTypeEnum CostType;
        public int CostValue;
        public int HitRatio;
        public int CriticalRatio;
        public int CriticalPower;
        public int AbilityRatio;
        public int BaseCount;
        public int MinimumCount;
        public int RandomCountMin;
        public int RandomCountMax;
        public EstimateOrderTypeEnum EstimateOrderType;
        public int EstimateOrderCount;
        public List<Ailment> AilmentsList;
        public bool KeepBoostEffect;
        public bool EnableItemAll;
        public bool EnableSkillAll;
        public bool EnableConvergence;
        public bool EnableDiffusion;
        public bool EnableReflection;
        public bool EnableCounter;
        public bool EnableHideOut;
        public bool EnableRepeat;
        public bool EnableCover;
        public bool EnableProvoke;
        public bool EnableDisableMagic;
        public bool EnableEnchant;
        public bool EnableChaseAttack;
        public bool EnableWeakCheckAll;
        public bool EnableNormalAttackAll;
        public bool EnableSession;
        public bool EnableBusinessSupport;
        public bool EnableForceWeakness;
        public bool EnableNoUseMaterial;
        public bool EnableSwitchWeapon;
        public bool EnableCompensationMagic;
        public bool EnableExcitement;
        public bool SongAbilityFlag;
        public bool DanceAbilityFlag;
        public bool EnableAutoTameMonster;
        public bool UseAbilityCamera;
        public string ActionCommandSequencer;
        public List<string> AbilitySE;
        public int SlideFrame;

        public Ability(StructPropertyData propertyDataStruct)
        {
            List<PropertyData> propertyDatas = propertyDataStruct.Value as List<PropertyData>;

            if (propertyDatas.Count != Enum.GetValues(typeof(AbilityPropertiesEnum)).Length)
                throw new Exception("Invalid Property Data!");

            Name = propertyDataStruct.Name.ToString();
            ID = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.ID]);
            AbilityID = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.AbilityID]);
            DisplayName = (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.DisplayName]);
            Detail = (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.Detail]);
            CommandActor = (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.CommandActor]);
            AbilityType = AbilityTypeString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.AbilityType])).Key;
            AbilityUseType = AbilityUseTypeString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.AbilityUseType])).Key;
            AlwaysDisable = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.AlwaysDisable]);
            Attribute = AttributeString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.Attribute])).Key;
            DependWeapon = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.DependWeapon]);
            RestrictWeapon = RestrictWeaponString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.RestrictWeapon])).Key;
            TargetType = TargetTypeString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.TargetType])).Key;
            ExceptEnforcer = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.ExceptEnforcer]);
            CostType = CostTypeString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.CostType])).Key;
            CostValue = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.CostValue]);
            HitRatio = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.HitRatio]);
            CriticalRatio = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.CriticalRatio]);
            CriticalPower = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.CriticalPower]);
            AbilityRatio = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.AbilityRatio]);
            BaseCount = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.BaseCount]);
            MinimumCount = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.MinimumCount]);
            RandomCountMin = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.RandomCountMin]);
            RandomCountMax = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.RandomCountMax]);
            EstimateOrderType = EstimateOrderTypeString.AbilityTypeDic.FirstOrDefault(x => x.Value == (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.EstimateOrderType])).Key;
            EstimateOrderCount = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.EstimateOrderCount]);
            AilmentsList = new List<Ailment>();
            foreach (StructPropertyData propertyData in (List<PropertyData>)GetData(propertyDatas[(int)AbilityPropertiesEnum.Ailment]))
            {
                AilmentsList.Add(new Ailment(propertyData));
            }
            KeepBoostEffect = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.KeepBoostEffect]);
            EnableItemAll = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableItemAll]);
            EnableSkillAll = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableSkillAll]);
            EnableConvergence = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableConvergence]);
            EnableDiffusion = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableDiffusion]);
            EnableReflection = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableReflection]);
            EnableCounter = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableCounter]);
            EnableHideOut = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableHideOut]);
            EnableRepeat = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableRepeat]);
            EnableCover = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableCover]);
            EnableProvoke = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableProvoke]);
            EnableDisableMagic = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableDisableMagic]);
            EnableEnchant = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableEnchant]);
            EnableChaseAttack = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableChaseAttack]);
            EnableWeakCheckAll = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableWeakCheckAll]);
            EnableNormalAttackAll = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableNormalAttackAll]);
            EnableSession = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableSession]);
            EnableBusinessSupport = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableBusinessSupport]);
            EnableForceWeakness = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableForceWeakness]);
            EnableNoUseMaterial = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableNoUseMaterial]);
            EnableSwitchWeapon = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableSwitchWeapon]);
            EnableCompensationMagic = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableCompensationMagic]);
            EnableExcitement = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableExcitement]);
            SongAbilityFlag = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.SongAbilityFlag]);
            DanceAbilityFlag = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.DanceAbilityFlag]);
            EnableAutoTameMonster = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.EnableAutoTameMonster]);
            UseAbilityCamera = (bool)GetData(propertyDatas[(int)AbilityPropertiesEnum.UseAbilityCamera]);
            ActionCommandSequencer = (string)GetData(propertyDatas[(int)AbilityPropertiesEnum.ActionCommandSequencer]);
            AbilitySE = new List<string>();
            SlideFrame = (int)GetData(propertyDatas[(int)AbilityPropertiesEnum.SlideFrame]);
        }
    }

    public struct AbilityTypeString
    {
        public const string ENUM_TYPE = "EABILITY_TYPE";
        public const string OTHER = "EABILITY_TYPE::eOTHER";
        public const string PHYSICS = "EABILITY_TYPE::ePHYSICS";
        public const string TAME_MONSTER = "EABILITY_TYPE::eTAME_MONSTER";
        public const string MAGIC = "EABILITY_TYPE::eMAGIC";
        public const string DEBUFF = "EABILITY_TYPE::eDEBUFF";
        public const string BUFF = "EABILITY_TYPE::eBUFF";
        public const string REVIVE = "EABILITY_TYPE::eREVIVE";
        public const string HP_RECOVERY = "EABILITY_TYPE::eHP_RECOVERY";
        public const string MP_RECOVERY = "EABILITY_TYPE::eMP_RECOVERY";
        public const string REVIVE_RECOVERY = "EABILITY_TYPE::eREVIVE_RECOVERY";
        public const string STEAL_MONEY = "EABILITY_TYPE::eSTEAL_MONEY";
        public const string BRIBE = "EABILITY_TYPE::eBRIBE";
        public const string SCATTER = "EABILITY_TYPE::eSCATTER";
        public const string STEAL_ITEM = "EABILITY_TYPE::eSTEAL_ITEM";
        public const string SUMMON = "EABILITY_TYPE::eSUMMON";

        public static readonly Dictionary<AbilityTypeEnum, string> AbilityTypeDic = new Dictionary<AbilityTypeEnum, string>()
        {
            {AbilityTypeEnum.OTHER, OTHER },
            {AbilityTypeEnum.PHYSICS, PHYSICS},
            {AbilityTypeEnum.TAME_MONSTER, TAME_MONSTER},
            {AbilityTypeEnum.MAGIC, MAGIC},
            {AbilityTypeEnum.DEBUFF, DEBUFF},
            {AbilityTypeEnum.BUFF, BUFF},
            {AbilityTypeEnum.REVIVE, REVIVE},
            {AbilityTypeEnum.HP_RECOVERY, HP_RECOVERY},
            {AbilityTypeEnum.MP_RECOVERY, MP_RECOVERY},
            {AbilityTypeEnum.REVIVE_RECOVERY, REVIVE_RECOVERY },
            {AbilityTypeEnum.STEAL_MONEY, STEAL_MONEY},
            {AbilityTypeEnum.BRIBE, BRIBE},
            {AbilityTypeEnum.SCATTER, SCATTER},
            {AbilityTypeEnum.STEAL_ITEM, STEAL_ITEM},
            {AbilityTypeEnum.SUMMON, SUMMON},
        };
    }

    public enum AbilityTypeEnum
    {
        OTHER,
        PHYSICS,
        TAME_MONSTER,
        MAGIC,
        DEBUFF,
        BUFF,
        REVIVE,
        HP_RECOVERY,
        MP_RECOVERY,
        REVIVE_RECOVERY,
        STEAL_MONEY,
        BRIBE, SCATTER,
        STEAL_ITEM,
        SUMMON,
    }

    public struct AbilityUseTypeString
    {
        public const string ENUM_TYPE = "EABILITY_USE_TYPE";
        public const string ALWAYS = "EABILITY_USE_TYPE::eALWAYS";
        public const string BATTLE_ONLY = "EABILITY_USE_TYPE::eBATTLE_ONLY";
        public const string SUPPORT = "EABILITY_USE_TYPE::eSUPPORT";

        public static readonly Dictionary<AbilityUseTypeEnum, string> AbilityTypeDic = new Dictionary<AbilityUseTypeEnum, string>()
        {
            {AbilityUseTypeEnum.ALWAYS, ALWAYS },
            {AbilityUseTypeEnum.BATTLE_ONLY, BATTLE_ONLY},
            {AbilityUseTypeEnum.SUPPORT, SUPPORT},
        };
    }

    public enum AbilityUseTypeEnum
    {
        ALWAYS,
        BATTLE_ONLY,
        SUPPORT,
    }

    public struct AttributeString
    {
        public const string ENUM_TYPE = "EATTRIBUTE_TYPE";
        public const string NONE = "EATTRIBUTE_TYPE::eNONE";
        public const string DARK = "EATTRIBUTE_TYPE::eDARK";
        public const string FIRE = "EATTRIBUTE_TYPE::eFIRE";
        public const string WIND = "EATTRIBUTE_TYPE::eWIND";
        public const string ICE = "EATTRIBUTE_TYPE::eICE";
        public const string THUNDER = "EATTRIBUTE_TYPE::eTHUNDER";
        public const string LIGHT = "EATTRIBUTE_TYPE::eLIGHT";

        public static readonly Dictionary<AttributeEnum, string> AbilityTypeDic = new Dictionary<AttributeEnum, string>()
        {
            {AttributeEnum.NONE, NONE },
            {AttributeEnum.DARK, DARK},
            {AttributeEnum.FIRE, FIRE},
            {AttributeEnum.WIND, WIND},
            {AttributeEnum.ICE, ICE},
            {AttributeEnum.THUNDER, THUNDER},
            {AttributeEnum.LIGHT, LIGHT},
        };
    }

    public enum AttributeEnum
    {
        NONE,
        DARK,
        FIRE,
        WIND,
        ICE,
        THUNDER,
        LIGHT,
    }

    public struct RestrictWeaponString
    {
        public const string ENUM_TYPE = "EWEAPON_CATEGORY";
        public const string NONE = "EWEAPON_CATEGORY::eNONE";
        public const string SWORD = "EWEAPON_CATEGORY::eSWORD";
        public const string LANCE = "EWEAPON_CATEGORY::eLANCE";
        public const string DAGGER = "EWEAPON_CATEGORY::eDAGGER";
        public const string BOW = "EWEAPON_CATEGORY::eBOW";
        public const string AXE = "EWEAPON_CATEGORY::eAXE";
        public const string ROD = "EWEAPON_CATEGORY::eROD";

        public static readonly Dictionary<RestrictWeaponEnum, string> AbilityTypeDic = new Dictionary<RestrictWeaponEnum, string>()
        {
            {RestrictWeaponEnum.NONE, NONE },
            {RestrictWeaponEnum.SWORD, SWORD},
            {RestrictWeaponEnum.LANCE, LANCE},
            {RestrictWeaponEnum.DAGGER, DAGGER},
            {RestrictWeaponEnum.BOW, BOW},
            {RestrictWeaponEnum.AXE, AXE},
            {RestrictWeaponEnum.ROD, ROD},
        };
    }

    public enum RestrictWeaponEnum
    {
        NONE,
        SWORD,
        LANCE,
        DAGGER,
        BOW,
        AXE,
        ROD,
    }

    public struct TargetTypeString
    {
        public const string ENUM_TYPE = "EBATTLE_TARGET_TYPE";
        public const string SELF = "EBATTLE_TARGET_TYPE::eSELF";
        public const string ENEMY_SINGLE = "EBATTLE_TARGET_TYPE::eENEMY_SINGLE";
        public const string ENEMY_ALL = "EBATTLE_TARGET_TYPE::eENEMY_ALL";
        public const string PARTY_ALL = "EBATTLE_TARGET_TYPE::ePARTY_ALL";
        public const string ALL = "EBATTLE_TARGET_TYPE::eALL";
        public const string PARTY_SINGLE = "EBATTLE_TARGET_TYPE::ePARTY_SINGLE";

        public static readonly Dictionary<TargetTypeEnum, string> AbilityTypeDic = new Dictionary<TargetTypeEnum, string>()
        {
            {TargetTypeEnum.SELF, SELF },
            {TargetTypeEnum.ENEMY_SINGLE, ENEMY_SINGLE},
            {TargetTypeEnum.ENEMY_ALL, ENEMY_ALL},
            {TargetTypeEnum.PARTY_ALL, PARTY_ALL},
            {TargetTypeEnum.ALL, ALL},
            {TargetTypeEnum.PARTY_SINGLE, PARTY_SINGLE},
        };
    }

    public enum TargetTypeEnum
    {
        SELF,
        ENEMY_SINGLE,
        ENEMY_ALL,
        PARTY_ALL,
        ALL,
        PARTY_SINGLE,
    }

    public struct CostTypeString
    {
        public const string ENUM_TYPE = "EABILITY_COST_TYPE";
        public const string NONE = "EABILITY_COST_TYPE::eNONE";
        public const string MP = "EABILITY_COST_TYPE::eMP";
        public const string MONEY = "EABILITY_COST_TYPE::eMONEY";
        public const string MP_RATIO = "EABILITY_COST_TYPE::eMP_RATIO";
        public const string INVENTOR = "EABILITY_COST_TYPE::eINVENTOR";

        public static readonly Dictionary<CostTypeEnum, string> AbilityTypeDic = new Dictionary<CostTypeEnum, string>()
        {
            {CostTypeEnum.NONE, NONE },
            {CostTypeEnum.MP, MP},
            {CostTypeEnum.MONEY, MONEY},
            {CostTypeEnum.MP_RATIO, MP_RATIO},
            {CostTypeEnum.INVENTOR, INVENTOR},
        };
    }

    public enum CostTypeEnum
    {
        NONE,
        MP,
        MONEY,
        MP_RATIO,
        INVENTOR,
    }

    public struct EstimateOrderTypeString
    {
        public const string ENUM_TYPE = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE";
        public const string NONE = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eNONE";
        public const string GUARD = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eGUARD";
        public const string COUNT_DOWN = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eCOUNT_DOWN";
        public const string AGI_DOWN = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eAGI_DOWN";
        public const string COUNT_UP_SELF = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eCOUNT_UP_SELF";
        public const string AGI_UP = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eAGI_UP";
        public const string COUNT_UP = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eCOUNT_UP";
        public const string BUFF_COPY = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eBUFF_COPY";
        public const string FIRST_PARTY = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eFIRST_PARTY";
        public const string LAST = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eLAST";
        public const string TOP = "EBATTLE_ACTION_ORDER_ESTIMATE_TYPE::eTOP";

        public static readonly Dictionary<EstimateOrderTypeEnum, string> AbilityTypeDic = new Dictionary<EstimateOrderTypeEnum, string>()
        {
            {EstimateOrderTypeEnum.NONE, NONE },
            {EstimateOrderTypeEnum.GUARD, GUARD},
            {EstimateOrderTypeEnum.COUNT_DOWN, COUNT_DOWN},
            {EstimateOrderTypeEnum.AGI_DOWN, AGI_DOWN},
            {EstimateOrderTypeEnum.COUNT_UP_SELF, COUNT_UP_SELF},
            {EstimateOrderTypeEnum.AGI_UP, AGI_UP},
            {EstimateOrderTypeEnum.COUNT_UP, COUNT_UP},
            {EstimateOrderTypeEnum.BUFF_COPY, BUFF_COPY},
            {EstimateOrderTypeEnum.FIRST_PARTY, FIRST_PARTY},
            {EstimateOrderTypeEnum.LAST, LAST },
            {EstimateOrderTypeEnum.TOP, TOP},
        };
    }

    public enum EstimateOrderTypeEnum
    {
        NONE,
        GUARD,
        COUNT_DOWN,
        AGI_DOWN,
        COUNT_UP_SELF,
        AGI_UP,
        COUNT_UP,
        BUFF_COPY,
        FIRST_PARTY,
        LAST,
        TOP,
    }

    public struct Ailment
    {
        public string Name;
        public int InvocationValue;
        public int InvocationTurn;
        public int DiseaseRate;

        public Ailment(StructPropertyData propertyData)
        {
            NamePropertyData name = (NamePropertyData)propertyData.Value[0];
            IntPropertyData invocVal = (IntPropertyData)propertyData.Value[1];
            IntPropertyData invocTurn = (IntPropertyData)propertyData.Value[2];
            IntPropertyData disRate = (IntPropertyData)propertyData.Value[3];

            Name = name.Value.ToString();
            InvocationValue = invocVal.Value;
            InvocationTurn = invocTurn.Value;
            DiseaseRate = disRate.Value;
        }
    }

    public enum AbilityPropertiesEnum
    {
        ID = 0,
        AbilityID = 1,
        DisplayName = 2,
        Detail = 3,
        CommandActor = 4,
        AbilityType = 5,
        AbilityUseType = 6,
        AlwaysDisable = 7,
        Attribute = 8,
        DependWeapon = 9,
        RestrictWeapon = 10,
        TargetType = 11,
        ExceptEnforcer = 12,
        CostType = 13,
        CostValue = 14,
        HitRatio = 15,
        CriticalRatio = 16,
        CriticalPower = 17,
        AbilityRatio = 18,
        BaseCount = 19,
        MinimumCount = 20,
        RandomCountMin = 21,
        RandomCountMax = 22,
        EstimateOrderType = 23,
        EstimateOrderCount = 24,
        Ailment = 25,
        KeepBoostEffect = 26,
        EnableItemAll = 27,
        EnableSkillAll = 28,
        EnableConvergence = 29,
        EnableDiffusion = 30,
        EnableReflection = 31,
        EnableCounter = 32,
        EnableHideOut = 33,
        EnableRepeat = 34,
        EnableCover = 35,
        EnableProvoke = 36,
        EnableDisableMagic = 37,
        EnableEnchant = 38,
        EnableChaseAttack = 39,
        EnableWeakCheckAll = 40,
        EnableNormalAttackAll = 41,
        EnableSession = 42,
        EnableBusinessSupport = 43,
        EnableForceWeakness = 44,
        EnableNoUseMaterial = 45,
        EnableSwitchWeapon = 46,
        EnableCompensationMagic = 47,
        EnableExcitement = 48,
        SongAbilityFlag = 49,
        DanceAbilityFlag = 50,
        EnableAutoTameMonster = 51,
        UseAbilityCamera = 52,
        ActionCommandSequencer = 53,
        AbilitySE = 54,
        SlideFrame = 55
    }
}
