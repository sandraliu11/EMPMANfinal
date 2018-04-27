namespace EmpMan
{
	partial class frmEmpMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpMan));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.btnCreateManager = new System.Windows.Forms.Button();
            this.btnCreateWorker = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.pnlPersonForm = new System.Windows.Forms.Panel();
            this.lblPersonDOB = new System.Windows.Forms.Label();
            this.txtPersonDOB = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlWorkerPanel = new System.Windows.Forms.Panel();
            this.lblWorkerPay = new System.Windows.Forms.Label();
            this.lblWorkerTitle = new System.Windows.Forms.Label();
            this.txtWorkerPay = new System.Windows.Forms.TextBox();
            this.txtWorkerTitle = new System.Windows.Forms.TextBox();
            this.pnlClientForm = new System.Windows.Forms.Panel();
            this.txtClientType = new System.Windows.Forms.TextBox();
            this.lblClientType = new System.Windows.Forms.Label();
            this.pnlManagerForm = new System.Windows.Forms.Panel();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblManagerSalary = new System.Windows.Forms.Label();
            this.lblManagerTitle = new System.Windows.Forms.Label();
            this.txtManagerBonus = new System.Windows.Forms.TextBox();
            this.txtManagerSalary = new System.Windows.Forms.TextBox();
            this.txtManagerTitle = new System.Windows.Forms.TextBox();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.pcbBackFromAddSelectPersonType = new System.Windows.Forms.PictureBox();
            this.pcbBackFromAddDetailView = new System.Windows.Forms.PictureBox();
            this.pcbBackFromSearch = new System.Windows.Forms.PictureBox();
            this.pcbBackFromSearchResults = new System.Windows.Forms.PictureBox();
            this.pcbBackFromEdit = new System.Windows.Forms.PictureBox();
            this.pnlPersonForm.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlWorkerPanel.SuspendLayout();
            this.pnlClientForm.SuspendLayout();
            this.pnlManagerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromAddSelectPersonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromAddDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle.Location = new System.Drawing.Point(61, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Person Manager App";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(95, 126);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(171, 42);
            this.btnAddPerson.TabIndex = 1;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Visible = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(95, 210);
            this.btnSearchPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(171, 42);
            this.btnSearchPerson.TabIndex = 2;
            this.btnSearchPerson.Text = "Search Person";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Visible = false;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnCreateManager
            // 
            this.btnCreateManager.Location = new System.Drawing.Point(95, 295);
            this.btnCreateManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateManager.Name = "btnCreateManager";
            this.btnCreateManager.Size = new System.Drawing.Size(171, 42);
            this.btnCreateManager.TabIndex = 5;
            this.btnCreateManager.Text = "Manager";
            this.btnCreateManager.UseVisualStyleBackColor = true;
            this.btnCreateManager.Visible = false;
            this.btnCreateManager.Click += new System.EventHandler(this.btnCreateManager_Click);
            // 
            // btnCreateWorker
            // 
            this.btnCreateWorker.Location = new System.Drawing.Point(95, 210);
            this.btnCreateWorker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateWorker.Name = "btnCreateWorker";
            this.btnCreateWorker.Size = new System.Drawing.Size(171, 42);
            this.btnCreateWorker.TabIndex = 6;
            this.btnCreateWorker.Text = "Worker";
            this.btnCreateWorker.UseVisualStyleBackColor = true;
            this.btnCreateWorker.Visible = false;
            this.btnCreateWorker.Click += new System.EventHandler(this.btnCreateWorker_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(95, 126);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(171, 42);
            this.btnCreateClient.TabIndex = 7;
            this.btnCreateClient.Text = "Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Visible = false;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // pnlPersonForm
            // 
            this.pnlPersonForm.Controls.Add(this.lblPersonDOB);
            this.pnlPersonForm.Controls.Add(this.txtPersonDOB);
            this.pnlPersonForm.Controls.Add(this.lblPersonName);
            this.pnlPersonForm.Controls.Add(this.txtPersonName);
            this.pnlPersonForm.Controls.Add(this.lblPersonID);
            this.pnlPersonForm.Controls.Add(this.txtPersonID);
            this.pnlPersonForm.Location = new System.Drawing.Point(51, 104);
            this.pnlPersonForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPersonForm.Name = "pnlPersonForm";
            this.pnlPersonForm.Size = new System.Drawing.Size(238, 146);
            this.pnlPersonForm.TabIndex = 8;
            this.pnlPersonForm.Visible = false;
            // 
            // lblPersonDOB
            // 
            this.lblPersonDOB.AutoSize = true;
            this.lblPersonDOB.Location = new System.Drawing.Point(6, 104);
            this.lblPersonDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonDOB.Name = "lblPersonDOB";
            this.lblPersonDOB.Size = new System.Drawing.Size(97, 25);
            this.lblPersonDOB.TabIndex = 5;
            this.lblPersonDOB.Text = "Birth Date";
            // 
            // txtPersonDOB
            // 
            this.txtPersonDOB.Location = new System.Drawing.Point(112, 104);
            this.txtPersonDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonDOB.Name = "txtPersonDOB";
            this.txtPersonDOB.Size = new System.Drawing.Size(121, 29);
            this.txtPersonDOB.TabIndex = 4;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(39, 55);
            this.lblPersonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(64, 25);
            this.lblPersonName.TabIndex = 3;
            this.lblPersonName.Text = "Name";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(112, 55);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(121, 29);
            this.txtPersonName.TabIndex = 2;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(68, 11);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(31, 25);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "ID";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(112, 7);
            this.txtPersonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(121, 29);
            this.txtPersonID.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(59, 104);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(233, 120);
            this.pnlSearch.TabIndex = 12;
            this.pnlSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(42, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 42);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(4, 11);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(82, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter ID";
            // 
            // pnlWorkerPanel
            // 
            this.pnlWorkerPanel.Controls.Add(this.lblWorkerPay);
            this.pnlWorkerPanel.Controls.Add(this.lblWorkerTitle);
            this.pnlWorkerPanel.Controls.Add(this.txtWorkerPay);
            this.pnlWorkerPanel.Controls.Add(this.txtWorkerTitle);
            this.pnlWorkerPanel.Location = new System.Drawing.Point(39, 254);
            this.pnlWorkerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlWorkerPanel.Name = "pnlWorkerPanel";
            this.pnlWorkerPanel.Size = new System.Drawing.Size(251, 104);
            this.pnlWorkerPanel.TabIndex = 9;
            this.pnlWorkerPanel.Visible = false;
            // 
            // lblWorkerPay
            // 
            this.lblWorkerPay.AutoSize = true;
            this.lblWorkerPay.Location = new System.Drawing.Point(9, 55);
            this.lblWorkerPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkerPay.Name = "lblWorkerPay";
            this.lblWorkerPay.Size = new System.Drawing.Size(107, 25);
            this.lblWorkerPay.TabIndex = 3;
            this.lblWorkerPay.Text = "Hourly Pay";
            // 
            // lblWorkerTitle
            // 
            this.lblWorkerTitle.AutoSize = true;
            this.lblWorkerTitle.Location = new System.Drawing.Point(66, 14);
            this.lblWorkerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkerTitle.Name = "lblWorkerTitle";
            this.lblWorkerTitle.Size = new System.Drawing.Size(49, 25);
            this.lblWorkerTitle.TabIndex = 2;
            this.lblWorkerTitle.Text = "Title";
            // 
            // txtWorkerPay
            // 
            this.txtWorkerPay.Location = new System.Drawing.Point(125, 55);
            this.txtWorkerPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkerPay.Name = "txtWorkerPay";
            this.txtWorkerPay.Size = new System.Drawing.Size(121, 29);
            this.txtWorkerPay.TabIndex = 1;
            // 
            // txtWorkerTitle
            // 
            this.txtWorkerTitle.Location = new System.Drawing.Point(125, 7);
            this.txtWorkerTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkerTitle.Name = "txtWorkerTitle";
            this.txtWorkerTitle.Size = new System.Drawing.Size(121, 29);
            this.txtWorkerTitle.TabIndex = 0;
            // 
            // pnlClientForm
            // 
            this.pnlClientForm.Controls.Add(this.txtClientType);
            this.pnlClientForm.Controls.Add(this.lblClientType);
            this.pnlClientForm.Location = new System.Drawing.Point(51, 258);
            this.pnlClientForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClientForm.Name = "pnlClientForm";
            this.pnlClientForm.Size = new System.Drawing.Size(238, 46);
            this.pnlClientForm.TabIndex = 11;
            this.pnlClientForm.Visible = false;
            // 
            // txtClientType
            // 
            this.txtClientType.Location = new System.Drawing.Point(112, 6);
            this.txtClientType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientType.Name = "txtClientType";
            this.txtClientType.Size = new System.Drawing.Size(121, 29);
            this.txtClientType.TabIndex = 1;
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Location = new System.Drawing.Point(48, 8);
            this.lblClientType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(57, 25);
            this.lblClientType.TabIndex = 0;
            this.lblClientType.Text = "Type";
            // 
            // pnlManagerForm
            // 
            this.pnlManagerForm.Controls.Add(this.lblBonus);
            this.pnlManagerForm.Controls.Add(this.lblManagerSalary);
            this.pnlManagerForm.Controls.Add(this.lblManagerTitle);
            this.pnlManagerForm.Controls.Add(this.txtManagerBonus);
            this.pnlManagerForm.Controls.Add(this.txtManagerSalary);
            this.pnlManagerForm.Controls.Add(this.txtManagerTitle);
            this.pnlManagerForm.Location = new System.Drawing.Point(51, 253);
            this.pnlManagerForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlManagerForm.Name = "pnlManagerForm";
            this.pnlManagerForm.Size = new System.Drawing.Size(238, 146);
            this.pnlManagerForm.TabIndex = 10;
            this.pnlManagerForm.Visible = false;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(33, 104);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(68, 25);
            this.lblBonus.TabIndex = 5;
            this.lblBonus.Text = "Bonus";
            // 
            // lblManagerSalary
            // 
            this.lblManagerSalary.AutoSize = true;
            this.lblManagerSalary.Location = new System.Drawing.Point(35, 59);
            this.lblManagerSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerSalary.Name = "lblManagerSalary";
            this.lblManagerSalary.Size = new System.Drawing.Size(68, 25);
            this.lblManagerSalary.TabIndex = 4;
            this.lblManagerSalary.Text = "Salary";
            // 
            // lblManagerTitle
            // 
            this.lblManagerTitle.AutoSize = true;
            this.lblManagerTitle.Location = new System.Drawing.Point(53, 11);
            this.lblManagerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerTitle.Name = "lblManagerTitle";
            this.lblManagerTitle.Size = new System.Drawing.Size(49, 25);
            this.lblManagerTitle.TabIndex = 3;
            this.lblManagerTitle.Text = "Title";
            // 
            // txtManagerBonus
            // 
            this.txtManagerBonus.Location = new System.Drawing.Point(112, 104);
            this.txtManagerBonus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManagerBonus.Name = "txtManagerBonus";
            this.txtManagerBonus.Size = new System.Drawing.Size(121, 29);
            this.txtManagerBonus.TabIndex = 2;
            // 
            // txtManagerSalary
            // 
            this.txtManagerSalary.Location = new System.Drawing.Point(112, 56);
            this.txtManagerSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManagerSalary.Name = "txtManagerSalary";
            this.txtManagerSalary.Size = new System.Drawing.Size(121, 29);
            this.txtManagerSalary.TabIndex = 1;
            // 
            // txtManagerTitle
            // 
            this.txtManagerTitle.Location = new System.Drawing.Point(112, 7);
            this.txtManagerTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManagerTitle.Name = "txtManagerTitle";
            this.txtManagerTitle.Size = new System.Drawing.Size(121, 29);
            this.txtManagerTitle.TabIndex = 0;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(210, 426);
            this.btnAddSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(145, 42);
            this.btnAddSave.TabIndex = 11;
            this.btnAddSave.Text = "Add & Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Visible = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(210, 426);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 42);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "btnDelete";
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDelete.Location = new System.Drawing.Point(20, 425);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 42);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(210, 426);
            this.btnEditSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(145, 42);
            this.btnEditSave.TabIndex = 16;
            this.btnEditSave.Text = "Edit & Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Visible = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // pcbBackFromAddSelectPersonType
            // 
            this.pcbBackFromAddSelectPersonType.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackFromAddSelectPersonType.Image")));
            this.pcbBackFromAddSelectPersonType.Location = new System.Drawing.Point(20, 41);
            this.pcbBackFromAddSelectPersonType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbBackFromAddSelectPersonType.Name = "pcbBackFromAddSelectPersonType";
            this.pcbBackFromAddSelectPersonType.Size = new System.Drawing.Size(28, 31);
            this.pcbBackFromAddSelectPersonType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackFromAddSelectPersonType.TabIndex = 17;
            this.pcbBackFromAddSelectPersonType.TabStop = false;
            this.pcbBackFromAddSelectPersonType.Visible = false;
            this.pcbBackFromAddSelectPersonType.Click += new System.EventHandler(this.pcbBackFromAddSelectPersonType_Click);
            // 
            // pcbBackFromAddDetailView
            // 
            this.pcbBackFromAddDetailView.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackFromAddDetailView.Image")));
            this.pcbBackFromAddDetailView.Location = new System.Drawing.Point(20, 41);
            this.pcbBackFromAddDetailView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbBackFromAddDetailView.Name = "pcbBackFromAddDetailView";
            this.pcbBackFromAddDetailView.Size = new System.Drawing.Size(28, 31);
            this.pcbBackFromAddDetailView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackFromAddDetailView.TabIndex = 18;
            this.pcbBackFromAddDetailView.TabStop = false;
            this.pcbBackFromAddDetailView.Visible = false;
            this.pcbBackFromAddDetailView.Click += new System.EventHandler(this.pcbBackFromAddDetailView_Click);
            // 
            // pcbBackFromSearch
            // 
            this.pcbBackFromSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackFromSearch.Image")));
            this.pcbBackFromSearch.Location = new System.Drawing.Point(20, 41);
            this.pcbBackFromSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbBackFromSearch.Name = "pcbBackFromSearch";
            this.pcbBackFromSearch.Size = new System.Drawing.Size(28, 31);
            this.pcbBackFromSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackFromSearch.TabIndex = 19;
            this.pcbBackFromSearch.TabStop = false;
            this.pcbBackFromSearch.Visible = false;
            this.pcbBackFromSearch.Click += new System.EventHandler(this.pcbBackFromSearch_Click);
            // 
            // pcbBackFromSearchResults
            // 
            this.pcbBackFromSearchResults.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackFromSearchResults.Image")));
            this.pcbBackFromSearchResults.Location = new System.Drawing.Point(20, 41);
            this.pcbBackFromSearchResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbBackFromSearchResults.Name = "pcbBackFromSearchResults";
            this.pcbBackFromSearchResults.Size = new System.Drawing.Size(28, 31);
            this.pcbBackFromSearchResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackFromSearchResults.TabIndex = 20;
            this.pcbBackFromSearchResults.TabStop = false;
            this.pcbBackFromSearchResults.Visible = false;
            this.pcbBackFromSearchResults.Click += new System.EventHandler(this.pcbBackFromSearchResults_Click);
            // 
            // pcbBackFromEdit
            // 
            this.pcbBackFromEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackFromEdit.Image")));
            this.pcbBackFromEdit.Location = new System.Drawing.Point(20, 41);
            this.pcbBackFromEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbBackFromEdit.Name = "pcbBackFromEdit";
            this.pcbBackFromEdit.Size = new System.Drawing.Size(28, 31);
            this.pcbBackFromEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackFromEdit.TabIndex = 21;
            this.pcbBackFromEdit.TabStop = false;
            this.pcbBackFromEdit.Visible = false;
            this.pcbBackFromEdit.Click += new System.EventHandler(this.pcbBackFromEdit_Click);
            // 
            // frmEmpMan
            // 
            this.AccessibleName = "btnDelete";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 497);
            this.Controls.Add(this.pnlManagerForm);
            this.Controls.Add(this.pcbBackFromEdit);
            this.Controls.Add(this.pcbBackFromSearchResults);
            this.Controls.Add(this.pcbBackFromSearch);
            this.Controls.Add(this.pnlPersonForm);
            this.Controls.Add(this.pcbBackFromAddDetailView);
            this.Controls.Add(this.pcbBackFromAddSelectPersonType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlClientForm);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.pnlWorkerPanel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnCreateWorker);
            this.Controls.Add(this.btnCreateManager);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.btnEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmpMan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpMan_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPersonForm.ResumeLayout(false);
            this.pnlPersonForm.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlWorkerPanel.ResumeLayout(false);
            this.pnlWorkerPanel.PerformLayout();
            this.pnlClientForm.ResumeLayout(false);
            this.pnlClientForm.PerformLayout();
            this.pnlManagerForm.ResumeLayout(false);
            this.pnlManagerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromAddSelectPersonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromAddDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackFromEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnAddPerson;
        public System.Windows.Forms.Button btnSearchPerson;
        public System.Windows.Forms.Button btnCreateManager;
        public System.Windows.Forms.Button btnCreateWorker;
        public System.Windows.Forms.Button btnCreateClient;
        public System.Windows.Forms.Panel pnlPersonForm;
        public System.Windows.Forms.Panel pnlWorkerPanel;
        public System.Windows.Forms.Panel pnlManagerForm;
        public System.Windows.Forms.Panel pnlClientForm;
        public System.Windows.Forms.Label lblPersonDOB;
        public System.Windows.Forms.TextBox txtPersonDOB;
        public System.Windows.Forms.Label lblPersonName;
        public System.Windows.Forms.TextBox txtPersonName;
        public System.Windows.Forms.Label lblPersonID;
        public System.Windows.Forms.TextBox txtPersonID;
        public System.Windows.Forms.TextBox txtClientType;
        public System.Windows.Forms.Label lblClientType;
        public System.Windows.Forms.Label lblWorkerPay;
        public System.Windows.Forms.Label lblWorkerTitle;
        public System.Windows.Forms.TextBox txtWorkerPay;
        public System.Windows.Forms.TextBox txtWorkerTitle;
        public System.Windows.Forms.Label lblBonus;
        public System.Windows.Forms.Label lblManagerSalary;
        public System.Windows.Forms.Label lblManagerTitle;
        public System.Windows.Forms.TextBox txtManagerBonus;
        public System.Windows.Forms.TextBox txtManagerSalary;
        public System.Windows.Forms.TextBox txtManagerTitle;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.Panel pnlSearch;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEditSave;
        public System.Windows.Forms.PictureBox pcbBackFromAddSelectPersonType;
        public System.Windows.Forms.PictureBox pcbBackFromAddDetailView;
        public System.Windows.Forms.PictureBox pcbBackFromSearch;
        public System.Windows.Forms.PictureBox pcbBackFromSearchResults;
        public System.Windows.Forms.PictureBox pcbBackFromEdit;
    }
}

