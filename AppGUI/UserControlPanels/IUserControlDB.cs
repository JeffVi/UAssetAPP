using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGUI.UserControlPanels
{
    public interface IUserControlDB
    {
        void InitItems();

        void UpdateItemData();

        void ItemNameDB_SelectedIndexChanged(object sender, EventArgs e);
    }
}
