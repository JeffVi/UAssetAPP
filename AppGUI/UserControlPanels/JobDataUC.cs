using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAssetAPP.OT2.DataBases.JobData;

namespace AppGUI.UserControlPanels
{
    public partial class JobDataUC : UserControl, IUserControlDB
    {
        public JobDataUC()
        {
            InitializeComponent();
        }

        public void InitItems()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox2.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox3.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox4.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox5.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox6.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox7.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
            comboBox8.Items.AddRange(Enum.GetNames(typeof(JobCommandAbilityParamEnum)));
        }

        public void UpdateItemData()
        {
            if (RessourcesManager.selectedJob is null)
                return;

            try
            {
                Job newJob = RessourcesManager.selectedJob.Value;
                newJob.ParameterRevision = new List<int>
                {
                    int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text),
                    int.Parse(textBox5.Text),
                    int.Parse(textBox6.Text),
                    int.Parse(textBox7.Text),
                    int.Parse(textBox8.Text),
                    int.Parse(textBox9.Text),
                    int.Parse(textBox10.Text),
                    int.Parse(textBox11.Text),
                    int.Parse(textBox12.Text),
                    int.Parse(textBox13.Text),

                };
                newJob.ProperEquipment = new List<bool>
                {
                    JobDataAqCheckBox1.Checked,
                    JobDataAqCheckBox2.Checked,
                    JobDataAqCheckBox3.Checked,
                    JobDataAqCheckBox4.Checked,
                    JobDataAqCheckBox5.Checked,
                    JobDataAqCheckBox6.Checked,
                    JobDataAqCheckBox7.Checked,
                    JobDataAqCheckBox8.Checked,
                    JobDataAqCheckBox9.Checked,
                    JobDataAqCheckBox10.Checked,
                    JobDataAqCheckBox11.Checked,
                    JobDataAqCheckBox12.Checked,
                    JobDataAqCheckBox13.Checked,
                    JobDataAqCheckBox14.Checked,
                };
                newJob.JPCost = new List<int>
                {
                    int.Parse(textBox37.Text),
                    int.Parse(textBox36.Text),
                    int.Parse(textBox35.Text),
                    int.Parse(textBox34.Text),
                    int.Parse(textBox33.Text),
                    int.Parse(textBox32.Text),
                    int.Parse(textBox31.Text),
                    int.Parse(textBox30.Text),
                };

                List<JobCommandAbility> jobCommandAbilities = new List<JobCommandAbility>()
                {
                    new JobCommandAbility() { Name = textBox14.Text, Param = (JobCommandAbilityParamEnum)comboBox1.SelectedIndex },
                    new JobCommandAbility() { Name = textBox15.Text, Param = (JobCommandAbilityParamEnum)comboBox2.SelectedIndex },
                    new JobCommandAbility() { Name = textBox16.Text, Param = (JobCommandAbilityParamEnum)comboBox3.SelectedIndex },
                    new JobCommandAbility() { Name = textBox17.Text, Param = (JobCommandAbilityParamEnum)comboBox4.SelectedIndex },
                    new JobCommandAbility() { Name = textBox18.Text, Param = (JobCommandAbilityParamEnum)comboBox5.SelectedIndex },
                    new JobCommandAbility() { Name = textBox19.Text, Param = (JobCommandAbilityParamEnum)comboBox6.SelectedIndex },
                    new JobCommandAbility() { Name = textBox20.Text, Param = (JobCommandAbilityParamEnum)comboBox7.SelectedIndex },
                    new JobCommandAbility() { Name = textBox21.Text, Param = (JobCommandAbilityParamEnum)comboBox8.SelectedIndex },
                };
                newJob.JobCommandAbility = jobCommandAbilities;

                List<JobSupportAbility> jobSupportAbilities = new List<JobSupportAbility>()
                {
                    new JobSupportAbility() { Name = textBox22.Text, NumberOfLearnedAbilitiesToUnlock = int.Parse(textBox29.Text) },
                    new JobSupportAbility() { Name = textBox23.Text, NumberOfLearnedAbilitiesToUnlock = int.Parse(textBox28.Text) },
                    new JobSupportAbility() { Name = textBox24.Text, NumberOfLearnedAbilitiesToUnlock = int.Parse(textBox27.Text) },
                    new JobSupportAbility() { Name = textBox25.Text, NumberOfLearnedAbilitiesToUnlock = int.Parse(textBox26.Text) },
                };
                newJob.JobSupportAbility = jobSupportAbilities;

                RessourcesManager.selectedJob = newJob;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured! {ex.Message}");
            }
        }

        public void ItemNameDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RessourcesManager.selectedJob is not null)
            {
                try
                {
                    textBox1.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.HP].ToString();
                    textBox2.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.MP].ToString();
                    textBox3.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.BP].ToString();
                    textBox4.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.SP].ToString();
                    textBox5.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.POT].ToString();
                    textBox6.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.ATK].ToString();
                    textBox7.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.DEF].ToString();
                    textBox8.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.MATK].ToString();
                    textBox9.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.MDEF].ToString();
                    textBox10.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.ACC].ToString();
                    textBox11.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.EVA].ToString();
                    textBox12.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.CON].ToString();
                    textBox13.Text = RessourcesManager.selectedJob.Value.ParameterRevision[(int)JobParameterEnum.AGI].ToString();

                    JobDataAqCheckBox1.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Sword];
                    JobDataAqCheckBox2.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Spear];
                    JobDataAqCheckBox3.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Dagger];
                    JobDataAqCheckBox4.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Axe];
                    JobDataAqCheckBox5.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Bow];
                    JobDataAqCheckBox6.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Staff];
                    JobDataAqCheckBox7.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Shield];
                    JobDataAqCheckBox8.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.UNKNOWN_1];
                    JobDataAqCheckBox9.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.UNKNOWN_2];
                    JobDataAqCheckBox10.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Head];
                    JobDataAqCheckBox11.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Body];
                    JobDataAqCheckBox12.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.UNKNOWN_3];
                    JobDataAqCheckBox13.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.UNKNOWN_4];
                    JobDataAqCheckBox14.Checked = RessourcesManager.selectedJob.Value.ProperEquipment[(int)JobEquipmentEnum.Accessories];

                    textBox37.Text = RessourcesManager.selectedJob.Value.JPCost[0].ToString();
                    textBox36.Text = RessourcesManager.selectedJob.Value.JPCost[1].ToString();
                    textBox35.Text = RessourcesManager.selectedJob.Value.JPCost[2].ToString();
                    textBox34.Text = RessourcesManager.selectedJob.Value.JPCost[3].ToString();
                    textBox33.Text = RessourcesManager.selectedJob.Value.JPCost[4].ToString();
                    textBox32.Text = RessourcesManager.selectedJob.Value.JPCost[5].ToString();
                    textBox31.Text = RessourcesManager.selectedJob.Value.JPCost[6].ToString();
                    textBox30.Text = RessourcesManager.selectedJob.Value.JPCost[7].ToString();

                    textBox14.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[0].Name;
                    textBox15.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[1].Name;
                    textBox16.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[2].Name;
                    textBox17.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[3].Name;
                    textBox18.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[4].Name;
                    textBox19.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[5].Name;
                    textBox20.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[6].Name;
                    textBox21.Text = RessourcesManager.selectedJob.Value.JobCommandAbility[7].Name;

                    comboBox1.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[0].Param;
                    comboBox2.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[1].Param;
                    comboBox3.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[2].Param;
                    comboBox4.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[3].Param;
                    comboBox5.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[4].Param;
                    comboBox6.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[5].Param;
                    comboBox7.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[6].Param;
                    comboBox8.SelectedIndex = (int)RessourcesManager.selectedJob.Value.JobCommandAbility[7].Param;

                    textBox22.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[0].Name;
                    textBox23.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[1].Name;
                    textBox24.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[2].Name;
                    textBox25.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[3].Name;

                    textBox29.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[0].NumberOfLearnedAbilitiesToUnlock.ToString();
                    textBox28.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[1].NumberOfLearnedAbilitiesToUnlock.ToString();
                    textBox27.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[2].NumberOfLearnedAbilitiesToUnlock.ToString();
                    textBox26.Text = RessourcesManager.selectedJob.Value.JobSupportAbility[3].NumberOfLearnedAbilitiesToUnlock.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured! {ex.Message}");
                }
            }
        }
    }
}
