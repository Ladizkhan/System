namespace Culinary_File_Management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.txtMinsu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.btnViewrecipe = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSystem = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.pictureBoxAddRecipe = new System.Windows.Forms.PictureBox();
            this.btnAboutme = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dbAddrecipeDataSet = new Culinary_File_Management.dbAddrecipeDataSet();
            this.tblAddrecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAddrecipeTableAdapter = new Culinary_File_Management.dbAddrecipeDataSetTableAdapters.tblAddrecipeTableAdapter();
            this.tableAdapterManager = new Culinary_File_Management.dbAddrecipeDataSetTableAdapters.TableAdapterManager();
            this.dGridViewRecipe = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookTImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAddrecipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddrecipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewRecipe)).BeginInit();
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
            this.headerPanel.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1045, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(773, 63);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(256, 34);
            this.txtSEARCH.TabIndex = 11;
            // 
            // Sidepanel
            // 
            this.Sidepanel.AutoScroll = true;
            this.Sidepanel.BackColor = System.Drawing.Color.Green;
            this.Sidepanel.Controls.Add(this.btnViewrecipe);
            this.Sidepanel.Controls.Add(this.pictureBox3);
            this.Sidepanel.Controls.Add(this.btnSystem);
            this.Sidepanel.Controls.Add(this.pictureBox4);
            this.Sidepanel.Controls.Add(this.btnAddRecipe);
            this.Sidepanel.Controls.Add(this.pictureBoxAddRecipe);
            this.Sidepanel.Controls.Add(this.btnAboutme);
            this.Sidepanel.Controls.Add(this.btnDashboard);
            this.Sidepanel.Controls.Add(this.pictureBox5);
            this.Sidepanel.Controls.Add(this.pictureBox10);
            this.Sidepanel.Controls.Add(this.btnLogout);
            this.Sidepanel.Controls.Add(this.pictureBox8);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 42);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(231, 593);
            this.Sidepanel.TabIndex = 16;
            // 
            // btnViewrecipe
            // 
            this.btnViewrecipe.FlatAppearance.BorderSize = 0;
            this.btnViewrecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewrecipe.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewrecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewrecipe.Location = new System.Drawing.Point(48, 121);
            this.btnViewrecipe.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewrecipe.Name = "btnViewrecipe";
            this.btnViewrecipe.Size = new System.Drawing.Size(129, 48);
            this.btnViewrecipe.TabIndex = 52;
            this.btnViewrecipe.Text = "VIEW YOUR \r\nRECIPE";
            this.btnViewrecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewrecipe.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 125);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // btnSystem
            // 
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystem.Location = new System.Drawing.Point(45, 175);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(185, 38);
            this.btnSystem.TabIndex = 50;
            this.btnSystem.Text = "ABOUT SYSTEM";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.FlatAppearance.BorderSize = 0;
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnAddRecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRecipe.Location = new System.Drawing.Point(51, 70);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(173, 38);
            this.btnAddRecipe.TabIndex = 48;
            this.btnAddRecipe.Text = "ADD RECIPE";
            this.btnAddRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // pictureBoxAddRecipe
            // 
            this.pictureBoxAddRecipe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddRecipe.Image")));
            this.pictureBoxAddRecipe.Location = new System.Drawing.Point(8, 70);
            this.pictureBoxAddRecipe.Name = "pictureBoxAddRecipe";
            this.pictureBoxAddRecipe.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxAddRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddRecipe.TabIndex = 47;
            this.pictureBoxAddRecipe.TabStop = false;
            // 
            // btnAboutme
            // 
            this.btnAboutme.FlatAppearance.BorderSize = 0;
            this.btnAboutme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutme.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnAboutme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAboutme.Location = new System.Drawing.Point(42, 227);
            this.btnAboutme.Margin = new System.Windows.Forms.Padding(0);
            this.btnAboutme.Name = "btnAboutme";
            this.btnAboutme.Size = new System.Drawing.Size(176, 38);
            this.btnAboutme.TabIndex = 45;
            this.btnAboutme.Text = "ABOUT";
            this.btnAboutme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutme.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(51, 16);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(176, 38);
            this.btnDashboard.TabIndex = 44;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(2, 227);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 36);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 41;
            this.pictureBox10.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(41, 523);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 38);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1, 523);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAddrecipeTableAdapter = this.tblAddrecipeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Culinary_File_Management.dbAddrecipeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dGridViewRecipe
            // 
            this.dGridViewRecipe.AllowUserToOrderColumns = true;
            this.dGridViewRecipe.AutoGenerateColumns = false;
            this.dGridViewRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.recipeNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.servingsDataGridViewTextBoxColumn,
            this.prepTimeDataGridViewTextBoxColumn,
            this.cookTImeDataGridViewTextBoxColumn});
            this.dGridViewRecipe.DataSource = this.tblAddrecipeBindingSource;
            this.dGridViewRecipe.Location = new System.Drawing.Point(259, 196);
            this.dGridViewRecipe.Name = "dGridViewRecipe";
            this.dGridViewRecipe.ReadOnly = true;
            this.dGridViewRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewRecipe.Size = new System.Drawing.Size(888, 344);
            this.dGridViewRecipe.TabIndex = 17;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // recipeNameDataGridViewTextBoxColumn
            // 
            this.recipeNameDataGridViewTextBoxColumn.DataPropertyName = "Recipe Name";
            this.recipeNameDataGridViewTextBoxColumn.HeaderText = "Recipe Name";
            this.recipeNameDataGridViewTextBoxColumn.Name = "recipeNameDataGridViewTextBoxColumn";
            this.recipeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 140;
            // 
            // servingsDataGridViewTextBoxColumn
            // 
            this.servingsDataGridViewTextBoxColumn.DataPropertyName = "Servings";
            this.servingsDataGridViewTextBoxColumn.HeaderText = "Servings";
            this.servingsDataGridViewTextBoxColumn.Name = "servingsDataGridViewTextBoxColumn";
            this.servingsDataGridViewTextBoxColumn.ReadOnly = true;
            this.servingsDataGridViewTextBoxColumn.Width = 140;
            // 
            // prepTimeDataGridViewTextBoxColumn
            // 
            this.prepTimeDataGridViewTextBoxColumn.DataPropertyName = "Prep Time";
            this.prepTimeDataGridViewTextBoxColumn.HeaderText = "Prep Time";
            this.prepTimeDataGridViewTextBoxColumn.Name = "prepTimeDataGridViewTextBoxColumn";
            this.prepTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prepTimeDataGridViewTextBoxColumn.Width = 140;
            // 
            // cookTImeDataGridViewTextBoxColumn
            // 
            this.cookTImeDataGridViewTextBoxColumn.DataPropertyName = "Cook TIme";
            this.cookTImeDataGridViewTextBoxColumn.HeaderText = "Cook TIme";
            this.cookTImeDataGridViewTextBoxColumn.Name = "cookTImeDataGridViewTextBoxColumn";
            this.cookTImeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cookTImeDataGridViewTextBoxColumn.Width = 140;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1026, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 635);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dGridViewRecipe);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minsu Culinary System - Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAddrecipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddrecipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtMinsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button btnViewrecipe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.PictureBox pictureBoxAddRecipe;
        private System.Windows.Forms.Button btnAboutme;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox8;
        private dbAddrecipeDataSet dbAddrecipeDataSet;
        private System.Windows.Forms.BindingSource tblAddrecipeBindingSource;
        private dbAddrecipeDataSetTableAdapters.tblAddrecipeTableAdapter tblAddrecipeTableAdapter;
        private dbAddrecipeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dGridViewRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookTImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
    }
}