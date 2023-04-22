using UAssetAPP.OT2.DataBases.AbilityData;
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
            /*
            var jobdata = new JobData(@"C:\Users\JeffV\source\Repos\UAssetAPP\AppGUI\TestAssets\JobData.uasset");

            var job = jobdata.GetJob("eDANCER");
            var cmdL = job.JobCommandAbility[1];
            cmdL.Name = "Test1";
            cmdL.Param = JobCommandAbilityParamEnum.LockedDivine_UnlockLast;
            job.JobCommandAbility[1] = cmdL;
            var spA = job.JobSupportAbility[1];
            spA.Name = "Test2";
            spA.NumberOfLearnedAbilitiesToUnlock = 1;
            job.JobSupportAbility[1] = spA;
            job.JPCost = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            job.ParameterRevision = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130 };
            job.ProperEquipment = new List<bool> { true, false, true, false, true, false, true, false, true, false, true, false, true, false };
            jobdata.SetJob(job);
            jobdata.SaveTo(@"C:\Users\JeffV\source\Repos\UAssetAPP\AppGUI\TestAssets\Output.uasset");
            */
            Application.Run(new MainForm());
        }
    }
}