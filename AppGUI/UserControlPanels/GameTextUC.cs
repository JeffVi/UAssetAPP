using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGUI.UserControlPanels
{
    public partial class GameTextUC : UserControl, IUserControlDB
    {
        public GameTextUC()
        {
            InitializeComponent();
        }

        public void InitItems()
        {

        }

        public void UpdateItemData()
        {
            if ((RessourcesManager.selectedGameText is null) || (RessourcesManager.selectedGameText.Value.name is null) || (RessourcesManager.selectedGameText.Value.text is null))
                return;

            try
            {
                (string name, string text) = (RessourcesManager.selectedGameText.Value.name, GameTextRichBox.Text);
                RessourcesManager.selectedGameText = (name, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }

        public void ItemNameDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((RessourcesManager.selectedGameText is not null) && (RessourcesManager.selectedGameText.Value.text is not null))
            {
                try
                {
                    GameTextRichBox.Text = RessourcesManager.selectedGameText.Value.text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured! {ex.Message}");
                }
            }
        }
    }
}
