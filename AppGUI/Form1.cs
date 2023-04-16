using UAssetAPP.OT2.DataBases.AbilityData;

namespace AppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SaveButton.Enabled = false;
            SaveAsButton.Enabled = false;
            CloseButton.Enabled = false;
            UpdateLabel.Text = string.Empty;
            ManageElementsVisibility();
        }

        private void ManageElementsVisibility()
        {
            switch (RessourcesManager.databaseType)
            {
                case RessourcesManager.DatabaseType.AbilityData:
                    ItemNameDB.Enabled = true;
                    AbilityDataPannel.Visible = true;
                    SelectedItemLabel.Text = "Selected Ability";
                    LoadedDatabaseLabel.Text = "AbilityData";
                    AbilityDataEnumBox1.Items.Clear();
                    UpdateItemButton.Enabled = true;
                    UpdateItemButton.Text = "Update ability";
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
                    break;
                default:
                    ItemNameDB.Items.Clear();
                    ItemNameDB.Text = string.Empty;
                    ItemNameDB.Enabled = false;
                    AbilityDataPannel.Visible = false;
                    SelectedItemLabel.Text = "Selected Item";
                    LoadedDatabaseLabel.Text = string.Empty;
                    UpdateItemButton.Enabled = false;
                    UpdateItemButton.Text = "Update item";
                    break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Unreal UAssets (AbilityData.uasset)|AbilityData.uasset|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        RessourcesManager.LoadFile(openFileDialog.FileName);
                        ManageElementsVisibility();
                        ItemNameDB.Items.Clear();
                        ItemNameDB.Items.AddRange(RessourcesManager.itemListDB?.ToArray());
                        ItemNameDB.SelectedIndex = 0;
                        SaveButton.Enabled = true;
                        SaveAsButton.Enabled = true;
                        CloseButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Exception occured: {ex.Message}");
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RessourcesManager.SaveFile();
                MessageBox.Show("File saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured: {ex.Message}");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        RessourcesManager.SaveFileTo(openFileDialog.FileName);
                        MessageBox.Show("File saved!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Exception occured: {ex.Message}");
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RessourcesManager.CloseFile();
            ItemNameDB.Items.Clear();
            SaveButton.Enabled = false;
            SaveAsButton.Enabled = false;
            CloseButton.Enabled = false;
            ManageElementsVisibility();
        }

        private void ItemNameDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RessourcesManager.UpdateSelectedItem(ItemNameDB.SelectedIndex);
            switch (RessourcesManager.databaseType)
            {
                case RessourcesManager.DatabaseType.AbilityData:
                    if (RessourcesManager.selectedAbility is not null)
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
                        AbilityAilmentListBox.Items.Clear();
                        foreach (var ailment in RessourcesManager.selectedAbility.Value.AilmentsList)
                        {
                            AbilityAilmentListBox.Items.Add(ailment.Name);
                        }
                        AbilityAilmentListBox.SelectedIndex = 0;
                        if (AbilityAilmentListBox.Items.Count <= 1)
                            AbilityAilmentButtonRemove.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            UpdateLabel.Text = "Updating data, please wait...";
            UpdateItemButton.Enabled = false;

            switch (RessourcesManager.databaseType)
            {
                case RessourcesManager.DatabaseType.AbilityData:
                    UpdateAbilityData();
                    break;
                default:
                    break;
            }
            RessourcesManager.UpdateItem();

            UpdateItemButton.Enabled = true;
            UpdateLabel.Text = string.Empty;
        }

        private void UpdateAbilityData()
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

                RessourcesManager.selectedAbility = newAbility;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }

        private void AbilityAilmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedAbility is null)
                return;

            AbiNameTextBox.Text = RessourcesManager.selectedAbility.Value.AilmentsList[AbilityAilmentListBox.SelectedIndex].Name;
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
                newAilment.Name = AbiNameTextBox.Text;
                newAilment.InvocationValue = int.Parse(AbiInvValTextBox.Text);
                newAilment.InvocationTurn = int.Parse(AbiInvTurTextBox.Text);
                newAilment.DiseaseRate = int.Parse(AbiDisRatTextBox.Text);
                RessourcesManager.selectedAbility.Value.AilmentsList[index] = newAilment;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }
    }
}