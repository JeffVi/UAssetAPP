using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAssetAPP.OT2.DataBases.AbilityData;

namespace AppGUI.UserControlPanels
{
    public partial class AbilityDataUC : UserControl, IUserControlDB
    {
        public AbilityDataUC()
        {
            InitializeComponent();
        }

        #region AbilityData

        public void InitItems()
        {
            AbilityDataEnumBox1.Items.Clear();
            AbilityDataEnumBox1.Items.AddRange(Enum.GetNames(typeof(AbilityTypeEnum)));
            AbilityDataEnumLabel1.Text = AbilityTypeString.ENUM_TYPE;
            AbilityDataEnumBox2.Items.Clear();
            AbilityDataEnumBox2.Items.AddRange(Enum.GetNames(typeof(AttributeEnum)));
            AbilityDataEnumLabel2.Text = AttributeString.ENUM_TYPE;
            AbilityDataEnumBox3.Items.Clear();
            AbilityDataEnumBox3.Items.AddRange(Enum.GetNames(typeof(RestrictWeaponEnum)));
            AbilityDataEnumLabel3.Text = RestrictWeaponString.ENUM_TYPE;
            AbilityDataEnumBox4.Items.Clear();
            AbilityDataEnumBox4.Items.AddRange(Enum.GetNames(typeof(TargetTypeEnum)));
            AbilityDataEnumLabel4.Text = TargetTypeString.ENUM_TYPE;
            AbilityDataEnumBox5.Items.Clear();
            AbilityDataEnumBox5.Items.AddRange(Enum.GetNames(typeof(CostTypeEnum)));
            AbilityDataEnumLabel5.Text = CostTypeString.ENUM_TYPE;
            AbilityDataEnumBox6.Items.Clear();
            AbilityDataEnumBox6.Items.AddRange(Enum.GetNames(typeof(EstimateOrderTypeEnum)));
            AbiDatAilmentNameComboBox.Items.Clear();
            AbiDatAilmentNameComboBox.Items.AddRange(RessourcesManager.ailmentNamesList?.ToArray());
        }

