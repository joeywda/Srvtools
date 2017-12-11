﻿namespace Srvtools
{
    partial class frmAccessControlForUser
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMenuID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.infoDataGridView1 = new Srvtools.InfoDataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEnabled = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridVisible = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AllowAdd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AllowUpdate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AllowDelete = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AllowPrint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(550, 15);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 12);
            this.labelUserName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Name:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(411, 15);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(0, 12);
            this.labelUserID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "User ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(614, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(431, 363);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(33, 363);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 10;
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Menu ID:";
            // 
            // lblMenuID
            // 
            this.lblMenuID.AutoSize = true;
            this.lblMenuID.Location = new System.Drawing.Point(116, 15);
            this.lblMenuID.Name = "lblMenuID";
            this.lblMenuID.Size = new System.Drawing.Size(0, 12);
            this.lblMenuID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "MenuName:";
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Location = new System.Drawing.Point(232, 15);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(0, 12);
            this.lblMenuName.TabIndex = 22;
            // 
            // infoDataGridView1
            // 
            this.infoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.Menu_ID,
            this.ControlName,
            this.Description,
            this.Type,
            this.gridEnabled,
            this.gridVisible,
            this.AllowAdd,
            this.AllowUpdate,
            this.AllowDelete,
            this.AllowPrint});
            this.infoDataGridView1.EnterEnable = true;
            this.infoDataGridView1.EnterRefValControl = false;
            this.infoDataGridView1.Location = new System.Drawing.Point(13, 41);
            this.infoDataGridView1.Name = "infoDataGridView1";
            this.infoDataGridView1.RowTemplate.Height = 23;
            this.infoDataGridView1.Size = new System.Drawing.Size(693, 301);
            this.infoDataGridView1.SureDelete = false;
            this.infoDataGridView1.TabIndex = 14;
            this.infoDataGridView1.TotalActive = false;
            this.infoDataGridView1.TotalBackColor = System.Drawing.SystemColors.Info;
            this.infoDataGridView1.TotalCaption = null;
            this.infoDataGridView1.TotalCaptionFont = new System.Drawing.Font("SimSun", 9F);
            this.infoDataGridView1.TotalFont = new System.Drawing.Font("SimSun", 9F);
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "UserID";
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            this.User_ID.Visible = false;
            this.User_ID.Width = 50;
            // 
            // Menu_ID
            // 
            this.Menu_ID.HeaderText = "MenuID";
            this.Menu_ID.Name = "Menu_ID";
            this.Menu_ID.ReadOnly = true;
            this.Menu_ID.Visible = false;
            this.Menu_ID.Width = 50;
            // 
            // ControlName
            // 
            this.ControlName.HeaderText = "ControlName";
            this.ControlName.Name = "ControlName";
            this.ControlName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 110;
            // 
            // gridEnabled
            // 
            this.gridEnabled.HeaderText = "Enabled";
            this.gridEnabled.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.gridEnabled.Name = "gridEnabled";
            this.gridEnabled.Width = 75;
            // 
            // gridVisible
            // 
            this.gridVisible.HeaderText = "Visible";
            this.gridVisible.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.gridVisible.Name = "gridVisible";
            this.gridVisible.Width = 75;
            // 
            // AllowAdd
            // 
            this.AllowAdd.HeaderText = "AllowAdd";
            this.AllowAdd.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.AllowAdd.Name = "AllowAdd";
            this.AllowAdd.Width = 75;
            // 
            // AllowUpdate
            // 
            this.AllowUpdate.HeaderText = "AllowUpdate";
            this.AllowUpdate.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.AllowUpdate.Name = "AllowUpdate";
            this.AllowUpdate.Width = 75;
            // 
            // AllowDelete
            // 
            this.AllowDelete.HeaderText = "AllowDelete";
            this.AllowDelete.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.AllowDelete.Name = "AllowDelete";
            this.AllowDelete.Width = 75;
            // 
            // AllowPrint
            // 
            this.AllowPrint.HeaderText = "AllowPrint";
            this.AllowPrint.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.AllowPrint.Name = "AllowPrint";
            this.AllowPrint.Width = 75;
            // 
            // frmAccessControlForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 403);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMenuID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoDataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddAll);
            this.Name = "frmAccessControlForUser";
            this.Text = "frmAccessControlForUser";
            this.Load += new System.EventHandler(this.frmAccessControlForUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label label1;
        private InfoDataGridView infoDataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMenuID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridEnabled;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridVisible;
        private System.Windows.Forms.DataGridViewComboBoxColumn AllowAdd;
        private System.Windows.Forms.DataGridViewComboBoxColumn AllowUpdate;
        private System.Windows.Forms.DataGridViewComboBoxColumn AllowDelete;
        private System.Windows.Forms.DataGridViewComboBoxColumn AllowPrint;
    }
}