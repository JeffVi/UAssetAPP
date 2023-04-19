using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAssetAPP.OT2.DataBases.AbilityData;

namespace AppGUI
{
    public static class RessourcesManager
    {
        public static string? filePath = null;

        public static DatabaseType? databaseType = null;

        private static AbilityData? abilityData = null;
        public static Ability? selectedAbility = null;
        public static List<string>? ailmentNamesList = null;

        public static List<string>? itemListDB;
        
        public static void LoadFile(string filename)
        {
            switch (Path.GetFileNameWithoutExtension(filename))
            {
                case "AbilityData":
                    abilityData = new AbilityData(filename);
                    itemListDB = abilityData.dbItemNames;
                    databaseType = DatabaseType.AbilityData;
                    filePath = filename;
                    ailmentNamesList = abilityData.GetAllAilmentNames();
                    break;
                default:
                    CloseFile();
                    break;
            }
        }

        public static void SaveFile()
        {
            switch (databaseType)
            {
                case DatabaseType.AbilityData:
                    abilityData?.Save();
                    break;
                default:
                    break;
            }
        }

        public static void SaveFileTo(string filename)
        {
            switch (databaseType)
            {
                case DatabaseType.AbilityData:
                    abilityData?.SaveTo(filename);
                    break;
                default:
                    break;
            }
        }

        public static void CloseFile()
        {
            databaseType = null;
            filePath = null;

            abilityData = null;
            selectedAbility = null;
            ailmentNamesList?.Clear();
        }

        public static void UpdateSelectedItem(int index)
        {
            switch (databaseType)
            {
                case DatabaseType.AbilityData:
                    selectedAbility = abilityData?.GetAbility(index);
                    break;
                default:
                    break;
            }
        }

        public static void UpdateItem()
        {
            switch (databaseType)
            {
                case DatabaseType.AbilityData:
                    if (selectedAbility is not null)
                        abilityData?.SetAbility(selectedAbility.Value);
                    break;
                default:
                    break;
            }
        }

        public enum DatabaseType
        {
            AbilityData,
        }
    }
}