        public void UpdateItemData()
        {
            if (RessourcesManager.selectedAbility is null)
                return;

            try
            {
                Ability newAbility = RessourcesManager.selectedAbility.Value;
                newAbility.CostValue = int.Parse(AbilityDataCostValueTextBox.Text);
                newAbility.HitRatio = int.Parse(AbilityDataHitRatioTextBox.Text);
                newAbility.CriticalRatio = int.Parse(AbilityDataCriticalRatioTextBox.Text);
                newAbility.CriticalPower = int.Parse(AbilityDataCriticalPowerTextBox.Text);
                newAbility.AbilityRatio = int.Parse(AbilityDataAbilityRatioTextBox.Text);
                newAbility.BaseCount = int.Parse(AbilityDataBaseCountTextBox.Text);
                newAbility.MinimumCount = int.Parse(AbilityDataMinimumCountTextBox.Text);
                newAbility.RandomCountMin = int.Parse(AbilityDataRandomCountMinTextBox.Text);
                newAbility.RandomCountMax = int.Parse(AbilityDataRandomCountMaxTextBox.Text);
                newAbility.EstimateOrderCount = int.Parse(AbilityDataEstOrdCountTextBox.Text);

                newAbility.CommandActor = AbiDatCommandActorTextBox.Text;
                newAbility.ActionCommandSequencer = AbiDatActCmdSeqTextBox.Text;
                newAbility.DisplayName = AbilityDataDisplayNameTextBox.Text;
                newAbility.Detail = AbilityDataDetailTextBox.Text;

                newAbility.AlwaysDisable = AbiCheckAlwaysDisable.Checked;
                newAbility.DependWeapon = AbiCheckDependWeapon.Checked;
                newAbility.ExceptEnforcer = AbiCheckExceptEnforcer.Checked;
                newAbility.KeepBoostEffect = AbiCheckKeepBoostEffect.Checked;
                newAbility.EnableItemAll = AbiCheckEnableItemAll.Checked;
                newAbility.EnableSkillAll = AbiCheckEnableSkillAll.Checked;
                newAbility.EnableConvergence = AbiCheckEnableConvergence.Checked;
                newAbility.EnableDiffusion = AbiCheckEnableDiffusion.Checked;
                newAbility.EnableReflection = AbiCheckEnableReflection.Checked;
                newAbility.EnableCounter = AbiCheckEnableCounter.Checked;
                newAbility.EnableHideOut = AbiCheckEnableHideOut.Checked;
                newAbility.EnableRepeat = AbiCheckEnableRepeat.Checked;
                newAbility.EnableCover = AbiCheckEnableCover.Checked;
                newAbility.EnableProvoke = AbiCheckEnableProvoke.Checked;
                newAbility.EnableDisableMagic = AbiCheckEnableDisableMagic.Checked;
                newAbility.EnableEnchant = AbiCheckEnableEnchant.Checked;
                newAbility.EnableChaseAttack = AbiCheckEnableChaseAttack.Checked;
                newAbility.EnableWeakCheckAll = AbiCheckEnableWeakCheckAll.Checked;
                newAbility.EnableNormalAttackAll = AbiCheckEnableNormalAttackAll.Checked;
                newAbility.EnableSession = AbiCheckEnableSession.Checked;
                newAbility.EnableBusinessSupport = AbiCheckEnableBusinessSupport.Checked;
                newAbility.EnableForceWeakness = AbiCheckEnableForceWeakness.Checked;
                newAbility.EnableNoUseMaterial = AbiCheckEnableNoUseMaterial.Checked;
                newAbility.EnableSwitchWeapon = AbiCheckEnableSwitchWeapon.Checked;
                newAbility.EnableCompensationMagic = AbiCheckEnableCompensationMagic.Checked;
                newAbility.EnableExcitement = AbiCheckEnableExcitement.Checked;
                newAbility.SongAbilityFlag = AbiCheckSongAbilityFlag.Checked;
                newAbility.DanceAbilityFlag = AbiCheckDanceAbilityFlag.Checked;
                newAbility.EnableAutoTameMonster = AbiCheckEnableAutoTameMonster.Checked;
                newAbility.UseAbilityCamera = AbiCheckUseAbilityCamera.Checked;

                newAbility.AbilityType = (AbilityTypeEnum)AbilityDataEnumBox1.SelectedIndex;
                newAbility.Attribute = (AttributeEnum)AbilityDataEnumBox2.SelectedIndex;
                newAbility.RestrictWeapon = (RestrictWeaponEnum)AbilityDataEnumBox3.SelectedIndex;
                newAbility.TargetType = (TargetTypeEnum)AbilityDataEnumBox4.SelectedIndex;
                newAbility.CostType = (CostTypeEnum)AbilityDataEnumBox5.SelectedIndex;
                newAbility.EstimateOrderType = (EstimateOrderTypeEnum)AbilityDataEnumBox6.SelectedIndex;

                RessourcesManager.selectedAbility = newAbility;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }

        public void ItemNameDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedAbility is not null)
            {
                try
                {
                    AbilityDataCostValueTextBox.Text = RessourcesManager.selectedAbility.Value.CostValue.ToString();
                    AbilityDataHitRatioTextBox.Text = RessourcesManager.selectedAbility.Value.HitRatio.ToString();
                    AbilityDataCriticalRatioTextBox.Text = RessourcesManager.selectedAbility.Value.CriticalRatio.ToString();
                    AbilityDataCriticalPowerTextBox.Text = RessourcesManager.selectedAbility.Value.CriticalPower.ToString();
                    AbilityDataAbilityRatioTextBox.Text = RessourcesManager.selectedAbility.Value.AbilityRatio.ToString();
                    AbilityDataBaseCountTextBox.Text = RessourcesManager.selectedAbility.Value.BaseCount.ToString();
                    AbilityDataMinimumCountTextBox.Text = RessourcesManager.selectedAbility.Value.MinimumCount.ToString();
                    AbilityDataRandomCountMinTextBox.Text = RessourcesManager.selectedAbility.Value.RandomCountMin.ToString();
                    AbilityDataRandomCountMaxTextBox.Text = RessourcesManager.selectedAbility.Value.RandomCountMax.ToString();
                    AbilityDataEstOrdCountTextBox.Text = RessourcesManager.selectedAbility.Value.EstimateOrderCount.ToString();

                    AbiDatCommandActorTextBox.Text = RessourcesManager.selectedAbility.Value.CommandActor;
                    AbiDatActCmdSeqTextBox.Text = RessourcesManager.selectedAbility.Value.ActionCommandSequencer;
                    AbilityDataDisplayNameTextBox.Text = RessourcesManager.selectedAbility.Value.DisplayName;
                    AbilityDataDetailTextBox.Text = RessourcesManager.selectedAbility.Value.Detail;

                    AbiCheckAlwaysDisable.Checked = RessourcesManager.selectedAbility.Value.AlwaysDisable;
                    AbiCheckDependWeapon.Checked = RessourcesManager.selectedAbility.Value.DependWeapon;
                    AbiCheckExceptEnforcer.Checked = RessourcesManager.selectedAbility.Value.ExceptEnforcer;
                    AbiCheckKeepBoostEffect.Checked = RessourcesManager.selectedAbility.Value.KeepBoostEffect;
                    AbiCheckEnableItemAll.Checked = RessourcesManager.selectedAbility.Value.EnableItemAll;
                    AbiCheckEnableSkillAll.Checked = RessourcesManager.selectedAbility.Value.EnableSkillAll;
                    AbiCheckEnableConvergence.Checked = RessourcesManager.selectedAbility.Value.EnableConvergence;
                    AbiCheckEnableDiffusion.Checked = RessourcesManager.selectedAbility.Value.EnableDiffusion;
                    AbiCheckEnableReflection.Checked = RessourcesManager.selectedAbility.Value.EnableReflection;
                    AbiCheckEnableCounter.Checked = RessourcesManager.selectedAbility.Value.EnableCounter;
                    AbiCheckEnableHideOut.Checked = RessourcesManager.selectedAbility.Value.EnableHideOut;
                    AbiCheckEnableRepeat.Checked = RessourcesManager.selectedAbility.Value.EnableRepeat;
                    AbiCheckEnableCover.Checked = RessourcesManager.selectedAbility.Value.EnableCover;
                    AbiCheckEnableProvoke.Checked = RessourcesManager.selectedAbility.Value.EnableProvoke;
                    AbiCheckEnableDisableMagic.Checked = RessourcesManager.selectedAbility.Value.EnableDisableMagic;
                    AbiCheckEnableEnchant.Checked = RessourcesManager.selectedAbility.Value.EnableEnchant;
                    AbiCheckEnableChaseAttack.Checked = RessourcesManager.selectedAbility.Value.EnableChaseAttack;
                    AbiCheckEnableWeakCheckAll.Checked = RessourcesManager.selectedAbility.Value.EnableWeakCheckAll;
                    AbiCheckEnableNormalAttackAll.Checked = RessourcesManager.selectedAbility.Value.EnableNormalAttackAll;
                    AbiCheckEnableSession.Checked = RessourcesManager.selectedAbility.Value.EnableSession;
                    AbiCheckEnableBusinessSupport.Checked = RessourcesManager.selectedAbility.Value.EnableBusinessSupport;
                    AbiCheckEnableForceWeakness.Checked = RessourcesManager.selectedAbility.Value.EnableForceWeakness;
                    AbiCheckEnableNoUseMaterial.Checked = RessourcesManager.selectedAbility.Value.EnableNoUseMaterial;
                    AbiCheckEnableSwitchWeapon.Checked = RessourcesManager.selectedAbility.Value.EnableSwitchWeapon;
                    AbiCheckEnableCompensationMagic.Checked = RessourcesManager.selectedAbility.Value.EnableCompensationMagic;
                    AbiCheckEnableExcitement.Checked = RessourcesManager.selectedAbility.Value.EnableExcitement;
                    AbiCheckSongAbilityFlag.Checked = RessourcesManager.selectedAbility.Value.SongAbilityFlag;
                    AbiCheckDanceAbilityFlag.Checked = RessourcesManager.selectedAbility.Value.DanceAbilityFlag;
                    AbiCheckEnableAutoTameMonster.Checked = RessourcesManager.selectedAbility.Value.EnableAutoTameMonster;
                    AbiCheckUseAbilityCamera.Checked = RessourcesManager.selectedAbility.Value.UseAbilityCamera;

                    AbilityDataEnumBox1.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.AbilityType;
                    AbilityDataEnumBox2.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.Attribute;
                    AbilityDataEnumBox3.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.RestrictWeapon;
                    AbilityDataEnumBox4.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.TargetType;
                    AbilityDataEnumBox5.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.CostType;
                    AbilityDataEnumBox6.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.EstimateOrderType;

                    AbilityAilmentListBox.Items.Clear();
                    foreach (var ailment in RessourcesManager.selectedAbility.Value.AilmentsList)
                    {
                        AbilityAilmentListBox.Items.Add(ailment.Name);
                    }
                    AbilityAilmentListBox.SelectedIndex = 0;
                    if (AbilityAilmentListBox.Items.Count <= 1)
                        AbilityAilmentButtonRemove.Enabled = false;
                    AbiDatAilmentNameComboBox.Text = RessourcesManager.selectedAbility.Value.AilmentsList[0].Name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured! {ex.Message}");
                }
            }
        }

