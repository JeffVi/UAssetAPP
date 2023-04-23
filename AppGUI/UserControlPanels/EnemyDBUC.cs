using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAssetAPP.OT2.DataBases.EnemyDB;

namespace AppGUI.UserControlPanels
{
    public partial class EnemyDBUC : UserControl, IUserControlDB
    {
        public EnemyDBUC()
        {
            InitializeComponent();
        }

        public void InitItems()
        {
            comboBoxSword.Items.Clear();
            comboBoxSpear.Items.Clear();
            comboBoxDagger.Items.Clear();
            comboBoxAxe.Items.Clear();
            comboBoxBow.Items.Clear();
            comboBoxStaff.Items.Clear();
            comboBoxUNKNOWN_W1.Items.Clear();
            comboBoxUNKNOWN_W2.Items.Clear();
            comboBoxFire.Items.Clear();
            comboBoxIce.Items.Clear();
            comboBoxLightning.Items.Clear();
            comboBoxWind.Items.Clear();
            comboBoxLight.Items.Clear();
            comboBoxDark.Items.Clear();
            comboBoxPoison.Items.Clear();
            comboBoxSilence.Items.Clear();
            comboBoxBlindness.Items.Clear();
            comboBoxConfusion.Items.Clear();
            comboBoxSleep.Items.Clear();
            comboBoxTerror.Items.Clear();
            comboBoxUnconsciousness.Items.Clear();
            comboBoxInstantDeath.Items.Clear();
            comboBoxPetrification.Items.Clear();
            comboBoxUNKNOWN_D1.Items.Clear();
            comboBoxUNKNOWN_D2.Items.Clear();
            comboBoxUNKNOWN_D3.Items.Clear();

            comboBoxSword.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxSpear.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxDagger.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxAxe.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxBow.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxStaff.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxUNKNOWN_W1.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxUNKNOWN_W2.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxFire.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxIce.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxLightning.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxWind.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxLight.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxDark.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxPoison.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxSilence.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxBlindness.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxConfusion.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxSleep.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxTerror.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxUnconsciousness.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxInstantDeath.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxPetrification.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxUNKNOWN_D1.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxUNKNOWN_D2.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
            comboBoxUNKNOWN_D3.Items.AddRange(Enum.GetNames(typeof(AttributeResistEnum)));
        }

