using UAssetAPP.OT2.DataBases.AbilityData;

namespace AppGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            /*
            const string assetsPath = "C:\\Users\\JeffV\\source\\Repos\\UAssetAPP\\AppGUI\\TestAssets";
            string[] assetsFiles = Directory.GetFiles(assetsPath, "*.uasset");
            var abilityData = new AbilityData(assetsFiles.First(x => x.Contains("AbilityData")));
            var ability3 = abilityData.GetAbility(3);
            ability3.AbilityType = AbilityTypeEnum.MAGIC;
            ability3.TargetType = TargetTypeEnum.ENEMY_ALL;
            ability3.AilmentsList = new List<Ailment>()
            {
                new Ailment(){Name = "test1", InvocationValue = 101, InvocationTurn = 102, DiseaseRate = 103},
                new Ailment(){Name = "test2", InvocationValue = 201, InvocationTurn = 202, DiseaseRate = 203},
                new Ailment(){Name = "test3", InvocationValue = 301, InvocationTurn = 302, DiseaseRate = 303},
                new Ailment(){Name = "test4", InvocationValue = 401, InvocationTurn = 402, DiseaseRate = 403},
            };
            abilityData.SetAbility(ability3);
            abilityData.SaveTo("C:\\Users\\JeffV\\source\\Repos\\UAssetAPP\\AppGUI\\TestAssets\\Output.uasset");
            */
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}