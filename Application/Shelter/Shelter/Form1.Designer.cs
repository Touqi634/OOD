namespace ShelterManager
{
    partial class frmShelterManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbManage = new System.Windows.Forms.GroupBox();
            this.btnSaveShelter = new System.Windows.Forms.Button();
            this.tbScanRFID = new System.Windows.Forms.TextBox();
            this.rbScanRFID = new System.Windows.Forms.RadioButton();
            this.rbAdoptable = new System.Windows.Forms.RadioButton();
            this.rbAnimalsShelter = new System.Windows.Forms.RadioButton();
            this.rbAnimals = new System.Windows.Forms.RadioButton();
            this.rbOwners = new System.Windows.Forms.RadioButton();
            this.btnAdopt = new System.Windows.Forms.Button();
            this.lblSelectedAnimal = new System.Windows.Forms.Label();
            this.lblSpecificOwner = new System.Windows.Forms.Label();
            this.lblSpecific = new System.Windows.Forms.Label();
            this.btnWalk = new System.Windows.Forms.Button();
            this.btnClaim = new System.Windows.Forms.Button();
            this.lbOut2 = new System.Windows.Forms.ListBox();
            this.btnCheckClaimable = new System.Windows.Forms.Button();
            this.gbAddOwner = new System.Windows.Forms.GroupBox();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.tbAddOwnerID = new System.Windows.Forms.TextBox();
            this.tbAddOwnerName = new System.Windows.Forms.TextBox();
            this.btnAddOwnerCancel = new System.Windows.Forms.Button();
            this.btnAddOwnerConfirm = new System.Windows.Forms.Button();
            this.gbAddAnimal = new System.Windows.Forms.GroupBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.tbExtraInfo = new System.Windows.Forms.TextBox();
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDateFound = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tbAddAnimalDescription = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.dtpFoundDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.lbOut = new System.Windows.Forms.ListBox();
            this.lblDisplayShelterName = new System.Windows.Forms.Label();
            this.gbShelters = new System.Windows.Forms.GroupBox();
            this.gbShelterDetails = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblShelterAddress = new System.Windows.Forms.Label();
            this.lblShelterPhone = new System.Windows.Forms.Label();
            this.lblShelterEmail = new System.Windows.Forms.Label();
            this.lblShelterName = new System.Windows.Forms.Label();
            this.tbShelterAddress = new System.Windows.Forms.TextBox();
            this.tbShelterPhone = new System.Windows.Forms.TextBox();
            this.tbShelterEmail = new System.Windows.Forms.TextBox();
            this.tbShelterName = new System.Windows.Forms.TextBox();
            this.btnCreateShelter = new System.Windows.Forms.Button();
            this.btnOpenShelter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbManage.SuspendLayout();
            this.gbAddOwner.SuspendLayout();
            this.gbAddAnimal.SuspendLayout();
            this.gbShelters.SuspendLayout();
            this.gbShelterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManage
            // 
            this.gbManage.Controls.Add(this.btnSaveShelter);
            this.gbManage.Controls.Add(this.tbScanRFID);
            this.gbManage.Controls.Add(this.rbScanRFID);
            this.gbManage.Controls.Add(this.rbAdoptable);
            this.gbManage.Controls.Add(this.rbAnimalsShelter);
            this.gbManage.Controls.Add(this.rbAnimals);
            this.gbManage.Controls.Add(this.rbOwners);
            this.gbManage.Controls.Add(this.btnAdopt);
            this.gbManage.Controls.Add(this.lblSelectedAnimal);
            this.gbManage.Controls.Add(this.lblSpecificOwner);
            this.gbManage.Controls.Add(this.lblSpecific);
            this.gbManage.Controls.Add(this.btnWalk);
            this.gbManage.Controls.Add(this.btnClaim);
            this.gbManage.Controls.Add(this.lbOut2);
            this.gbManage.Controls.Add(this.btnCheckClaimable);
            this.gbManage.Controls.Add(this.gbAddOwner);
            this.gbManage.Controls.Add(this.gbAddAnimal);
            this.gbManage.Controls.Add(this.btnAddAnimal);
            this.gbManage.Controls.Add(this.btnAddOwner);
            this.gbManage.Controls.Add(this.lbOut);
            this.gbManage.Controls.Add(this.lblDisplayShelterName);
            this.gbManage.Location = new System.Drawing.Point(12, 12);
            this.gbManage.Name = "gbManage";
            this.gbManage.Size = new System.Drawing.Size(1458, 700);
            this.gbManage.TabIndex = 0;
            this.gbManage.TabStop = false;
            this.gbManage.Text = "Manage Shelter";
            this.gbManage.Visible = false;
            this.gbManage.VisibleChanged += new System.EventHandler(this.gbManage_VisibleChanged);
            // 
            // btnSaveShelter
            // 
            this.btnSaveShelter.Location = new System.Drawing.Point(1226, 561);
            this.btnSaveShelter.Name = "btnSaveShelter";
            this.btnSaveShelter.Size = new System.Drawing.Size(145, 30);
            this.btnSaveShelter.TabIndex = 26;
            this.btnSaveShelter.Text = "Save Shelter";
            this.btnSaveShelter.UseVisualStyleBackColor = true;
            this.btnSaveShelter.Click += new System.EventHandler(this.btnSaveShelter_Click);
            // 
            // tbScanRFID
            // 
            this.tbScanRFID.Location = new System.Drawing.Point(845, 166);
            this.tbScanRFID.Name = "tbScanRFID";
            this.tbScanRFID.Size = new System.Drawing.Size(189, 22);
            this.tbScanRFID.TabIndex = 25;
            this.tbScanRFID.Visible = false;
            // 
            // rbScanRFID
            // 
            this.rbScanRFID.AutoSize = true;
            this.rbScanRFID.Location = new System.Drawing.Point(710, 171);
            this.rbScanRFID.Name = "rbScanRFID";
            this.rbScanRFID.Size = new System.Drawing.Size(96, 21);
            this.rbScanRFID.TabIndex = 24;
            this.rbScanRFID.TabStop = true;
            this.rbScanRFID.Text = "Scan RFID";
            this.rbScanRFID.UseVisualStyleBackColor = true;
            this.rbScanRFID.CheckedChanged += new System.EventHandler(this.rbScanRFID_CheckedChanged);
            // 
            // rbAdoptable
            // 
            this.rbAdoptable.AutoSize = true;
            this.rbAdoptable.Location = new System.Drawing.Point(710, 141);
            this.rbAdoptable.Name = "rbAdoptable";
            this.rbAdoptable.Size = new System.Drawing.Size(146, 21);
            this.rbAdoptable.TabIndex = 23;
            this.rbAdoptable.TabStop = true;
            this.rbAdoptable.Text = "Adoptable Animals";
            this.rbAdoptable.UseVisualStyleBackColor = true;
            this.rbAdoptable.CheckedChanged += new System.EventHandler(this.rbAdoptable_CheckedChanged);
            // 
            // rbAnimalsShelter
            // 
            this.rbAnimalsShelter.AutoSize = true;
            this.rbAnimalsShelter.Location = new System.Drawing.Point(710, 114);
            this.rbAnimalsShelter.Name = "rbAnimalsShelter";
            this.rbAnimalsShelter.Size = new System.Drawing.Size(142, 21);
            this.rbAnimalsShelter.TabIndex = 22;
            this.rbAnimalsShelter.TabStop = true;
            this.rbAnimalsShelter.Text = "Animals in Shelter";
            this.rbAnimalsShelter.UseVisualStyleBackColor = true;
            this.rbAnimalsShelter.CheckedChanged += new System.EventHandler(this.rbAnimalsShelter_CheckedChanged);
            // 
            // rbAnimals
            // 
            this.rbAnimals.AutoSize = true;
            this.rbAnimals.Location = new System.Drawing.Point(710, 86);
            this.rbAnimals.Name = "rbAnimals";
            this.rbAnimals.Size = new System.Drawing.Size(78, 21);
            this.rbAnimals.TabIndex = 21;
            this.rbAnimals.TabStop = true;
            this.rbAnimals.Text = "Animals";
            this.rbAnimals.UseVisualStyleBackColor = true;
            this.rbAnimals.CheckedChanged += new System.EventHandler(this.rbAnimals_CheckedChanged);
            // 
            // rbOwners
            // 
            this.rbOwners.AutoSize = true;
            this.rbOwners.Location = new System.Drawing.Point(710, 58);
            this.rbOwners.Name = "rbOwners";
            this.rbOwners.Size = new System.Drawing.Size(77, 21);
            this.rbOwners.TabIndex = 20;
            this.rbOwners.TabStop = true;
            this.rbOwners.Text = "Owners";
            this.rbOwners.UseVisualStyleBackColor = true;
            this.rbOwners.CheckedChanged += new System.EventHandler(this.rbOwners_CheckedChanged);
            // 
            // btnAdopt
            // 
            this.btnAdopt.Enabled = false;
            this.btnAdopt.Location = new System.Drawing.Point(810, 311);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(75, 23);
            this.btnAdopt.TabIndex = 19;
            this.btnAdopt.Text = "Adopt";
            this.btnAdopt.UseVisualStyleBackColor = true;
            this.btnAdopt.Click += new System.EventHandler(this.btnAdopt_Click);
            // 
            // lblSelectedAnimal
            // 
            this.lblSelectedAnimal.AutoSize = true;
            this.lblSelectedAnimal.Location = new System.Drawing.Point(710, 283);
            this.lblSelectedAnimal.Name = "lblSelectedAnimal";
            this.lblSelectedAnimal.Size = new System.Drawing.Size(109, 17);
            this.lblSelectedAnimal.TabIndex = 18;
            this.lblSelectedAnimal.Text = "Selected Animal";
            // 
            // lblSpecificOwner
            // 
            this.lblSpecificOwner.AutoSize = true;
            this.lblSpecificOwner.Location = new System.Drawing.Point(710, 224);
            this.lblSpecificOwner.Name = "lblSpecificOwner";
            this.lblSpecificOwner.Size = new System.Drawing.Size(108, 17);
            this.lblSpecificOwner.TabIndex = 17;
            this.lblSpecificOwner.Text = "Selected Owner";
            // 
            // lblSpecific
            // 
            this.lblSpecific.AutoSize = true;
            this.lblSpecific.Location = new System.Drawing.Point(707, 203);
            this.lblSpecific.Name = "lblSpecific";
            this.lblSpecific.Size = new System.Drawing.Size(197, 17);
            this.lblSpecific.TabIndex = 16;
            this.lblSpecific.Text = "Specific Owner/Animal section";
            // 
            // btnWalk
            // 
            this.btnWalk.Enabled = false;
            this.btnWalk.Location = new System.Drawing.Point(710, 311);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 15;
            this.btnWalk.Text = "Walk Dog";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // btnClaim
            // 
            this.btnClaim.Enabled = false;
            this.btnClaim.Location = new System.Drawing.Point(893, 247);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(75, 29);
            this.btnClaim.TabIndex = 14;
            this.btnClaim.Text = "Claim";
            this.btnClaim.UseVisualStyleBackColor = true;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // lbOut2
            // 
            this.lbOut2.FormattingEnabled = true;
            this.lbOut2.ItemHeight = 16;
            this.lbOut2.Location = new System.Drawing.Point(699, 385);
            this.lbOut2.Name = "lbOut2";
            this.lbOut2.ScrollAlwaysVisible = true;
            this.lbOut2.Size = new System.Drawing.Size(396, 292);
            this.lbOut2.TabIndex = 13;
            this.lbOut2.SelectedIndexChanged += new System.EventHandler(this.lbOut2_SelectedIndexChanged);
            // 
            // btnCheckClaimable
            // 
            this.btnCheckClaimable.Enabled = false;
            this.btnCheckClaimable.Location = new System.Drawing.Point(707, 247);
            this.btnCheckClaimable.Name = "btnCheckClaimable";
            this.btnCheckClaimable.Size = new System.Drawing.Size(180, 29);
            this.btnCheckClaimable.TabIndex = 12;
            this.btnCheckClaimable.Text = "Check Claimable animals";
            this.btnCheckClaimable.UseVisualStyleBackColor = true;
            this.btnCheckClaimable.Click += new System.EventHandler(this.btnCheckClaimable_Click);
            // 
            // gbAddOwner
            // 
            this.gbAddOwner.Controls.Add(this.lblOwnerID);
            this.gbAddOwner.Controls.Add(this.lblOwnerName);
            this.gbAddOwner.Controls.Add(this.tbAddOwnerID);
            this.gbAddOwner.Controls.Add(this.tbAddOwnerName);
            this.gbAddOwner.Controls.Add(this.btnAddOwnerCancel);
            this.gbAddOwner.Controls.Add(this.btnAddOwnerConfirm);
            this.gbAddOwner.Location = new System.Drawing.Point(1136, 94);
            this.gbAddOwner.Name = "gbAddOwner";
            this.gbAddOwner.Size = new System.Drawing.Size(290, 190);
            this.gbAddOwner.TabIndex = 7;
            this.gbAddOwner.TabStop = false;
            this.gbAddOwner.Text = "Add Owner";
            this.gbAddOwner.Visible = false;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(8, 64);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(62, 17);
            this.lblOwnerID.TabIndex = 3;
            this.lblOwnerID.Text = "OwnerID";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(8, 18);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(90, 17);
            this.lblOwnerName.TabIndex = 2;
            this.lblOwnerName.Text = "Owner Name";
            // 
            // tbAddOwnerID
            // 
            this.tbAddOwnerID.Location = new System.Drawing.Point(10, 84);
            this.tbAddOwnerID.Name = "tbAddOwnerID";
            this.tbAddOwnerID.Size = new System.Drawing.Size(261, 22);
            this.tbAddOwnerID.TabIndex = 1;
            // 
            // tbAddOwnerName
            // 
            this.tbAddOwnerName.Location = new System.Drawing.Point(6, 38);
            this.tbAddOwnerName.Name = "tbAddOwnerName";
            this.tbAddOwnerName.Size = new System.Drawing.Size(265, 22);
            this.tbAddOwnerName.TabIndex = 0;
            // 
            // btnAddOwnerCancel
            // 
            this.btnAddOwnerCancel.Location = new System.Drawing.Point(163, 130);
            this.btnAddOwnerCancel.Name = "btnAddOwnerCancel";
            this.btnAddOwnerCancel.Size = new System.Drawing.Size(75, 36);
            this.btnAddOwnerCancel.TabIndex = 3;
            this.btnAddOwnerCancel.Text = "Cancel";
            this.btnAddOwnerCancel.UseVisualStyleBackColor = true;
            this.btnAddOwnerCancel.Click += new System.EventHandler(this.btnAddOwnerCancel_Click);
            // 
            // btnAddOwnerConfirm
            // 
            this.btnAddOwnerConfirm.Location = new System.Drawing.Point(23, 130);
            this.btnAddOwnerConfirm.Name = "btnAddOwnerConfirm";
            this.btnAddOwnerConfirm.Size = new System.Drawing.Size(75, 36);
            this.btnAddOwnerConfirm.TabIndex = 2;
            this.btnAddOwnerConfirm.Text = "Confirm";
            this.btnAddOwnerConfirm.UseVisualStyleBackColor = true;
            this.btnAddOwnerConfirm.Click += new System.EventHandler(this.btnAddOwnerConfirm_Click);
            // 
            // gbAddAnimal
            // 
            this.gbAddAnimal.Controls.Add(this.btnCancelAdd);
            this.gbAddAnimal.Controls.Add(this.btnConfirmAdd);
            this.gbAddAnimal.Controls.Add(this.lblExtraInfo);
            this.gbAddAnimal.Controls.Add(this.tbExtraInfo);
            this.gbAddAnimal.Controls.Add(this.rbCat);
            this.gbAddAnimal.Controls.Add(this.rbDog);
            this.gbAddAnimal.Controls.Add(this.lblRFID);
            this.gbAddAnimal.Controls.Add(this.lblDescription);
            this.gbAddAnimal.Controls.Add(this.lblLocation);
            this.gbAddAnimal.Controls.Add(this.lblDateFound);
            this.gbAddAnimal.Controls.Add(this.tbRFID);
            this.gbAddAnimal.Controls.Add(this.tbAddAnimalDescription);
            this.gbAddAnimal.Controls.Add(this.tbLocation);
            this.gbAddAnimal.Controls.Add(this.dtpFoundDate);
            this.gbAddAnimal.Location = new System.Drawing.Point(1136, 94);
            this.gbAddAnimal.Name = "gbAddAnimal";
            this.gbAddAnimal.Size = new System.Drawing.Size(284, 386);
            this.gbAddAnimal.TabIndex = 6;
            this.gbAddAnimal.TabStop = false;
            this.gbAddAnimal.Text = "Add Animal";
            this.gbAddAnimal.Visible = false;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(141, 326);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(94, 39);
            this.btnCancelAdd.TabIndex = 13;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(11, 326);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(89, 39);
            this.btnConfirmAdd.TabIndex = 12;
            this.btnConfirmAdd.Text = "Confirm";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // lblExtraInfo
            // 
            this.lblExtraInfo.AutoSize = true;
            this.lblExtraInfo.Location = new System.Drawing.Point(100, 264);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(67, 17);
            this.lblExtraInfo.TabIndex = 11;
            this.lblExtraInfo.Text = "Extra Info";
            this.lblExtraInfo.Visible = false;
            // 
            // tbExtraInfo
            // 
            this.tbExtraInfo.Location = new System.Drawing.Point(13, 287);
            this.tbExtraInfo.Name = "tbExtraInfo";
            this.tbExtraInfo.Size = new System.Drawing.Size(264, 22);
            this.tbExtraInfo.TabIndex = 10;
            this.tbExtraInfo.Visible = false;
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(6, 260);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(50, 21);
            this.rbCat.TabIndex = 9;
            this.rbCat.Text = "Cat";
            this.rbCat.UseVisualStyleBackColor = true;
            this.rbCat.CheckedChanged += new System.EventHandler(this.rbCat_CheckedChanged);
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Checked = true;
            this.rbDog.Location = new System.Drawing.Point(6, 232);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(55, 21);
            this.rbDog.TabIndex = 8;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Dog";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(7, 174);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(63, 17);
            this.lblRFID.TabIndex = 7;
            this.lblRFID.Text = "RFID tag";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(7, 78);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(106, 17);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location Found";
            // 
            // lblDateFound
            // 
            this.lblDateFound.AutoSize = true;
            this.lblDateFound.Location = new System.Drawing.Point(22, 24);
            this.lblDateFound.Name = "lblDateFound";
            this.lblDateFound.Size = new System.Drawing.Size(78, 17);
            this.lblDateFound.TabIndex = 4;
            this.lblDateFound.Text = "DateFound";
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(6, 194);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(265, 22);
            this.tbRFID.TabIndex = 3;
            // 
            // tbAddAnimalDescription
            // 
            this.tbAddAnimalDescription.Location = new System.Drawing.Point(6, 145);
            this.tbAddAnimalDescription.Name = "tbAddAnimalDescription";
            this.tbAddAnimalDescription.Size = new System.Drawing.Size(265, 22);
            this.tbAddAnimalDescription.TabIndex = 2;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(6, 98);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(265, 22);
            this.tbLocation.TabIndex = 1;
            // 
            // dtpFoundDate
            // 
            this.dtpFoundDate.Location = new System.Drawing.Point(6, 44);
            this.dtpFoundDate.Name = "dtpFoundDate";
            this.dtpFoundDate.Size = new System.Drawing.Size(265, 22);
            this.dtpFoundDate.TabIndex = 0;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(1142, 45);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(94, 34);
            this.btnAddAnimal.TabIndex = 5;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(1299, 45);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(108, 34);
            this.btnAddOwner.TabIndex = 4;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // lbOut
            // 
            this.lbOut.FormattingEnabled = true;
            this.lbOut.ItemHeight = 16;
            this.lbOut.Location = new System.Drawing.Point(9, 58);
            this.lbOut.Name = "lbOut";
            this.lbOut.ScrollAlwaysVisible = true;
            this.lbOut.Size = new System.Drawing.Size(684, 628);
            this.lbOut.TabIndex = 1;
            this.lbOut.SelectedIndexChanged += new System.EventHandler(this.lbOut_SelectedIndexChanged);
            // 
            // lblDisplayShelterName
            // 
            this.lblDisplayShelterName.AutoSize = true;
            this.lblDisplayShelterName.Location = new System.Drawing.Point(6, 27);
            this.lblDisplayShelterName.Name = "lblDisplayShelterName";
            this.lblDisplayShelterName.Size = new System.Drawing.Size(102, 17);
            this.lblDisplayShelterName.TabIndex = 0;
            this.lblDisplayShelterName.Text = "Current shelter";
            // 
            // gbShelters
            // 
            this.gbShelters.Controls.Add(this.gbShelterDetails);
            this.gbShelters.Controls.Add(this.btnCreateShelter);
            this.gbShelters.Controls.Add(this.btnOpenShelter);
            this.gbShelters.Location = new System.Drawing.Point(12, 12);
            this.gbShelters.Name = "gbShelters";
            this.gbShelters.Size = new System.Drawing.Size(1458, 700);
            this.gbShelters.TabIndex = 1;
            this.gbShelters.TabStop = false;
            this.gbShelters.Text = "Shelters";
            // 
            // gbShelterDetails
            // 
            this.gbShelterDetails.Controls.Add(this.btnCancel);
            this.gbShelterDetails.Controls.Add(this.btnConfirm);
            this.gbShelterDetails.Controls.Add(this.lblShelterAddress);
            this.gbShelterDetails.Controls.Add(this.lblShelterPhone);
            this.gbShelterDetails.Controls.Add(this.lblShelterEmail);
            this.gbShelterDetails.Controls.Add(this.lblShelterName);
            this.gbShelterDetails.Controls.Add(this.tbShelterAddress);
            this.gbShelterDetails.Controls.Add(this.tbShelterPhone);
            this.gbShelterDetails.Controls.Add(this.tbShelterEmail);
            this.gbShelterDetails.Controls.Add(this.tbShelterName);
            this.gbShelterDetails.Location = new System.Drawing.Point(246, 170);
            this.gbShelterDetails.Name = "gbShelterDetails";
            this.gbShelterDetails.Size = new System.Drawing.Size(558, 401);
            this.gbShelterDetails.TabIndex = 2;
            this.gbShelterDetails.TabStop = false;
            this.gbShelterDetails.Text = "Shelter Details";
            this.gbShelterDetails.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(358, 312);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 42);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblShelterAddress
            // 
            this.lblShelterAddress.AutoSize = true;
            this.lblShelterAddress.Location = new System.Drawing.Point(27, 233);
            this.lblShelterAddress.Name = "lblShelterAddress";
            this.lblShelterAddress.Size = new System.Drawing.Size(60, 17);
            this.lblShelterAddress.TabIndex = 7;
            this.lblShelterAddress.Text = "Address";
            // 
            // lblShelterPhone
            // 
            this.lblShelterPhone.AutoSize = true;
            this.lblShelterPhone.Location = new System.Drawing.Point(27, 170);
            this.lblShelterPhone.Name = "lblShelterPhone";
            this.lblShelterPhone.Size = new System.Drawing.Size(49, 17);
            this.lblShelterPhone.TabIndex = 6;
            this.lblShelterPhone.Text = "Phone";
            // 
            // lblShelterEmail
            // 
            this.lblShelterEmail.AutoSize = true;
            this.lblShelterEmail.Location = new System.Drawing.Point(27, 107);
            this.lblShelterEmail.Name = "lblShelterEmail";
            this.lblShelterEmail.Size = new System.Drawing.Size(42, 17);
            this.lblShelterEmail.TabIndex = 5;
            this.lblShelterEmail.Text = "Email";
            // 
            // lblShelterName
            // 
            this.lblShelterName.AutoSize = true;
            this.lblShelterName.Location = new System.Drawing.Point(27, 53);
            this.lblShelterName.Name = "lblShelterName";
            this.lblShelterName.Size = new System.Drawing.Size(45, 17);
            this.lblShelterName.TabIndex = 4;
            this.lblShelterName.Text = "Name";
            // 
            // tbShelterAddress
            // 
            this.tbShelterAddress.Location = new System.Drawing.Point(110, 233);
            this.tbShelterAddress.Name = "tbShelterAddress";
            this.tbShelterAddress.Size = new System.Drawing.Size(427, 22);
            this.tbShelterAddress.TabIndex = 3;
            this.tbShelterAddress.TextChanged += new System.EventHandler(this.tbShelterAddress_TextChanged);
            // 
            // tbShelterPhone
            // 
            this.tbShelterPhone.Location = new System.Drawing.Point(110, 170);
            this.tbShelterPhone.Name = "tbShelterPhone";
            this.tbShelterPhone.Size = new System.Drawing.Size(427, 22);
            this.tbShelterPhone.TabIndex = 2;
            this.tbShelterPhone.TextChanged += new System.EventHandler(this.tbShelterPhone_TextChanged);
            // 
            // tbShelterEmail
            // 
            this.tbShelterEmail.Location = new System.Drawing.Point(110, 107);
            this.tbShelterEmail.Name = "tbShelterEmail";
            this.tbShelterEmail.Size = new System.Drawing.Size(427, 22);
            this.tbShelterEmail.TabIndex = 1;
            this.tbShelterEmail.TextChanged += new System.EventHandler(this.tbShelterEmail_TextChanged);
            // 
            // tbShelterName
            // 
            this.tbShelterName.Location = new System.Drawing.Point(110, 53);
            this.tbShelterName.Name = "tbShelterName";
            this.tbShelterName.Size = new System.Drawing.Size(427, 22);
            this.tbShelterName.TabIndex = 0;
            this.tbShelterName.TextChanged += new System.EventHandler(this.tbShelterName_TextChanged);
            // 
            // btnCreateShelter
            // 
            this.btnCreateShelter.Location = new System.Drawing.Point(592, 58);
            this.btnCreateShelter.Name = "btnCreateShelter";
            this.btnCreateShelter.Size = new System.Drawing.Size(85, 75);
            this.btnCreateShelter.TabIndex = 1;
            this.btnCreateShelter.Text = "Create Shelter";
            this.btnCreateShelter.UseVisualStyleBackColor = true;
            this.btnCreateShelter.Click += new System.EventHandler(this.btnCreateShelter_Click);
            // 
            // btnOpenShelter
            // 
            this.btnOpenShelter.Location = new System.Drawing.Point(336, 58);
            this.btnOpenShelter.Name = "btnOpenShelter";
            this.btnOpenShelter.Size = new System.Drawing.Size(85, 75);
            this.btnOpenShelter.TabIndex = 0;
            this.btnOpenShelter.Text = "Open Shelter";
            this.btnOpenShelter.UseVisualStyleBackColor = true;
            this.btnOpenShelter.Click += new System.EventHandler(this.btnOpenShelter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Shelter Files|*.sh";
            this.openFileDialog1.ShowHelp = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.ShowHelp = true;
            // 
            // frmShelterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 723);
            this.Controls.Add(this.gbManage);
            this.Controls.Add(this.gbShelters);
            this.Name = "frmShelterManager";
            this.Text = "Shelter Manager";
            this.gbManage.ResumeLayout(false);
            this.gbManage.PerformLayout();
            this.gbAddOwner.ResumeLayout(false);
            this.gbAddOwner.PerformLayout();
            this.gbAddAnimal.ResumeLayout(false);
            this.gbAddAnimal.PerformLayout();
            this.gbShelters.ResumeLayout(false);
            this.gbShelterDetails.ResumeLayout(false);
            this.gbShelterDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManage;
        private System.Windows.Forms.GroupBox gbShelters;
        private System.Windows.Forms.Button btnCreateShelter;
        private System.Windows.Forms.Button btnOpenShelter;
        private System.Windows.Forms.GroupBox gbShelterDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblShelterAddress;
        private System.Windows.Forms.Label lblShelterPhone;
        private System.Windows.Forms.Label lblShelterEmail;
        private System.Windows.Forms.Label lblShelterName;
        private System.Windows.Forms.TextBox tbShelterAddress;
        private System.Windows.Forms.TextBox tbShelterPhone;
        private System.Windows.Forms.TextBox tbShelterEmail;
        private System.Windows.Forms.TextBox tbShelterName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDisplayShelterName;
        private System.Windows.Forms.GroupBox gbAddAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnAddOwnerCancel;
        private System.Windows.Forms.Button btnAddOwnerConfirm;
        private System.Windows.Forms.ListBox lbOut;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.DateTimePicker dtpFoundDate;
        private System.Windows.Forms.Label lblDateFound;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.TextBox tbAddAnimalDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.Label lblExtraInfo;
        private System.Windows.Forms.TextBox tbExtraInfo;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.GroupBox gbAddOwner;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox tbAddOwnerID;
        private System.Windows.Forms.TextBox tbAddOwnerName;
        private System.Windows.Forms.Label lblSelectedAnimal;
        private System.Windows.Forms.Label lblSpecificOwner;
        private System.Windows.Forms.Label lblSpecific;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.ListBox lbOut2;
        private System.Windows.Forms.Button btnCheckClaimable;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.RadioButton rbScanRFID;
        private System.Windows.Forms.RadioButton rbAdoptable;
        private System.Windows.Forms.RadioButton rbAnimalsShelter;
        private System.Windows.Forms.RadioButton rbAnimals;
        private System.Windows.Forms.RadioButton rbOwners;
        private System.Windows.Forms.TextBox tbScanRFID;
        private System.Windows.Forms.Button btnSaveShelter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

