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
                    if (RessourcesManager.selectedAbility is not null)
                    {
                        AbilityDataEnumBox1.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.AbilityType;
                        AbilityDataEnumBox2.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.Attribute;
                        AbilityDataEnumBox3.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.RestrictWeapon;
                        AbilityDataEnumBox4.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.TargetType;
                        AbilityDataEnumBox5.SelectedIndex = (int)RessourcesManager.selectedAbility.Value.CostType;
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

            Ability newAbility = RessourcesManager.selectedAbility.Value;

            newAbility.AbilityType = (AbilityTypeEnum)AbilityDataEnumBox1.SelectedIndex;
            newAbility.Attribute = (AttributeEnum)AbilityDataEnumBox2.SelectedIndex;
            newAbility.RestrictWeapon = (RestrictWeaponEnum)AbilityDataEnumBox3.SelectedIndex;
            newAbility.TargetType = (TargetTypeEnum)AbilityDataEnumBox4.SelectedIndex;
            newAbility.CostType = (CostTypeEnum)AbilityDataEnumBox5.SelectedIndex;
        }
    }
}