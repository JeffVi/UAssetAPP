using System.Windows.Forms;
using UAssetAPP.OT2.DataBases.AbilityData;

namespace AppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ManageElementsVisibility()
        {
            switch (RessourcesManager.databaseType)
            {
                case RessourcesManager.DatabaseType.AbilityData:
                    AbilityDataPannel.Visible = true;
                    AbilityDataEnumBox1.Items.Clear();
                    AbilityDataEnumBox1.Items.AddRange(Enum.GetNames(typeof(AbilityTypeEnum)));
                    AbilityDataEnumBox2.Items.Clear();
                    AbilityDataEnumBox2.Items.AddRange(Enum.GetNames(typeof(AttributeEnum)));
                    AbilityDataEnumBox3.Items.Clear();
                    AbilityDataEnumBox3.Items.AddRange(Enum.GetNames(typeof(RestrictWeaponEnum)));
                    AbilityDataEnumBox4.Items.Clear();
                    AbilityDataEnumBox4.Items.AddRange(Enum.GetNames(typeof(TargetTypeEnum)));
                    AbilityDataEnumBox5.Items.Clear();
                    AbilityDataEnumBox5.Items.AddRange(Enum.GetNames(typeof(CostTypeEnum)));
                    break;
                default:
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

                    AbilityDataEnumBox1.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.AbilityType;
                    AbilityDataEnumBox2.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.Attribute;
                    AbilityDataEnumBox3.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.RestrictWeapon;
                    AbilityDataEnumBox4.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.TargetType;
                    AbilityDataEnumBox5.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.CostType;
                    break;
                default:
                    break;
            }
        }
    }
}