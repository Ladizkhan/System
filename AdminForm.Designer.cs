namespace Culinary_File_Management
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.txtMinsu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtwelcome = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.tblLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tblLoginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbAddrecipeDataSet = new Culinary_File_Management.dbAddrecipeDataSet();
            this.tblAddrecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAddrecipeTableAdapter = new Culinary_File_Management.dbAddrecipeDataSetTableAdapters.tblAddrecipeTableAdapter();
            this.dbLoginDataSet = new Culinary_File_Management.dbLoginDataSet();
            this.tblLoginBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblLoginTableAdapter = new Culinary_File_Management.dbLoginDataSetTableAdapters.tblLoginTableAdapter();
            this.dGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAddrecipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddrecipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.Sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.headerPanel.Controls.Add(this.txtMinsu);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1159, 42);
            this.headerPanel.TabIndex = 5;
            // 
            // txtMinsu
            // 
            this.txtMinsu.AutoSize = true;
            this.txtMinsu.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinsu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMinsu.Location = new System.Drawing.Point(55, 9);
            this.txtMinsu.Name = "txtMinsu";
            this.txtMinsu.Size = new System.Drawing.Size(320, 27);
            this.txtMinsu.TabIndex = 4;
            this.txtMinsu.Text = "Mindo State University (Minsu)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtwelcome
            // 
            this.txtwelcome.AutoSize = true;
            this.txtwelcome.BackColor = System.Drawing.SystemColors.Control;
            this.txtwelcome.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.txtwelcome.Location = new System.Drawing.Point(910, 45);
            this.txtwelcome.Name = "txtwelcome";
            this.txtwelcome.Size = new System.Drawing.Size(237, 31);
            this.txtwelcome.TabIndex = 7;
            this.txtwelcome.Text = "Welcome Admin";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(754, 104);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(256, 34);
            this.txtSEARCH.TabIndex = 8;
            // 
            // txtAdmin
            // 
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdmin.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.txtAdmin.Location = new System.Drawing.Point(237, 60);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(564, 36);
            this.txtAdmin.TabIndex = 9;
            this.txtAdmin.Text = "USER ADMINISTRATION MODUL";
            // 
            // tblLoginBindingSource
            // 
            this.tblLoginBindingSource.DataMember = "tblLogin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1026, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tblLoginBindingSource1
            // 
            this.tblLoginBindingSource1.DataMember = "tblLogin";
            // 
            // dbAddrecipeDataSet
            // 
            this.dbAddrecipeDataSet.DataSetName = "dbAddrecipeDataSet";
            this.dbAddrecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAddrecipeBindingSource
            // 
            this.tblAddrecipeBindingSource.DataMember = "tblAddrecipe";
            this.tblAddrecipeBindingSource.DataSource = this.dbAddrecipeDataSet;
            // 
            // tblAddrecipeTableAdapter
            // 
            this.tblAddrecipeTableAdapter.ClearBeforeFill = true;
            // 
            // dbLoginDataSet
            // 
            this.dbLoginDataSet.DataSetName = "dbLoginDataSet";
            this.dbLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLoginBindingSource2
            // 
            this.tblLoginBindingSource2.DataMember = "tblLogin";
            this.tblLoginBindingSource2.DataSource = this.dbLoginDataSet;
            // 
            // tblLoginTableAdapter
            // 
            this.tblLoginTableAdapter.ClearBeforeFill = true;
            // 
            // dGridViewAdmin
            // 
            this.dGridViewAdmin.AllowUserToOrderColumns = true;
            this.dGridViewAdmin.AutoGenerateColumns = false;
            this.dGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dGridViewAdmin.DataSource = this.tblLoginBindingSource2;
            this.dGridViewAdmin.Location = new System.Drawing.Point(292, 172);
            this.dGridViewAdmin.Name = "dGridViewAdmin";
            this.dGridViewAdmin.ReadOnly = true;
            this.dGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewAdmin.Size = new System.Drawing.Size(823, 397);
            this.dGridViewAdmin.TabIndex = 15;
            this.dGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewAdmin_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn3.HeaderText = "Role";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 533);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 66);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(52, 22);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(176, 38);
            this.btnDashboard.TabIndex = 17;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Location = new System.Drawing.Point(43, 66);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(173, 38);
            this.btnAdmin.TabIndex = 19;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(43, 533);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 38);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // Sidepanel
            // 
            this.Sidepanel.AutoScroll = true;
            this.Sidepanel.BackColor = System.Drawing.Color.Green;
            this.Sidepanel.Controls.Add(this.btnLogout);
            this.Sidepanel.Controls.Add(this.btnAdmin);
            this.Sidepanel.Controls.Add(this.btnDashboard);
            this.Sidepanel.Controls.Add(this.pictureBox6);
            this.Sidepanel.Controls.Add(this.pictureBox5);
            this.Sidepanel.Controls.Add(this.pictureBox4);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 42);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(231, 593);
            this.Sidepanel.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1007, 587);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 635);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dGridViewAdmin);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.txtwelcome);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minsu Culinary System - Admin Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAddrecipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddrecipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.Sidepanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label txtMinsu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtwelcome;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Label txtAdmin;
        private System.Windows.Forms.BindingSource tblLoginBindingSource;
     
        private System.Windows.Forms.Button button1;
       
        private System.Windows.Forms.BindingSource tblLoginBindingSource1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private dbAddrecipeDataSet dbAddrecipeDataSet;
        private System.Windows.Forms.BindingSource tblAddrecipeBindingSource;
        private dbAddrecipeDataSetTableAdapters.tblAddrecipeTableAdapter tblAddrecipeTableAdapter;
        private dbLoginDataSet dbLoginDataSet;
        private System.Windows.Forms.BindingSource tblLoginBindingSource2;
        private dbLoginDataSetTableAdapters.tblLoginTableAdapter tblLoginTableAdapter;
        private System.Windows.Forms.DataGridView dGridViewAdmin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnDelete;
    }
}