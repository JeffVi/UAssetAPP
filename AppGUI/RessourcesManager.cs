using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAssetAPP.OT2.DataBases.AbilityData;
using UAssetAPP.OT2.DataBases.GameText;

namespace AppGUI
{
    public static class RessourcesManager
    {
        public static string? filePath = null;

        public static DatabaseType? databaseType = null;

        private static AbilityData? abilityData = null;
        public static Ability? selectedAbility = null;
        public static List<string>? ailmentNamesList = null;

        private static GameText? gameText = null;
        public static (string? name, string? text)? selectedGameText = null;

        public static List<string>? itemListDB;
        
        public static void LoadFile(string filename)
        {
            CloseFile();

            switch (Path.GetFileNameWithoutExtension(filename))
            {
                case "AbilityData":
                    abilityData = new AbilityData(filename);
                    itemListDB = abilityData.dbItemNames;
                    databaseType = DatabaseType.AbilityData;
                    filePath = filename;
                    ailmentNamesList = abilityData.GetAllAilmentNames();
                    break;

                case "GameTextDE":
                case "GameTextEN":
                case "GameTextES":
                case "GameTextFR":
                case "GameTextIT":
                case "GameTextJA":
                case "GameTextKR":
                case "GameTextZH_CN":
                case "GameTextZH_TW":
                    gameText = new GameText(filename);
                    itemListDB = new List<string>();
                    foreach (var item in gameText.dbItemNames)
                    {
                        // Only add non null values
                        if (!string.IsNullOrEmpty(gameText.GetText(item)))
                            itemListDB.Add(item);
                    }
                    databaseType = DatabaseType.GameText;
                    filePath = filename;
                    break;

                default:
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
                case DatabaseType.GameText:
                    gameText?.Save();
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
                case DatabaseType.GameText:
                    gameText?.SaveTo(filename);
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

            gameText = null;
            selectedGameText = null;
        }

        public static void UpdateSelectedItem(int index)
        {
            switch (databaseType)
            {
                case DatabaseType.AbilityData:
                    selectedAbility = abilityData?.GetAbility(index);
                    break;
                case DatabaseType.GameText:
                    selectedGameText = (itemListDB?[index], gameText?.GetText(itemListDB?[index]));
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
                case DatabaseType.GameText:
                    if ((selectedGameText is not null) && (selectedGameText.Value.name is not null) && (selectedGameText.Value.text is not null))
                        gameText?.SetText(selectedGameText.Value.name, selectedGameText.Value.text);
                    break;
                default:
                    break;
            }
        }

        public enum DatabaseType
        {
            AbilityData,
            GameText,
        }
    }
}
