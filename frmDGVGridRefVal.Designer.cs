namespace Srvtools
{
    partial class frmDGVGridRefVal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDGVGridRefVal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtQry3 = new System.Windows.Forms.TextBox();
            this.lblQry3 = new System.Windows.Forms.Label();
            this.lblQry2 = new System.Windows.Forms.Label();
            this.lblQry1 = new System.Windows.Forms.Label();
            this.txtQry1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtQry2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(9, 108);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 26);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(9, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(9, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtQry3);
            this.panel1.Controls.Add(this.lblQry3);
            this.panel1.Controls.Add(this.lblQry2);
            this.panel1.Controls.Add(this.lblQry1);
            this.panel1.Controls.Add(this.txtQry1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txtQry2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(323, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 420);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // txtQry3
            // 
            this.txtQry3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQry3.Location = new System.Drawing.Point(9, 376);
            this.txtQry3.Name = "txtQry3";
            this.txtQry3.Size = new System.Drawing.Size(75, 22);
            this.txtQry3.TabIndex = 15;
            this.txtQry3.Visible = false;
            this.txtQry3.TextChanged += new System.EventHandler(this.txtQry3_TextChanged);
            this.txtQry3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQry1_KeyDown);
            // 
            // lblQry3
            // 
            this.lblQry3.AutoSize = true;
            this.lblQry3.BackColor = System.Drawing.Color.White;
            this.lblQry3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQry3.Location = new System.Drawing.Point(12, 356);
            this.lblQry3.Name = "lblQry3";
            this.lblQry3.Size = new System.Drawing.Size(33, 13);
            this.lblQry3.TabIndex = 14;
            this.lblQry3.Text = "名稱";
            this.lblQry3.Visible = false;
            // 
            // lblQry2
            // 
            this.lblQry2.AutoSize = true;
            this.lblQry2.BackColor = System.Drawing.Color.White;
            this.lblQry2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQry2.Location = new System.Drawing.Point(12, 305);
            this.lblQry2.Name = "lblQry2";
            this.lblQry2.Size = new System.Drawing.Size(33, 13);
            this.lblQry2.TabIndex = 13;
            this.lblQry2.Text = "名稱";
            this.lblQry2.Visible = false;
            // 
            // lblQry1
            // 
            this.lblQry1.AutoSize = true;
            this.lblQry1.BackColor = System.Drawing.Color.White;
            this.lblQry1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQry1.Location = new System.Drawing.Point(12, 256);
            this.lblQry1.Name = "lblQry1";
            this.lblQry1.Size = new System.Drawing.Size(33, 13);
            this.lblQry1.TabIndex = 12;
            this.lblQry1.Text = "編號";
            this.lblQry1.Visible = false;
            // 
            // txtQry1
            // 
            this.txtQry1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQry1.Location = new System.Drawing.Point(9, 275);
            this.txtQry1.Name = "txtQry1";
            this.txtQry1.Size = new System.Drawing.Size(75, 22);
            this.txtQry1.TabIndex = 11;
            this.txtQry1.Visible = false;
            this.txtQry1.TextChanged += new System.EventHandler(this.txtQry1_TextChanged);
            this.txtQry1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQry1_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Visible = false;
            // 
            // txtQry2
            // 
            this.txtQry2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQry2.Location = new System.Drawing.Point(9, 323);
            this.txtQry2.Name = "txtQry2";
            this.txtQry2.Size = new System.Drawing.Size(75, 22);
            this.txtQry2.TabIndex = 9;
            this.txtQry2.Visible = false;
            this.txtQry2.TextChanged += new System.EventHandler(this.txtQry2_TextChanged);
            this.txtQry2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQry1_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(9, 169);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 420);
            this.panel2.TabIndex = 15;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgView.BackgroundColor = System.Drawing.Color.Linen;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(0, 0);
            this.dgView.MultiSelect = false;
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 25;
            this.dgView.RowTemplate.Height = 23;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(323, 420);
            this.dgView.TabIndex = 1;
            this.dgView.Text = "dataGridView1";
            this.dgView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgView_CellBeginEdit_1);
            this.dgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellDoubleClick);
            this.dgView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgView_DataError);
            this.dgView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgView_KeyDown);
            this.dgView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgView_KeyPress);
            // 
            // frmDGVGridRefVal
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(419, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDGVGridRefVal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDGVGridRefVal_FormClosed);
            this.Load += new System.EventHandler(this.frmDGVGridRefVal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDGVGridRefVal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQry2;
        private System.Windows.Forms.Label lblQry1;
        private System.Windows.Forms.TextBox txtQry1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtQry2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtQry3;
        private System.Windows.Forms.Label lblQry3;
        private System.Windows.Forms.TextBox textBox2;
    }
}