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
            UCAbilityData.Visible = false;
            UCGameText.Visible = false;
            ManageElementsVisibility();
        }

        private void ManageElementsVisibility()
        {
            switch (RessourcesManager.databaseType)
            {
                case RessourcesManager.DatabaseType.AbilityData:
                    UCAbilityData.Visible = true;
                    UCGameText.Visible = false;
                    UCJobData.Visible = false;

                    ItemNameDB.Enabled = true;
                    SelectedItemLabel.Text = "Selected Ability";
                    LoadedDatabaseLabel.Text = RessourcesManager.filePath;
                    UpdateItemButton.Enabled = true;
                    UpdateItemButton.Text = "Update ability";

                    UCAbilityData.InitItems();
                    break;

                case RessourcesManager.DatabaseType.GameText:
                    UCAbilityData.Visible = false;
                    UCGameText.Visible = true;
                    UCJobData.Visible = false;

                    ItemNameDB.Enabled = true;
                    SelectedItemLabel.Text = "Selected Text";
                    LoadedDatabaseLabel.Text = RessourcesManager.filePath;
                    UpdateItemButton.Enabled = true;
                    UpdateItemButton.Text = "Update text";

                    UCGameText.InitItems();
                    break;

                case RessourcesManager.DatabaseType.JobData:
                    UCAbilityData.Visible = false;
                    UCGameText.Visible = false;
                    UCJobData.Visible = true;

                    ItemNameDB.Enabled = true;
                    SelectedItemLabel.Text = "Selected Job";
                    LoadedDatabaseLabel.Text = RessourcesManager.filePath;
                    UpdateItemButton.Enabled = true;
                    UpdateItemButton.Text = "Update job";

                    UCJobData.InitItems();
                    break;

                default:
                    UCAbilityData.Visible = false;
                    UCGameText.Visible = false;
                    UCJobData.Visible = false;

                    ItemNameDB.Items.Clear();
                    ItemNameDB.Text = string.Empty;
                    ItemNameDB.Enabled = false;
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
                openFileDialog.Filter = "Unreal UAssets (AbilityData;GameText;JobData)|AbilityData.uasset;GameText*.uasset;JobData.uasset|All files (*.*)|*.*";
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
                    UCAbilityData.ItemNameDB_SelectedIndexChanged(sender, e);
                    break;

                case RessourcesManager.DatabaseType.GameText:
                    UCGameText.ItemNameDB_SelectedIndexChanged(sender, e);
                    break;

                case RessourcesManager.DatabaseType.JobData:
                    UCJobData.ItemNameDB_SelectedIndexChanged(sender, e);
                    break;

                default:
                    break;
            }
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            // Label will work in task, not the current priority, TODO
            UpdateLabel.Text = "Updating data, please wait...";
            UpdateItemButton.Enabled = false;

            switch (RessourcesManager.databaseType)
            {
                case RessourcesManager.DatabaseType.AbilityData:
                    UCAbilityData.UpdateItemData();
                    break;

                case RessourcesManager.DatabaseType.GameText:
                    UCGameText.UpdateItemData();
                    break;

                case RessourcesManager .DatabaseType.JobData:
                    UCJobData.UpdateItemData();
                    break;

                default:
                    break;
            }
            RessourcesManager.UpdateItem();

            UpdateItemButton.Enabled = true;
            UpdateLabel.Text = string.Empty;
        }
    }
}