        private void AbilityAilmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedAbility is null)
                return;

            AbiDatAilmentNameComboBox.Text = RessourcesManager.selectedAbility.Value.AilmentsList[AbilityAilmentListBox.SelectedIndex].Name;
            AbiInvValTextBox.Text = RessourcesManager.selectedAbility.Value.AilmentsList[AbilityAilmentListBox.SelectedIndex].InvocationValue.ToString();
            AbiInvTurTextBox.Text = RessourcesManager.selectedAbility.Value.AilmentsList[AbilityAilmentListBox.SelectedIndex].InvocationTurn.ToString();
            AbiDisRatTextBox.Text = RessourcesManager.selectedAbility.Value.AilmentsList[AbilityAilmentListBox.SelectedIndex].DiseaseRate.ToString();

            if (AbilityAilmentListBox.SelectedIndex == 0)
                AbilityAilmentButtonRemove.Enabled = false;
            else
                AbilityAilmentButtonRemove.Enabled = true;
        }

        private void AbilityAilmentButtonAdd_Click(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedAbility is null)
                return;

            var index = AbilityAilmentListBox.SelectedIndex;
            RessourcesManager.selectedAbility.Value.AilmentsList.Add(RessourcesManager.selectedAbility.Value.AilmentsList[index]);
            AbilityAilmentListBox.Items.Add(RessourcesManager.selectedAbility.Value.AilmentsList[index].Name);
            AbilityAilmentListBox.SelectedIndex = AbilityAilmentListBox.Items.Count - 1;

            AbilityAilmentButtonRemove.Enabled = true;
        }

        private void AbilityAilmentButtonRemove_Click(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedAbility is null)
                return;

            var index = AbilityAilmentListBox.SelectedIndex;
            RessourcesManager.selectedAbility.Value.AilmentsList.RemoveAt(index);
            AbilityAilmentListBox.SelectedIndex = 0;
            AbilityAilmentListBox.Items.RemoveAt(index);

            if (AbilityAilmentListBox.Items.Count <= 1)
                AbilityAilmentButtonRemove.Enabled = false;
        }

        private void AbilityDataAilmentUpdateButton_Click(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedAbility is null)
                return;

            var index = AbilityAilmentListBox.SelectedIndex;

            try
            {
                Ailment newAilment = new Ailment();
                newAilment.Name = AbiDatAilmentNameComboBox.Text;
                newAilment.InvocationValue = int.Parse(AbiInvValTextBox.Text);
                newAilment.InvocationTurn = int.Parse(AbiInvTurTextBox.Text);
                newAilment.DiseaseRate = int.Parse(AbiDisRatTextBox.Text);
                RessourcesManager.selectedAbility.Value.AilmentsList[index] = newAilment;

                AbilityAilmentListBox.Items.Clear();
                foreach (var ailment in RessourcesManager.selectedAbility.Value.AilmentsList)
                {
                    AbilityAilmentListBox.Items.Add(ailment.Name);
                }
                AbilityAilmentListBox.SelectedIndex = index;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }

        #endregion AbilityData
    }
}
