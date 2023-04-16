namespace AppGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            OpenButton = new ToolStripMenuItem();
            SaveButton = new ToolStripMenuItem();
            SaveAsButton = new ToolStripMenuItem();
            CloseButton = new ToolStripMenuItem();
            ItemNameDB = new ComboBox();
            AbilityDataEnumLabel1 = new Label();
            AbilityDataEnumLabel2 = new Label();
            AbilityDataEnumLabel3 = new Label();
            AbilityDataEnumLabel4 = new Label();
            AbilityDataEnumLabel5 = new Label();
            AbilityDataPannel = new Panel();
            AbiCheckUseAbilityCamera = new CheckBox();
            AbiCheckEnableAutoTameMonster = new CheckBox();
            AbiCheckDanceAbilityFlag = new CheckBox();
            AbiCheckSongAbilityFlag = new CheckBox();
            AbiCheckEnableExcitement = new CheckBox();
            AbiCheckEnableCompensationMagic = new CheckBox();
            AbiCheckEnableSwitchWeapon = new CheckBox();
            AbiCheckEnableNoUseMaterial = new CheckBox();
            AbiCheckEnableForceWeakness = new CheckBox();
            AbiCheckEnableBusinessSupport = new CheckBox();
            AbiCheckEnableSession = new CheckBox();
            AbiCheckEnableNormalAttackAll = new CheckBox();
            AbiCheckEnableWeakCheckAll = new CheckBox();
            AbiCheckEnableChaseAttack = new CheckBox();
            AbiCheckEnableEnchant = new CheckBox();
            AbiCheckEnableDisableMagic = new CheckBox();
            AbiCheckEnableProvoke = new CheckBox();
            AbiCheckEnableCover = new CheckBox();
            AbiCheckEnableRepeat = new CheckBox();
            AbiCheckEnableHideOut = new CheckBox();
            AbiCheckEnableCounter = new CheckBox();
            AbiCheckEnableReflection = new CheckBox();
            AbiCheckEnableDiffusion = new CheckBox();
            AbiCheckEnableConvergence = new CheckBox();
            AbiCheckEnableSkillAll = new CheckBox();
            AbiCheckEnableItemAll = new CheckBox();
            AbiCheckKeepBoostEffect = new CheckBox();
            AbiCheckExceptEnforcer = new CheckBox();
            AbiCheckDependWeapon = new CheckBox();
            AbiCheckAlwaysDisable = new CheckBox();
            AbilityDataRandomCountMaxTextBox = new TextBox();
            AbilityDataRandomCountMinTextBox = new TextBox();
            AbilityDataMinimumCountTextBox = new TextBox();
            AbilityDataBaseCountTextBox = new TextBox();
            AbilityDataAbilityRatioTextBox = new TextBox();
            AbilityDataCriticalPowerTextBox = new TextBox();
            AbilityDataCriticalRatioTextBox = new TextBox();
            AbilityDataHitRatioTextBox = new TextBox();
            AbilityDataCostValueTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AbilityDataAilmentUpdateButton = new Button();
            AbilityAilmentLabel = new Label();
            AbilityAilmentButtonRemove = new Button();
            AbilityAilmentButtonAdd = new Button();
            AbiDisRatTextBox = new TextBox();
            AbiInvTurTextBox = new TextBox();
            AbiInvValTextBox = new TextBox();
            AbiNameTextBox = new TextBox();
            ailmentLabel4 = new Label();
            ailmentLabel3 = new Label();
            ailmentLabel2 = new Label();
            ailmentLabel1 = new Label();
            AbilityAilmentListBox = new ListBox();
            AbilityDataEnumBox5 = new ComboBox();
            AbilityDataEnumBox4 = new ComboBox();
            AbilityDataEnumBox3 = new ComboBox();
            AbilityDataEnumBox2 = new ComboBox();
            AbilityDataEnumBox1 = new ComboBox();
            SelectedItemLabel = new Label();
            LoadedDatabaseLabel = new Label();
            UpdateItemButton = new Button();
            UpdateLabel = new Label();
            menuStrip1.SuspendLayout();
            AbilityDataPannel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1242, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenButton, SaveButton, SaveAsButton, CloseButton });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpenButton
            // 
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(114, 22);
            OpenButton.Text = "Open";
            OpenButton.Click += openToolStripMenuItem_Click;
            // 
            // SaveButton
            // 
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(114, 22);
            SaveButton.Text = "Save";
            SaveButton.Click += saveToolStripMenuItem_Click;
            // 
            // SaveAsButton
            // 
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(114, 22);
            SaveAsButton.Text = "Save As";
            SaveAsButton.Click += saveAsToolStripMenuItem_Click;
            // 
            // CloseButton
            // 
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(114, 22);
            CloseButton.Text = "Close";
            CloseButton.Click += closeToolStripMenuItem_Click;
            // 
            // ItemNameDB
            // 
            ItemNameDB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ItemNameDB.AutoCompleteSource = AutoCompleteSource.ListItems;
            ItemNameDB.FormattingEnabled = true;
            ItemNameDB.Location = new Point(310, 57);
            ItemNameDB.Name = "ItemNameDB";
            ItemNameDB.Size = new Size(244, 23);
            ItemNameDB.TabIndex = 1;
            ItemNameDB.SelectedIndexChanged += ItemNameDB_SelectedIndexChanged;
            // 
            // AbilityDataEnumLabel1
            // 
            AbilityDataEnumLabel1.AutoSize = true;
            AbilityDataEnumLabel1.Location = new Point(42, 55);
            AbilityDataEnumLabel1.Name = "AbilityDataEnumLabel1";
            AbilityDataEnumLabel1.Size = new Size(72, 15);
            AbilityDataEnumLabel1.TabIndex = 2;
            AbilityDataEnumLabel1.Text = "EnumLabel1";
            // 
            // AbilityDataEnumLabel2
            // 
            AbilityDataEnumLabel2.AutoSize = true;
            AbilityDataEnumLabel2.Location = new Point(42, 101);
            AbilityDataEnumLabel2.Name = "AbilityDataEnumLabel2";
            AbilityDataEnumLabel2.Size = new Size(72, 15);
            AbilityDataEnumLabel2.TabIndex = 3;
            AbilityDataEnumLabel2.Text = "EnumLabel2";
            // 
            // AbilityDataEnumLabel3
            // 
            AbilityDataEnumLabel3.AutoSize = true;
            AbilityDataEnumLabel3.Location = new Point(42, 147);
            AbilityDataEnumLabel3.Name = "AbilityDataEnumLabel3";
            AbilityDataEnumLabel3.Size = new Size(72, 15);
            AbilityDataEnumLabel3.TabIndex = 4;
            AbilityDataEnumLabel3.Text = "EnumLabel3";
            // 
            // AbilityDataEnumLabel4
            // 
            AbilityDataEnumLabel4.AutoSize = true;
            AbilityDataEnumLabel4.Location = new Point(42, 196);
            AbilityDataEnumLabel4.Name = "AbilityDataEnumLabel4";
            AbilityDataEnumLabel4.Size = new Size(72, 15);
            AbilityDataEnumLabel4.TabIndex = 5;
            AbilityDataEnumLabel4.Text = "EnumLabel4";
            // 
            // AbilityDataEnumLabel5
            // 
            AbilityDataEnumLabel5.AutoSize = true;
            AbilityDataEnumLabel5.Location = new Point(42, 245);
            AbilityDataEnumLabel5.Name = "AbilityDataEnumLabel5";
            AbilityDataEnumLabel5.Size = new Size(72, 15);
            AbilityDataEnumLabel5.TabIndex = 6;
            AbilityDataEnumLabel5.Text = "EnumLabel5";
            // 
            // AbilityDataPannel
            // 
            AbilityDataPannel.Controls.Add(AbiCheckUseAbilityCamera);
            AbilityDataPannel.Controls.Add(AbiCheckEnableAutoTameMonster);
            AbilityDataPannel.Controls.Add(AbiCheckDanceAbilityFlag);
            AbilityDataPannel.Controls.Add(AbiCheckSongAbilityFlag);
            AbilityDataPannel.Controls.Add(AbiCheckEnableExcitement);
            AbilityDataPannel.Controls.Add(AbiCheckEnableCompensationMagic);
            AbilityDataPannel.Controls.Add(AbiCheckEnableSwitchWeapon);
            AbilityDataPannel.Controls.Add(AbiCheckEnableNoUseMaterial);
            AbilityDataPannel.Controls.Add(AbiCheckEnableForceWeakness);
            AbilityDataPannel.Controls.Add(AbiCheckEnableBusinessSupport);
            AbilityDataPannel.Controls.Add(AbiCheckEnableSession);
            AbilityDataPannel.Controls.Add(AbiCheckEnableNormalAttackAll);
            AbilityDataPannel.Controls.Add(AbiCheckEnableWeakCheckAll);
            AbilityDataPannel.Controls.Add(AbiCheckEnableChaseAttack);
            AbilityDataPannel.Controls.Add(AbiCheckEnableEnchant);
            AbilityDataPannel.Controls.Add(AbiCheckEnableDisableMagic);
            AbilityDataPannel.Controls.Add(AbiCheckEnableProvoke);
            AbilityDataPannel.Controls.Add(AbiCheckEnableCover);
            AbilityDataPannel.Controls.Add(AbiCheckEnableRepeat);
            AbilityDataPannel.Controls.Add(AbiCheckEnableHideOut);
            AbilityDataPannel.Controls.Add(AbiCheckEnableCounter);
            AbilityDataPannel.Controls.Add(AbiCheckEnableReflection);
            AbilityDataPannel.Controls.Add(AbiCheckEnableDiffusion);
            AbilityDataPannel.Controls.Add(AbiCheckEnableConvergence);
            AbilityDataPannel.Controls.Add(AbiCheckEnableSkillAll);
            AbilityDataPannel.Controls.Add(AbiCheckEnableItemAll);
            AbilityDataPannel.Controls.Add(AbiCheckKeepBoostEffect);
            AbilityDataPannel.Controls.Add(AbiCheckExceptEnforcer);
            AbilityDataPannel.Controls.Add(AbiCheckDependWeapon);
            AbilityDataPannel.Controls.Add(AbiCheckAlwaysDisable);
            AbilityDataPannel.Controls.Add(AbilityDataRandomCountMaxTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataRandomCountMinTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataMinimumCountTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataBaseCountTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataAbilityRatioTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataCriticalPowerTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataCriticalRatioTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataHitRatioTextBox);
            AbilityDataPannel.Controls.Add(AbilityDataCostValueTextBox);
            AbilityDataPannel.Controls.Add(label9);
            AbilityDataPannel.Controls.Add(label8);
            AbilityDataPannel.Controls.Add(label7);
            AbilityDataPannel.Controls.Add(label6);
            AbilityDataPannel.Controls.Add(label5);
            AbilityDataPannel.Controls.Add(label4);
            AbilityDataPannel.Controls.Add(label3);
            AbilityDataPannel.Controls.Add(label2);
            AbilityDataPannel.Controls.Add(label1);
            AbilityDataPannel.Controls.Add(AbilityDataAilmentUpdateButton);
            AbilityDataPannel.Controls.Add(AbilityAilmentLabel);
            AbilityDataPannel.Controls.Add(AbilityAilmentButtonRemove);
            AbilityDataPannel.Controls.Add(AbilityAilmentButtonAdd);
            AbilityDataPannel.Controls.Add(AbiDisRatTextBox);
            AbilityDataPannel.Controls.Add(AbiInvTurTextBox);
            AbilityDataPannel.Controls.Add(AbiInvValTextBox);
            AbilityDataPannel.Controls.Add(AbiNameTextBox);
            AbilityDataPannel.Controls.Add(ailmentLabel4);
            AbilityDataPannel.Controls.Add(ailmentLabel3);
            AbilityDataPannel.Controls.Add(ailmentLabel2);
            AbilityDataPannel.Controls.Add(ailmentLabel1);
            AbilityDataPannel.Controls.Add(AbilityAilmentListBox);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox5);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox4);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox3);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox2);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox1);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel1);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel5);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel2);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel4);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel3);
            AbilityDataPannel.Location = new Point(12, 86);
            AbilityDataPannel.Name = "AbilityDataPannel";
            AbilityDataPannel.Size = new Size(1218, 550);
            AbilityDataPannel.TabIndex = 7;
            // 
            // AbiCheckUseAbilityCamera
            // 
            AbiCheckUseAbilityCamera.AutoSize = true;
            AbiCheckUseAbilityCamera.Location = new Point(902, 404);
            AbiCheckUseAbilityCamera.Name = "AbiCheckUseAbilityCamera";
            AbiCheckUseAbilityCamera.Size = new Size(159, 19);
            AbiCheckUseAbilityCamera.TabIndex = 75;
            AbiCheckUseAbilityCamera.Text = "EnableAutoTameMonster";
            AbiCheckUseAbilityCamera.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableAutoTameMonster
            // 
            AbiCheckEnableAutoTameMonster.AutoSize = true;
            AbiCheckEnableAutoTameMonster.Location = new Point(902, 379);
            AbiCheckEnableAutoTameMonster.Name = "AbiCheckEnableAutoTameMonster";
            AbiCheckEnableAutoTameMonster.Size = new Size(159, 19);
            AbiCheckEnableAutoTameMonster.TabIndex = 74;
            AbiCheckEnableAutoTameMonster.Text = "EnableAutoTameMonster";
            AbiCheckEnableAutoTameMonster.UseVisualStyleBackColor = true;
            // 
            // AbiCheckDanceAbilityFlag
            // 
            AbiCheckDanceAbilityFlag.AutoSize = true;
            AbiCheckDanceAbilityFlag.Location = new Point(902, 354);
            AbiCheckDanceAbilityFlag.Name = "AbiCheckDanceAbilityFlag";
            AbiCheckDanceAbilityFlag.Size = new Size(115, 19);
            AbiCheckDanceAbilityFlag.TabIndex = 73;
            AbiCheckDanceAbilityFlag.Text = "DanceAbilityFlag";
            AbiCheckDanceAbilityFlag.UseVisualStyleBackColor = true;
            // 
            // AbiCheckSongAbilityFlag
            // 
            AbiCheckSongAbilityFlag.AutoSize = true;
            AbiCheckSongAbilityFlag.Location = new Point(902, 329);
            AbiCheckSongAbilityFlag.Name = "AbiCheckSongAbilityFlag";
            AbiCheckSongAbilityFlag.Size = new Size(109, 19);
            AbiCheckSongAbilityFlag.TabIndex = 72;
            AbiCheckSongAbilityFlag.Text = "SongAbilityFlag";
            AbiCheckSongAbilityFlag.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableExcitement
            // 
            AbiCheckEnableExcitement.AutoSize = true;
            AbiCheckEnableExcitement.Location = new Point(902, 304);
            AbiCheckEnableExcitement.Name = "AbiCheckEnableExcitement";
            AbiCheckEnableExcitement.Size = new Size(120, 19);
            AbiCheckEnableExcitement.TabIndex = 71;
            AbiCheckEnableExcitement.Text = "EnableExcitement";
            AbiCheckEnableExcitement.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableCompensationMagic
            // 
            AbiCheckEnableCompensationMagic.AutoSize = true;
            AbiCheckEnableCompensationMagic.Location = new Point(902, 279);
            AbiCheckEnableCompensationMagic.Name = "AbiCheckEnableCompensationMagic";
            AbiCheckEnableCompensationMagic.Size = new Size(172, 19);
            AbiCheckEnableCompensationMagic.TabIndex = 70;
            AbiCheckEnableCompensationMagic.Text = "EnableCompensationMagic";
            AbiCheckEnableCompensationMagic.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableSwitchWeapon
            // 
            AbiCheckEnableSwitchWeapon.AutoSize = true;
            AbiCheckEnableSwitchWeapon.Location = new Point(902, 254);
            AbiCheckEnableSwitchWeapon.Name = "AbiCheckEnableSwitchWeapon";
            AbiCheckEnableSwitchWeapon.Size = new Size(140, 19);
            AbiCheckEnableSwitchWeapon.TabIndex = 69;
            AbiCheckEnableSwitchWeapon.Text = "EnableSwitchWeapon";
            AbiCheckEnableSwitchWeapon.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableNoUseMaterial
            // 
            AbiCheckEnableNoUseMaterial.AutoSize = true;
            AbiCheckEnableNoUseMaterial.Location = new Point(902, 229);
            AbiCheckEnableNoUseMaterial.Name = "AbiCheckEnableNoUseMaterial";
            AbiCheckEnableNoUseMaterial.Size = new Size(139, 19);
            AbiCheckEnableNoUseMaterial.TabIndex = 68;
            AbiCheckEnableNoUseMaterial.Text = "EnableNoUseMaterial";
            AbiCheckEnableNoUseMaterial.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableForceWeakness
            // 
            AbiCheckEnableForceWeakness.AutoSize = true;
            AbiCheckEnableForceWeakness.Location = new Point(902, 204);
            AbiCheckEnableForceWeakness.Name = "AbiCheckEnableForceWeakness";
            AbiCheckEnableForceWeakness.Size = new Size(142, 19);
            AbiCheckEnableForceWeakness.TabIndex = 67;
            AbiCheckEnableForceWeakness.Text = "EnableForceWeakness";
            AbiCheckEnableForceWeakness.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableBusinessSupport
            // 
            AbiCheckEnableBusinessSupport.AutoSize = true;
            AbiCheckEnableBusinessSupport.Location = new Point(902, 179);
            AbiCheckEnableBusinessSupport.Name = "AbiCheckEnableBusinessSupport";
            AbiCheckEnableBusinessSupport.Size = new Size(148, 19);
            AbiCheckEnableBusinessSupport.TabIndex = 66;
            AbiCheckEnableBusinessSupport.Text = "EnableBusinessSupport";
            AbiCheckEnableBusinessSupport.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableSession
            // 
            AbiCheckEnableSession.AutoSize = true;
            AbiCheckEnableSession.Location = new Point(902, 154);
            AbiCheckEnableSession.Name = "AbiCheckEnableSession";
            AbiCheckEnableSession.Size = new Size(100, 19);
            AbiCheckEnableSession.TabIndex = 65;
            AbiCheckEnableSession.Text = "EnableSession";
            AbiCheckEnableSession.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableNormalAttackAll
            // 
            AbiCheckEnableNormalAttackAll.AutoSize = true;
            AbiCheckEnableNormalAttackAll.Location = new Point(902, 129);
            AbiCheckEnableNormalAttackAll.Name = "AbiCheckEnableNormalAttackAll";
            AbiCheckEnableNormalAttackAll.Size = new Size(149, 19);
            AbiCheckEnableNormalAttackAll.TabIndex = 64;
            AbiCheckEnableNormalAttackAll.Text = "EnableNormalAttackAll";
            AbiCheckEnableNormalAttackAll.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableWeakCheckAll
            // 
            AbiCheckEnableWeakCheckAll.AutoSize = true;
            AbiCheckEnableWeakCheckAll.Location = new Point(902, 104);
            AbiCheckEnableWeakCheckAll.Name = "AbiCheckEnableWeakCheckAll";
            AbiCheckEnableWeakCheckAll.Size = new Size(137, 19);
            AbiCheckEnableWeakCheckAll.TabIndex = 63;
            AbiCheckEnableWeakCheckAll.Text = "EnableWeakCheckAll";
            AbiCheckEnableWeakCheckAll.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableChaseAttack
            // 
            AbiCheckEnableChaseAttack.AutoSize = true;
            AbiCheckEnableChaseAttack.Location = new Point(902, 79);
            AbiCheckEnableChaseAttack.Name = "AbiCheckEnableChaseAttack";
            AbiCheckEnableChaseAttack.Size = new Size(127, 19);
            AbiCheckEnableChaseAttack.TabIndex = 62;
            AbiCheckEnableChaseAttack.Text = "EnableChaseAttack";
            AbiCheckEnableChaseAttack.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableEnchant
            // 
            AbiCheckEnableEnchant.AutoSize = true;
            AbiCheckEnableEnchant.Location = new Point(902, 54);
            AbiCheckEnableEnchant.Name = "AbiCheckEnableEnchant";
            AbiCheckEnableEnchant.Size = new Size(104, 19);
            AbiCheckEnableEnchant.TabIndex = 61;
            AbiCheckEnableEnchant.Text = "EnableEnchant";
            AbiCheckEnableEnchant.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableDisableMagic
            // 
            AbiCheckEnableDisableMagic.AutoSize = true;
            AbiCheckEnableDisableMagic.Location = new Point(754, 401);
            AbiCheckEnableDisableMagic.Name = "AbiCheckEnableDisableMagic";
            AbiCheckEnableDisableMagic.Size = new Size(132, 19);
            AbiCheckEnableDisableMagic.TabIndex = 60;
            AbiCheckEnableDisableMagic.Text = "EnableDisableMagic";
            AbiCheckEnableDisableMagic.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableProvoke
            // 
            AbiCheckEnableProvoke.AutoSize = true;
            AbiCheckEnableProvoke.Location = new Point(754, 376);
            AbiCheckEnableProvoke.Name = "AbiCheckEnableProvoke";
            AbiCheckEnableProvoke.Size = new Size(104, 19);
            AbiCheckEnableProvoke.TabIndex = 59;
            AbiCheckEnableProvoke.Text = "EnableProvoke";
            AbiCheckEnableProvoke.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableCover
            // 
            AbiCheckEnableCover.AutoSize = true;
            AbiCheckEnableCover.Location = new Point(754, 351);
            AbiCheckEnableCover.Name = "AbiCheckEnableCover";
            AbiCheckEnableCover.Size = new Size(92, 19);
            AbiCheckEnableCover.TabIndex = 58;
            AbiCheckEnableCover.Text = "EnableCover";
            AbiCheckEnableCover.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableRepeat
            // 
            AbiCheckEnableRepeat.AutoSize = true;
            AbiCheckEnableRepeat.Location = new Point(754, 326);
            AbiCheckEnableRepeat.Name = "AbiCheckEnableRepeat";
            AbiCheckEnableRepeat.Size = new Size(97, 19);
            AbiCheckEnableRepeat.TabIndex = 57;
            AbiCheckEnableRepeat.Text = "EnableRepeat";
            AbiCheckEnableRepeat.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableHideOut
            // 
            AbiCheckEnableHideOut.AutoSize = true;
            AbiCheckEnableHideOut.Location = new Point(754, 301);
            AbiCheckEnableHideOut.Name = "AbiCheckEnableHideOut";
            AbiCheckEnableHideOut.Size = new Size(106, 19);
            AbiCheckEnableHideOut.TabIndex = 56;
            AbiCheckEnableHideOut.Text = "EnableHideOut";
            AbiCheckEnableHideOut.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableCounter
            // 
            AbiCheckEnableCounter.AutoSize = true;
            AbiCheckEnableCounter.Location = new Point(754, 276);
            AbiCheckEnableCounter.Name = "AbiCheckEnableCounter";
            AbiCheckEnableCounter.Size = new Size(104, 19);
            AbiCheckEnableCounter.TabIndex = 55;
            AbiCheckEnableCounter.Text = "EnableCounter";
            AbiCheckEnableCounter.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableReflection
            // 
            AbiCheckEnableReflection.AutoSize = true;
            AbiCheckEnableReflection.Location = new Point(754, 251);
            AbiCheckEnableReflection.Name = "AbiCheckEnableReflection";
            AbiCheckEnableReflection.Size = new Size(114, 19);
            AbiCheckEnableReflection.TabIndex = 54;
            AbiCheckEnableReflection.Text = "EnableReflection";
            AbiCheckEnableReflection.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableDiffusion
            // 
            AbiCheckEnableDiffusion.AutoSize = true;
            AbiCheckEnableDiffusion.Location = new Point(754, 226);
            AbiCheckEnableDiffusion.Name = "AbiCheckEnableDiffusion";
            AbiCheckEnableDiffusion.Size = new Size(109, 19);
            AbiCheckEnableDiffusion.TabIndex = 53;
            AbiCheckEnableDiffusion.Text = "EnableDiffusion";
            AbiCheckEnableDiffusion.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableConvergence
            // 
            AbiCheckEnableConvergence.AutoSize = true;
            AbiCheckEnableConvergence.Location = new Point(754, 201);
            AbiCheckEnableConvergence.Name = "AbiCheckEnableConvergence";
            AbiCheckEnableConvergence.Size = new Size(131, 19);
            AbiCheckEnableConvergence.TabIndex = 52;
            AbiCheckEnableConvergence.Text = "EnableConvergence";
            AbiCheckEnableConvergence.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableSkillAll
            // 
            AbiCheckEnableSkillAll.AutoSize = true;
            AbiCheckEnableSkillAll.Location = new Point(754, 176);
            AbiCheckEnableSkillAll.Name = "AbiCheckEnableSkillAll";
            AbiCheckEnableSkillAll.Size = new Size(96, 19);
            AbiCheckEnableSkillAll.TabIndex = 51;
            AbiCheckEnableSkillAll.Text = "EnableSkillAll";
            AbiCheckEnableSkillAll.UseVisualStyleBackColor = true;
            // 
            // AbiCheckEnableItemAll
            // 
            AbiCheckEnableItemAll.AutoSize = true;
            AbiCheckEnableItemAll.Location = new Point(754, 151);
            AbiCheckEnableItemAll.Name = "AbiCheckEnableItemAll";
            AbiCheckEnableItemAll.Size = new Size(99, 19);
            AbiCheckEnableItemAll.TabIndex = 50;
            AbiCheckEnableItemAll.Text = "EnableItemAll";
            AbiCheckEnableItemAll.UseVisualStyleBackColor = true;
            // 
            // AbiCheckKeepBoostEffect
            // 
            AbiCheckKeepBoostEffect.AutoSize = true;
            AbiCheckKeepBoostEffect.Location = new Point(754, 126);
            AbiCheckKeepBoostEffect.Name = "AbiCheckKeepBoostEffect";
            AbiCheckKeepBoostEffect.Size = new Size(112, 19);
            AbiCheckKeepBoostEffect.TabIndex = 49;
            AbiCheckKeepBoostEffect.Text = "KeepBoostEffect";
            AbiCheckKeepBoostEffect.UseVisualStyleBackColor = true;
            // 
            // AbiCheckExceptEnforcer
            // 
            AbiCheckExceptEnforcer.AutoSize = true;
            AbiCheckExceptEnforcer.Location = new Point(754, 101);
            AbiCheckExceptEnforcer.Name = "AbiCheckExceptEnforcer";
            AbiCheckExceptEnforcer.Size = new Size(105, 19);
            AbiCheckExceptEnforcer.TabIndex = 48;
            AbiCheckExceptEnforcer.Text = "ExceptEnforcer";
            AbiCheckExceptEnforcer.UseVisualStyleBackColor = true;
            // 
            // AbiCheckDependWeapon
            // 
            AbiCheckDependWeapon.AutoSize = true;
            AbiCheckDependWeapon.Location = new Point(754, 76);
            AbiCheckDependWeapon.Name = "AbiCheckDependWeapon";
            AbiCheckDependWeapon.Size = new Size(111, 19);
            AbiCheckDependWeapon.TabIndex = 47;
            AbiCheckDependWeapon.Text = "DependWeapon";
            AbiCheckDependWeapon.UseVisualStyleBackColor = true;
            // 
            // AbiCheckAlwaysDisable
            // 
            AbiCheckAlwaysDisable.AutoSize = true;
            AbiCheckAlwaysDisable.Location = new Point(754, 51);
            AbiCheckAlwaysDisable.Name = "AbiCheckAlwaysDisable";
            AbiCheckAlwaysDisable.Size = new Size(101, 19);
            AbiCheckAlwaysDisable.TabIndex = 46;
            AbiCheckAlwaysDisable.Text = "AlwaysDisable";
            AbiCheckAlwaysDisable.UseVisualStyleBackColor = true;
            // 
            // AbilityDataRandomCountMaxTextBox
            // 
            AbilityDataRandomCountMaxTextBox.Location = new Point(544, 276);
            AbilityDataRandomCountMaxTextBox.Name = "AbilityDataRandomCountMaxTextBox";
            AbilityDataRandomCountMaxTextBox.Size = new Size(100, 23);
            AbilityDataRandomCountMaxTextBox.TabIndex = 45;
            // 
            // AbilityDataRandomCountMinTextBox
            // 
            AbilityDataRandomCountMinTextBox.Location = new Point(544, 247);
            AbilityDataRandomCountMinTextBox.Name = "AbilityDataRandomCountMinTextBox";
            AbilityDataRandomCountMinTextBox.Size = new Size(100, 23);
            AbilityDataRandomCountMinTextBox.TabIndex = 44;
            // 
            // AbilityDataMinimumCountTextBox
            // 
            AbilityDataMinimumCountTextBox.Location = new Point(544, 218);
            AbilityDataMinimumCountTextBox.Name = "AbilityDataMinimumCountTextBox";
            AbilityDataMinimumCountTextBox.Size = new Size(100, 23);
            AbilityDataMinimumCountTextBox.TabIndex = 43;
            // 
            // AbilityDataBaseCountTextBox
            // 
            AbilityDataBaseCountTextBox.Location = new Point(544, 189);
            AbilityDataBaseCountTextBox.Name = "AbilityDataBaseCountTextBox";
            AbilityDataBaseCountTextBox.Size = new Size(100, 23);
            AbilityDataBaseCountTextBox.TabIndex = 42;
            // 
            // AbilityDataAbilityRatioTextBox
            // 
            AbilityDataAbilityRatioTextBox.Location = new Point(544, 160);
            AbilityDataAbilityRatioTextBox.Name = "AbilityDataAbilityRatioTextBox";
            AbilityDataAbilityRatioTextBox.Size = new Size(100, 23);
            AbilityDataAbilityRatioTextBox.TabIndex = 41;
            // 
            // AbilityDataCriticalPowerTextBox
            // 
            AbilityDataCriticalPowerTextBox.Location = new Point(544, 131);
            AbilityDataCriticalPowerTextBox.Name = "AbilityDataCriticalPowerTextBox";
            AbilityDataCriticalPowerTextBox.Size = new Size(100, 23);
            AbilityDataCriticalPowerTextBox.TabIndex = 40;
            // 
            // AbilityDataCriticalRatioTextBox
            // 
            AbilityDataCriticalRatioTextBox.Location = new Point(544, 102);
            AbilityDataCriticalRatioTextBox.Name = "AbilityDataCriticalRatioTextBox";
            AbilityDataCriticalRatioTextBox.Size = new Size(100, 23);
            AbilityDataCriticalRatioTextBox.TabIndex = 39;
            // 
            // AbilityDataHitRatioTextBox
            // 
            AbilityDataHitRatioTextBox.Location = new Point(544, 73);
            AbilityDataHitRatioTextBox.Name = "AbilityDataHitRatioTextBox";
            AbilityDataHitRatioTextBox.Size = new Size(100, 23);
            AbilityDataHitRatioTextBox.TabIndex = 38;
            // 
            // AbilityDataCostValueTextBox
            // 
            AbilityDataCostValueTextBox.Location = new Point(544, 44);
            AbilityDataCostValueTextBox.Name = "AbilityDataCostValueTextBox";
            AbilityDataCostValueTextBox.Size = new Size(100, 23);
            AbilityDataCostValueTextBox.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(426, 279);
            label9.Name = "label9";
            label9.Size = new Size(112, 15);
            label9.TabIndex = 36;
            label9.Text = "Random count max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 250);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 35;
            label8.Text = "Random count min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 221);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 34;
            label7.Text = "Minimum count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 192);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 33;
            label6.Text = "Base count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 163);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 32;
            label5.Text = "Ability Ratio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 134);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 31;
            label4.Text = "Critical Power";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 105);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 30;
            label3.Text = "Critical Ratio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 76);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 29;
            label2.Text = "Hit Ratio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 28;
            label1.Text = "Cost Value";
            // 
            // AbilityDataAilmentUpdateButton
            // 
            AbilityDataAilmentUpdateButton.Location = new Point(312, 489);
            AbilityDataAilmentUpdateButton.Name = "AbilityDataAilmentUpdateButton";
            AbilityDataAilmentUpdateButton.Size = new Size(133, 23);
            AbilityDataAilmentUpdateButton.TabIndex = 27;
            AbilityDataAilmentUpdateButton.Text = "Update Ailment";
            AbilityDataAilmentUpdateButton.UseVisualStyleBackColor = true;
            AbilityDataAilmentUpdateButton.Click += AbilityDataAilmentUpdateButton_Click;
            // 
            // AbilityAilmentLabel
            // 
            AbilityAilmentLabel.AutoSize = true;
            AbilityAilmentLabel.Location = new Point(84, 359);
            AbilityAilmentLabel.Name = "AbilityAilmentLabel";
            AbilityAilmentLabel.Size = new Size(107, 15);
            AbilityAilmentLabel.TabIndex = 26;
            AbilityAilmentLabel.Text = "Ability Ailment List";
            // 
            // AbilityAilmentButtonRemove
            // 
            AbilityAilmentButtonRemove.Location = new Point(181, 485);
            AbilityAilmentButtonRemove.Name = "AbilityAilmentButtonRemove";
            AbilityAilmentButtonRemove.Size = new Size(75, 23);
            AbilityAilmentButtonRemove.TabIndex = 25;
            AbilityAilmentButtonRemove.Text = "Remove";
            AbilityAilmentButtonRemove.UseVisualStyleBackColor = true;
            AbilityAilmentButtonRemove.Click += AbilityAilmentButtonRemove_Click;
            // 
            // AbilityAilmentButtonAdd
            // 
            AbilityAilmentButtonAdd.Location = new Point(100, 485);
            AbilityAilmentButtonAdd.Name = "AbilityAilmentButtonAdd";
            AbilityAilmentButtonAdd.Size = new Size(75, 23);
            AbilityAilmentButtonAdd.TabIndex = 24;
            AbilityAilmentButtonAdd.Text = "Add";
            AbilityAilmentButtonAdd.UseVisualStyleBackColor = true;
            AbilityAilmentButtonAdd.Click += AbilityAilmentButtonAdd_Click;
            // 
            // AbiDisRatTextBox
            // 
            AbiDisRatTextBox.Location = new Point(392, 456);
            AbiDisRatTextBox.Name = "AbiDisRatTextBox";
            AbiDisRatTextBox.Size = new Size(100, 23);
            AbiDisRatTextBox.TabIndex = 23;
            AbiDisRatTextBox.Text = "Dis Rat";
            // 
            // AbiInvTurTextBox
            // 
            AbiInvTurTextBox.Location = new Point(392, 427);
            AbiInvTurTextBox.Name = "AbiInvTurTextBox";
            AbiInvTurTextBox.Size = new Size(100, 23);
            AbiInvTurTextBox.TabIndex = 22;
            AbiInvTurTextBox.Text = "Inv Tur";
            // 
            // AbiInvValTextBox
            // 
            AbiInvValTextBox.Location = new Point(392, 398);
            AbiInvValTextBox.Name = "AbiInvValTextBox";
            AbiInvValTextBox.Size = new Size(100, 23);
            AbiInvValTextBox.TabIndex = 21;
            AbiInvValTextBox.Text = "Inv Val";
            // 
            // AbiNameTextBox
            // 
            AbiNameTextBox.Location = new Point(355, 369);
            AbiNameTextBox.Name = "AbiNameTextBox";
            AbiNameTextBox.Size = new Size(137, 23);
            AbiNameTextBox.TabIndex = 20;
            AbiNameTextBox.Text = "Name";
            // 
            // ailmentLabel4
            // 
            ailmentLabel4.AutoSize = true;
            ailmentLabel4.Location = new Point(279, 459);
            ailmentLabel4.Name = "ailmentLabel4";
            ailmentLabel4.Size = new Size(72, 15);
            ailmentLabel4.TabIndex = 19;
            ailmentLabel4.Text = "Disease Rate";
            // 
            // ailmentLabel3
            // 
            ailmentLabel3.AutoSize = true;
            ailmentLabel3.Location = new Point(279, 430);
            ailmentLabel3.Name = "ailmentLabel3";
            ailmentLabel3.Size = new Size(90, 15);
            ailmentLabel3.TabIndex = 18;
            ailmentLabel3.Text = "Invocation Turn";
            // 
            // ailmentLabel2
            // 
            ailmentLabel2.AutoSize = true;
            ailmentLabel2.Location = new Point(279, 401);
            ailmentLabel2.Name = "ailmentLabel2";
            ailmentLabel2.Size = new Size(94, 15);
            ailmentLabel2.TabIndex = 17;
            ailmentLabel2.Text = "Invocation Value";
            // 
            // ailmentLabel1
            // 
            ailmentLabel1.AutoSize = true;
            ailmentLabel1.Location = new Point(279, 372);
            ailmentLabel1.Name = "ailmentLabel1";
            ailmentLabel1.Size = new Size(39, 15);
            ailmentLabel1.TabIndex = 16;
            ailmentLabel1.Text = "Name";
            // 
            // AbilityAilmentListBox
            // 
            AbilityAilmentListBox.FormattingEnabled = true;
            AbilityAilmentListBox.ItemHeight = 15;
            AbilityAilmentListBox.Location = new Point(82, 377);
            AbilityAilmentListBox.Name = "AbilityAilmentListBox";
            AbilityAilmentListBox.Size = new Size(191, 94);
            AbilityAilmentListBox.TabIndex = 15;
            AbilityAilmentListBox.SelectedIndexChanged += AbilityAilmentListBox_SelectedIndexChanged;
            // 
            // AbilityDataEnumBox5
            // 
            AbilityDataEnumBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox5.FormattingEnabled = true;
            AbilityDataEnumBox5.Location = new Point(197, 242);
            AbilityDataEnumBox5.Name = "AbilityDataEnumBox5";
            AbilityDataEnumBox5.Size = new Size(121, 23);
            AbilityDataEnumBox5.TabIndex = 11;
            // 
            // AbilityDataEnumBox4
            // 
            AbilityDataEnumBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox4.FormattingEnabled = true;
            AbilityDataEnumBox4.Location = new Point(197, 193);
            AbilityDataEnumBox4.Name = "AbilityDataEnumBox4";
            AbilityDataEnumBox4.Size = new Size(121, 23);
            AbilityDataEnumBox4.TabIndex = 10;
            // 
            // AbilityDataEnumBox3
            // 
            AbilityDataEnumBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox3.FormattingEnabled = true;
            AbilityDataEnumBox3.Location = new Point(197, 144);
            AbilityDataEnumBox3.Name = "AbilityDataEnumBox3";
            AbilityDataEnumBox3.Size = new Size(121, 23);
            AbilityDataEnumBox3.TabIndex = 9;
            // 
            // AbilityDataEnumBox2
            // 
            AbilityDataEnumBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox2.FormattingEnabled = true;
            AbilityDataEnumBox2.Location = new Point(197, 98);
            AbilityDataEnumBox2.Name = "AbilityDataEnumBox2";
            AbilityDataEnumBox2.Size = new Size(121, 23);
            AbilityDataEnumBox2.TabIndex = 8;
            // 
            // AbilityDataEnumBox1
            // 
            AbilityDataEnumBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox1.FormattingEnabled = true;
            AbilityDataEnumBox1.Location = new Point(197, 52);
            AbilityDataEnumBox1.Name = "AbilityDataEnumBox1";
            AbilityDataEnumBox1.Size = new Size(121, 23);
            AbilityDataEnumBox1.TabIndex = 7;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Location = new Point(155, 60);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(78, 15);
            SelectedItemLabel.TabIndex = 8;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // LoadedDatabaseLabel
            // 
            LoadedDatabaseLabel.AutoSize = true;
            LoadedDatabaseLabel.Location = new Point(914, 60);
            LoadedDatabaseLabel.Name = "LoadedDatabaseLabel";
            LoadedDatabaseLabel.Size = new Size(63, 15);
            LoadedDatabaseLabel.TabIndex = 12;
            LoadedDatabaseLabel.Text = "Loaded db";
            // 
            // UpdateItemButton
            // 
            UpdateItemButton.Location = new Point(579, 56);
            UpdateItemButton.Name = "UpdateItemButton";
            UpdateItemButton.Size = new Size(135, 23);
            UpdateItemButton.TabIndex = 13;
            UpdateItemButton.Text = "Update Item";
            UpdateItemButton.UseVisualStyleBackColor = true;
            UpdateItemButton.Click += UpdateItemButton_Click;
            // 
            // UpdateLabel
            // 
            UpdateLabel.AutoSize = true;
            UpdateLabel.Location = new Point(746, 60);
            UpdateLabel.Name = "UpdateLabel";
            UpdateLabel.Size = new Size(76, 15);
            UpdateLabel.TabIndex = 14;
            UpdateLabel.Text = "Update Label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 648);
            Controls.Add(UpdateLabel);
            Controls.Add(UpdateItemButton);
            Controls.Add(LoadedDatabaseLabel);
            Controls.Add(SelectedItemLabel);
            Controls.Add(AbilityDataPannel);
            Controls.Add(ItemNameDB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Octopath Traveler 2 UAsset Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            AbilityDataPannel.ResumeLayout(false);
            AbilityDataPannel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpenButton;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem SaveAsButton;
        private ToolStripMenuItem CloseButton;
        private ComboBox ItemNameDB;
        private Label AbilityDataEnumLabel1;
        private Label AbilityDataEnumLabel2;
        private Label AbilityDataEnumLabel3;
        private Label AbilityDataEnumLabel4;
        private Label AbilityDataEnumLabel5;
        private Panel AbilityDataPannel;
        private ComboBox AbilityDataEnumBox1;
        private ComboBox AbilityDataEnumBox5;
        private ComboBox AbilityDataEnumBox4;
        private ComboBox AbilityDataEnumBox3;
        private ComboBox AbilityDataEnumBox2;
        private Label SelectedItemLabel;
        private Label LoadedDatabaseLabel;
        private Button UpdateItemButton;
        private Label UpdateLabel;
        private ListBox AbilityAilmentListBox;
        private Label ailmentLabel4;
        private Label ailmentLabel3;
        private Label ailmentLabel2;
        private Label ailmentLabel1;
        private Button AbilityAilmentButtonRemove;
        private Button AbilityAilmentButtonAdd;
        private TextBox AbiDisRatTextBox;
        private TextBox AbiInvTurTextBox;
        private TextBox AbiInvValTextBox;
        private TextBox AbiNameTextBox;
        private Label AbilityAilmentLabel;
        private Button AbilityDataAilmentUpdateButton;
        private TextBox AbilityDataRandomCountMaxTextBox;
        private TextBox AbilityDataRandomCountMinTextBox;
        private TextBox AbilityDataMinimumCountTextBox;
        private TextBox AbilityDataBaseCountTextBox;
        private TextBox AbilityDataAbilityRatioTextBox;
        private TextBox AbilityDataCriticalPowerTextBox;
        private TextBox AbilityDataCriticalRatioTextBox;
        private TextBox AbilityDataHitRatioTextBox;
        private TextBox AbilityDataCostValueTextBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox AbiCheckUseAbilityCamera;
        private CheckBox AbiCheckEnableAutoTameMonster;
        private CheckBox AbiCheckDanceAbilityFlag;
        private CheckBox AbiCheckSongAbilityFlag;
        private CheckBox AbiCheckEnableExcitement;
        private CheckBox AbiCheckEnableCompensationMagic;
        private CheckBox AbiCheckEnableSwitchWeapon;
        private CheckBox AbiCheckEnableNoUseMaterial;
        private CheckBox AbiCheckEnableForceWeakness;
        private CheckBox AbiCheckEnableBusinessSupport;
        private CheckBox AbiCheckEnableSession;
        private CheckBox AbiCheckEnableNormalAttackAll;
        private CheckBox AbiCheckEnableWeakCheckAll;
        private CheckBox AbiCheckEnableChaseAttack;
        private CheckBox AbiCheckEnableEnchant;
        private CheckBox AbiCheckEnableDisableMagic;
        private CheckBox AbiCheckEnableProvoke;
        private CheckBox AbiCheckEnableCover;
        private CheckBox AbiCheckEnableRepeat;
        private CheckBox AbiCheckEnableHideOut;
        private CheckBox AbiCheckEnableCounter;
        private CheckBox AbiCheckEnableReflection;
        private CheckBox AbiCheckEnableDiffusion;
        private CheckBox AbiCheckEnableConvergence;
        private CheckBox AbiCheckEnableSkillAll;
        private CheckBox AbiCheckEnableItemAll;
        private CheckBox AbiCheckKeepBoostEffect;
        private CheckBox AbiCheckExceptEnforcer;
        private CheckBox AbiCheckDependWeapon;
        private CheckBox AbiCheckAlwaysDisable;
    }
}