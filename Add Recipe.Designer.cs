namespace Culinary_File_Management
{
    partial class Recipe_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipe_Management));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.txtMinsu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxAddRecipe = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lclIngredients = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblGoodfor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lclCooktime = new System.Windows.Forms.Label();
            this.txtCooktime = new System.Windows.Forms.TextBox();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.txtPreptime = new System.Windows.Forms.TextBox();
            this.lblRecipename = new System.Windows.Forms.Label();
            this.txtRecipename = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBoxAddRecipe = new System.Windows.Forms.PictureBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSystem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewRecipe = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbServings = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAddRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.headerPanel.TabIndex = 1;
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
            // groupBoxAddRecipe
            // 
            this.groupBoxAddRecipe.Controls.Add(this.cmbServings);
            this.groupBoxAddRecipe.Controls.Add(this.label2);
            this.groupBoxAddRecipe.Controls.Add(this.txtName);
            this.groupBoxAddRecipe.Controls.Add(this.cmbCategory);
            this.groupBoxAddRecipe.Controls.Add(this.label1);
            this.groupBoxAddRecipe.Controls.Add(this.textBox5);
            this.groupBoxAddRecipe.Controls.Add(this.lblProcedure);
            this.groupBoxAddRecipe.Controls.Add(this.textBox4);
            this.groupBoxAddRecipe.Controls.Add(this.lclIngredients);
            this.groupBoxAddRecipe.Controls.Add(this.textBox3);
            this.groupBoxAddRecipe.Controls.Add(this.lblGoodfor);
            this.groupBoxAddRecipe.Controls.Add(this.lblCategory);
            this.groupBoxAddRecipe.Controls.Add(this.lclCooktime);
            this.groupBoxAddRecipe.Controls.Add(this.txtCooktime);
            this.groupBoxAddRecipe.Controls.Add(this.lblPrepTime);
            this.groupBoxAddRecipe.Controls.Add(this.txtPreptime);
            this.groupBoxAddRecipe.Controls.Add(this.lblRecipename);
            this.groupBoxAddRecipe.Controls.Add(this.txtRecipename);
            this.groupBoxAddRecipe.Location = new System.Drawing.Point(246, 96);
            this.groupBoxAddRecipe.Name = "groupBoxAddRecipe";
            this.groupBoxAddRecipe.Size = new System.Drawing.Size(752, 515);
            this.groupBoxAddRecipe.TabIndex = 15;
            this.groupBoxAddRecipe.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "NOTES";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.textBox5.Location = new System.Drawing.Point(25, 367);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(699, 132);
            this.textBox5.TabIndex = 14;
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedure.Location = new System.Drawing.Point(404, 160);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(90, 19);
            this.lblProcedure.TabIndex = 13;
            this.lblProcedure.Text = "PROCEDURE";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.textBox4.Location = new System.Drawing.Point(408, 182);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(316, 132);
            this.textBox4.TabIndex = 12;
            // 
            // lclIngredients
            // 
            this.lclIngredients.AutoSize = true;
            this.lclIngredients.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclIngredients.Location = new System.Drawing.Point(21, 160);
            this.lclIngredients.Name = "lclIngredients";
            this.lclIngredients.Size = new System.Drawing.Size(98, 19);
            this.lclIngredients.TabIndex = 11;
            this.lclIngredients.Text = "INGREDIENTS";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.textBox3.Location = new System.Drawing.Point(25, 182);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 132);
            this.textBox3.TabIndex = 10;
            // 
            // lblGoodfor
            // 
            this.lblGoodfor.AutoSize = true;
            this.lblGoodfor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodfor.Location = new System.Drawing.Point(491, 90);
            this.lblGoodfor.Name = "lblGoodfor";
            this.lblGoodfor.Size = new System.Drawing.Size(66, 19);
            this.lblGoodfor.TabIndex = 9;
            this.lblGoodfor.Text = "Servings";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(256, 90);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 19);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lclCooktime
            // 
            this.lclCooktime.AutoSize = true;
            this.lclCooktime.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCooktime.Location = new System.Drawing.Point(21, 91);
            this.lclCooktime.Name = "lclCooktime";
            this.lclCooktime.Size = new System.Drawing.Size(147, 19);
            this.lclCooktime.TabIndex = 5;
            this.lclCooktime.Text = "COOK TIME(minutes)";
            // 
            // txtCooktime
            // 
            this.txtCooktime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtCooktime.Location = new System.Drawing.Point(25, 113);
            this.txtCooktime.Name = "txtCooktime";
            this.txtCooktime.Size = new System.Drawing.Size(229, 28);
            this.txtCooktime.TabIndex = 4;
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepTime.Location = new System.Drawing.Point(491, 26);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(141, 19);
            this.lblPrepTime.TabIndex = 3;
            this.lblPrepTime.Text = "PREP TIME(minutes)";
            // 
            // txtPreptime
            // 
            this.txtPreptime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtPreptime.Location = new System.Drawing.Point(495, 48);
            this.txtPreptime.Name = "txtPreptime";
            this.txtPreptime.Size = new System.Drawing.Size(229, 28);
            this.txtPreptime.TabIndex = 2;
            // 
            // lblRecipename
            // 
            this.lblRecipename.AutoSize = true;
            this.lblRecipename.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipename.Location = new System.Drawing.Point(256, 26);
            this.lblRecipename.Name = "lblRecipename";
            this.lblRecipename.Size = new System.Drawing.Size(99, 19);
            this.lblRecipename.TabIndex = 1;
            this.lblRecipename.Text = "RECIPE NAME";
            // 
            // txtRecipename
            // 
            this.txtRecipename.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtRecipename.Location = new System.Drawing.Point(260, 48);
            this.txtRecipename.Name = "txtRecipename";
            this.txtRecipename.Size = new System.Drawing.Size(229, 28);
            this.txtRecipename.TabIndex = 0;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(3, 247);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 36);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
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
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(43, 247);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(176, 38);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
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
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBoxAddRecipe
            // 
            this.pictureBoxAddRecipe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddRecipe.Image")));
            this.pictureBoxAddRecipe.Location = new System.Drawing.Point(9, 76);
            this.pictureBoxAddRecipe.Name = "pictureBoxAddRecipe";
            this.pictureBoxAddRecipe.Size = new System.Drawing.Size(37, 36);
            this.pictureBoxAddRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddRecipe.TabIndex = 21;
            this.pictureBoxAddRecipe.TabStop = false;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.FlatAppearance.BorderSize = 0;
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnAddRecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRecipe.Location = new System.Drawing.Point(52, 76);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(173, 38);
            this.btnAddRecipe.TabIndex = 22;
            this.btnAddRecipe.Text = "ADD RECIPE";
            this.btnAddRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 195);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btnSystem
            // 
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystem.Location = new System.Drawing.Point(46, 195);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(185, 38);
            this.btnSystem.TabIndex = 24;
            this.btnSystem.Text = "ABOUT SYSTEM";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewRecipe
            // 
            this.btnViewRecipe.FlatAppearance.BorderSize = 0;
            this.btnViewRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRecipe.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewRecipe.Location = new System.Drawing.Point(49, 127);
            this.btnViewRecipe.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewRecipe.Name = "btnViewRecipe";
            this.btnViewRecipe.Size = new System.Drawing.Size(129, 48);
            this.btnViewRecipe.TabIndex = 26;
            this.btnViewRecipe.Text = "VIEW YOUR \r\nRECIPE";
            this.btnViewRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewRecipe.UseVisualStyleBackColor = true;
            this.btnViewRecipe.Click += new System.EventHandler(this.btnViewRecipe_Click);
            // 
            // Sidepanel
            // 
            this.Sidepanel.AutoScroll = true;
            this.Sidepanel.BackColor = System.Drawing.Color.Green;
            this.Sidepanel.Controls.Add(this.btnViewRecipe);
            this.Sidepanel.Controls.Add(this.pictureBox2);
            this.Sidepanel.Controls.Add(this.btnSystem);
            this.Sidepanel.Controls.Add(this.pictureBox3);
            this.Sidepanel.Controls.Add(this.btnAddRecipe);
            this.Sidepanel.Controls.Add(this.pictureBoxAddRecipe);
            this.Sidepanel.Controls.Add(this.btnLogout);
            this.Sidepanel.Controls.Add(this.btnAbout);
            this.Sidepanel.Controls.Add(this.btnDashboard);
            this.Sidepanel.Controls.Add(this.pictureBox5);
            this.Sidepanel.Controls.Add(this.pictureBox4);
            this.Sidepanel.Controls.Add(this.pictureBox10);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 42);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(231, 593);
            this.Sidepanel.TabIndex = 20;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sautéed Dishes (Ginisang Ulam)",
            "Adobo Dishes",
            "Sour Soup Dishes (Sinigang)",
            "Boiled Dishes",
            "Fried Dishes",
            "Grilled Dishes",
            "Stew / Saucy Dishes (May Sarsa)",
            "Vegetable Dishes",
            "Noodle Dishes",
            "Baked Dishes",
            "Cooked Desserts"});
            this.cmbCategory.Location = new System.Drawing.Point(260, 112);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(229, 29);
            this.cmbCategory.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Your Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtName.Location = new System.Drawing.Point(25, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 28);
            this.txtName.TabIndex = 17;
            // 
            // cmbServings
            // 
            this.cmbServings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServings.FormattingEnabled = true;
            this.cmbServings.Items.AddRange(new object[] {
            "1 PERSON",
            "2 PERSON",
            "3 PERSON",
            "4 PERSON",
            "5 PERSON",
            "6 PERSON",
            "7 PERSON",
            "8 PERSON",
            "9 PERSON",
            "10 PERSON"});
            this.cmbServings.Location = new System.Drawing.Point(495, 113);
            this.cmbServings.Name = "cmbServings";
            this.cmbServings.Size = new System.Drawing.Size(229, 29);
            this.cmbServings.TabIndex = 19;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(1027, 559);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 36);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Recipe_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 635);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.groupBoxAddRecipe);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recipe_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe_Management";
            this.Load += new System.EventHandler(this.Recipe_Management_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAddRecipe.ResumeLayout(false);
            this.groupBoxAddRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Sidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label txtMinsu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxAddRecipe;
        private System.Windows.Forms.TextBox txtRecipename;
        private System.Windows.Forms.Label lblRecipename;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.TextBox txtPreptime;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lclCooktime;
        private System.Windows.Forms.TextBox txtCooktime;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lclIngredients;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblGoodfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBoxAddRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewRecipe;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbServings;
        private System.Windows.Forms.Button btnsave;
    }
}