        public void UpdateItemData()
        {
            if (RessourcesManager.selectedEnemy is null)
                return;

            try
            {
                Enemy newEnemy = RessourcesManager.selectedEnemy.Value;

                newEnemy.DamageRatio = float.Parse(textBoxDamageRatio.Text.Replace(',','.'));
                newEnemy.DisplayRank = int.Parse(textBoxDisplayRank.Text);
                newEnemy.EnemyLevel = int.Parse(textBoxEnemyLevel.Text);
                newEnemy.Exp = int.Parse(textBoxExp.Text);
                newEnemy.JobPoint = int.Parse(textBoxJobPoint.Text);
                newEnemy.Money = int.Parse(textBoxMoney.Text);
                newEnemy.StealMoney = int.Parse(textBoxStealMoney.Text);
                newEnemy.DropProbability = int.Parse(textBoxDropProbability.Text);
                newEnemy.BribeMoney = int.Parse(textBoxBribeMoney.Text);
                newEnemy.RevealShieldPoint = int.Parse(textBoxRevealShieldPoint.Text);
                newEnemy.Param = new List<int>
                {
                    int.Parse(textBoxHP.Text),
                    int.Parse(textBoxMP.Text),
                    int.Parse(textBoxBP.Text),
                    int.Parse(textBoxSP.Text),
                    int.Parse(textBoxPOT.Text),
                    int.Parse(textBoxATK.Text),
                    int.Parse(textBoxDEF.Text),
                    int.Parse(textBoxMATK.Text),
                    int.Parse(textBoxMDEF.Text),
                    int.Parse(textBoxACC.Text),
                    int.Parse(textBoxEVA.Text),
                    int.Parse(textBoxCON.Text),
                    int.Parse(textBoxAGI.Text),
                };
                newEnemy.DeadEffectSlow = checkBoxDeadEffectSlow.Checked;
                newEnemy.MainEnemy = checkBoxMainEnemy.Checked;
                newEnemy.NonPartBattle = checkBoxNonPartBattle.Checked;
                newEnemy.UseCatDamageType = checkBoxUseCatDamageType.Checked;
                newEnemy.DisableDeadKnockBack = checkBoxDisableDeadKnockBack.Checked;
                newEnemy.HaveItemID = textBoxHaveItemID.Text;
                newEnemy.StealItemID = textBoxStealItemID.Text;
                newEnemy.WeaponResist = new List<AttributeResistEnum>
                {
                    (AttributeResistEnum)comboBoxSword.SelectedIndex,
                    (AttributeResistEnum)comboBoxSpear.SelectedIndex,
                    (AttributeResistEnum)comboBoxDagger.SelectedIndex,
                    (AttributeResistEnum)comboBoxAxe.SelectedIndex,
                    (AttributeResistEnum)comboBoxBow.SelectedIndex,
                    (AttributeResistEnum)comboBoxStaff.SelectedIndex,
                    (AttributeResistEnum)comboBoxUNKNOWN_D1.SelectedIndex,
                };
                newEnemy.AttributeResist = new List<AttributeResistEnum>
                {
                    (AttributeResistEnum)comboBoxUNKNOWN_D2.SelectedIndex,
                    (AttributeResistEnum)comboBoxFire.SelectedIndex,
                    (AttributeResistEnum)comboBoxIce.SelectedIndex,
                    (AttributeResistEnum)comboBoxLightning.SelectedIndex,
                    (AttributeResistEnum)comboBoxWind.SelectedIndex,
                    (AttributeResistEnum)comboBoxLight.SelectedIndex,
                    (AttributeResistEnum)comboBoxDark.SelectedIndex,
                };
                newEnemy.DiseaseResist = new List<AttributeResistEnum>
                {
                    (AttributeResistEnum)comboBoxPoison.SelectedIndex,
                    (AttributeResistEnum)comboBoxSilence.SelectedIndex,
                    (AttributeResistEnum)comboBoxBlindness.SelectedIndex,
                    (AttributeResistEnum)comboBoxConfusion.SelectedIndex,
                    (AttributeResistEnum)comboBoxSleep.SelectedIndex,
                    (AttributeResistEnum)comboBoxTerror.SelectedIndex,
                    (AttributeResistEnum)comboBoxUnconsciousness.SelectedIndex,
                    (AttributeResistEnum)comboBoxInstantDeath.SelectedIndex,
                    (AttributeResistEnum)comboBoxPetrification.SelectedIndex,
                    (AttributeResistEnum)comboBoxUNKNOWN_D1.SelectedIndex,
                    (AttributeResistEnum)comboBoxUNKNOWN_D2.SelectedIndex,
                    (AttributeResistEnum)comboBoxUNKNOWN_D3.SelectedIndex,
                };

                RessourcesManager.selectedEnemy = newEnemy;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }

        public void ItemNameDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedEnemy is not null)
            {
                try
                {
                    textBoxDamageRatio.Text = RessourcesManager.selectedEnemy.Value.DamageRatio.ToString();
                    textBoxDisplayRank.Text = RessourcesManager.selectedEnemy.Value.DisplayRank.ToString();
                    textBoxEnemyLevel.Text = RessourcesManager.selectedEnemy.Value.EnemyLevel.ToString();
                    textBoxExp.Text = RessourcesManager.selectedEnemy.Value.Exp.ToString();
                    textBoxJobPoint.Text = RessourcesManager.selectedEnemy.Value.JobPoint.ToString();
                    textBoxMoney.Text = RessourcesManager.selectedEnemy.Value.Money.ToString();
                    textBoxStealMoney.Text = RessourcesManager.selectedEnemy.Value.StealMoney.ToString();
                    textBoxDropProbability.Text = RessourcesManager.selectedEnemy.Value.DropProbability.ToString();
                    textBoxBribeMoney.Text = RessourcesManager.selectedEnemy.Value.BribeMoney.ToString();
                    textBoxRevealShieldPoint.Text = RessourcesManager.selectedEnemy.Value.RevealShieldPoint.ToString();
                    textBoxHP.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.HP].ToString();
                    textBoxMP.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.MP].ToString();
                    textBoxBP.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.BP].ToString();
                    textBoxSP.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.SP].ToString();
                    textBoxPOT.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.POT].ToString();
                    textBoxATK.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.ATK].ToString();
                    textBoxDEF.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.DEF].ToString();
                    textBoxMATK.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.MATK].ToString();
                    textBoxMDEF.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.MDEF].ToString();
                    textBoxACC.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.ACC].ToString();
                    textBoxEVA.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.EVA].ToString();
                    textBoxCON.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.CON].ToString();
                    textBoxAGI.Text = RessourcesManager.selectedEnemy.Value.Param[(int)EnemyParamEnum.AGI].ToString();
                    checkBoxDeadEffectSlow.Checked = RessourcesManager.selectedEnemy.Value.DeadEffectSlow;
                    checkBoxMainEnemy.Checked = RessourcesManager.selectedEnemy.Value.MainEnemy;
                    checkBoxNonPartBattle.Checked = RessourcesManager.selectedEnemy.Value.NonPartBattle;
                    checkBoxUseCatDamageType.Checked = RessourcesManager.selectedEnemy.Value.UseCatDamageType;
                    checkBoxDisableDeadKnockBack.Checked = RessourcesManager.selectedEnemy.Value.DisableDeadKnockBack;
                    textBoxHaveItemID.Text = RessourcesManager.selectedEnemy.Value.HaveItemID;
                    textBoxStealItemID.Text = RessourcesManager.selectedEnemy.Value.StealItemID;
                    comboBoxSword.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.Sword];
                    comboBoxSpear.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.Spear];
                    comboBoxDagger.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.Dagger];
                    comboBoxAxe.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.Axe];
                    comboBoxBow.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.Bow];
                    comboBoxStaff.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.Staff];
                    comboBoxUNKNOWN_W1.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.WeaponResist[(int)EnemyWeaponResistEnum.UNKNOWN];
                    comboBoxUNKNOWN_W2.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.UNKNOWN];
                    comboBoxFire.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.Fire];
                    comboBoxIce.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.Ice];
                    comboBoxLightning.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.Lightning];
                    comboBoxWind.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.Wind];
                    comboBoxLight.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.Light];
                    comboBoxDark.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.AttributeResist[(int)EnemyAttributeResistEnum.Dark];
                    comboBoxPoison.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Poison];
                    comboBoxSilence.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Silence];
                    comboBoxBlindness.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Blindness];
                    comboBoxConfusion.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Confusion];
                    comboBoxSleep.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Sleep];
                    comboBoxTerror.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Terror];
                    comboBoxUnconsciousness.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Unconsciousness];
                    comboBoxInstantDeath.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.InstantDeath];
                    comboBoxPetrification.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.Petrification];
                    comboBoxUNKNOWN_D1.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.UNKNOWN_1];
                    comboBoxUNKNOWN_D2.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.UNKNOWN_2];
                    comboBoxUNKNOWN_D3.SelectedIndex = (int)RessourcesManager.selectedEnemy.Value.DiseaseResist[(int)EnemyDiseaseResistEnum.UNKNOWN_3];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured! {ex.Message}");
                }
            }
        }
    }
}
