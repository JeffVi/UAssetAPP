using UAssetAPP.OT2.DataBases.AbilityData;
using UAssetAPP.OT2.DataBases.EnemyDB;
using UAssetAPP.OT2.DataBases.GameText;
using UAssetAPP.OT2.DataBases.JobData;

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
            // see https://aka.ms/applicationconfiguration.ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}