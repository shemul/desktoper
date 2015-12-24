namespace WinForms
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.photoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.btnSetas = new MetroFramework.Controls.MetroButton();
            this.workspace = new MetroFramework.Controls.MetroTextBox();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.isBlue = new MetroFramework.Controls.MetroCheckBox();
            this.isCredit = new MetroFramework.Controls.MetroCheckBox();
            this.wallpaperStyle = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.photoIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 209);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // photoIdDataGridViewTextBoxColumn
            // 
            this.photoIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.photoIdDataGridViewTextBoxColumn.DataPropertyName = "PhotoId";
            this.photoIdDataGridViewTextBoxColumn.HeaderText = "PhotoId";
            this.photoIdDataGridViewTextBoxColumn.Name = "photoIdDataGridViewTextBoxColumn";
            this.photoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.photoIdDataGridViewTextBoxColumn.Width = 69;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 63;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerNameDataGridViewTextBoxColumn.Width = 91;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(FlickrNet.PhotoCollection);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.bindingSource1, "ThumbnailUrl", true));
            this.pictureBox1.Location = new System.Drawing.Point(448, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Title", true));
            this.textBox2.Location = new System.Drawing.Point(88, 352);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Description", true));
            this.textBox3.Location = new System.Drawing.Point(89, 378);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(329, 52);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "LargeWidth", true));
            this.textBox4.Location = new System.Drawing.Point(89, 436);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(228, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image Size";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "LargeUrl", true));
            this.textBox5.Location = new System.Drawing.Point(88, 491);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(228, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Highlight = true;
            this.button1.Location = new System.Drawing.Point(315, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.Style = MetroFramework.MetroColorStyle.Green;
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetas
            // 
            this.btnSetas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSetas.Location = new System.Drawing.Point(458, 76);
            this.btnSetas.Name = "btnSetas";
            this.btnSetas.Size = new System.Drawing.Size(132, 35);
            this.btnSetas.TabIndex = 12;
            this.btnSetas.Text = "Set as wallaper";
            this.btnSetas.UseSelectable = true;
            this.btnSetas.Click += new System.EventHandler(this.btnSetas_Click);
            // 
            // workspace
            // 
            this.workspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.workspace.CustomButton.Image = null;
            this.workspace.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.workspace.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.workspace.CustomButton.Name = "";
            this.workspace.CustomButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workspace.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.workspace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.workspace.CustomButton.TabIndex = 1;
            this.workspace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.workspace.CustomButton.UseSelectable = true;
            this.workspace.CustomButton.Visible = false;
            this.workspace.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.workspace.Lines = new string[] {
        "winter"};
            this.workspace.Location = new System.Drawing.Point(23, 76);
            this.workspace.MaxLength = 32767;
            this.workspace.Name = "workspace";
            this.workspace.PasswordChar = '\0';
            this.workspace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.workspace.SelectedText = "";
            this.workspace.SelectionLength = 0;
            this.workspace.SelectionStart = 0;
            this.workspace.Size = new System.Drawing.Size(272, 35);
            this.workspace.Style = MetroFramework.MetroColorStyle.Green;
            this.workspace.TabIndex = 14;
            this.workspace.Text = "winter";
            this.workspace.UseSelectable = true;
            this.workspace.UseStyleColors = true;
            this.workspace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.workspace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(-14, 538);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(629, 10);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.progressBar.TabIndex = 15;
            this.progressBar.UseCustomBackColor = true;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "OwnerName", true));
            this.txtOwnerName.Location = new System.Drawing.Point(89, 462);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.ReadOnly = true;
            this.txtOwnerName.Size = new System.Drawing.Size(228, 20);
            this.txtOwnerName.TabIndex = 4;
            this.txtOwnerName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Owner";
            this.label1.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Image Size";
            // 
            // isBlue
            // 
            this.isBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.isBlue.AutoSize = true;
            this.isBlue.Location = new System.Drawing.Point(335, 440);
            this.isBlue.Name = "isBlue";
            this.isBlue.Size = new System.Drawing.Size(44, 15);
            this.isBlue.Style = MetroFramework.MetroColorStyle.Green;
            this.isBlue.TabIndex = 18;
            this.isBlue.Text = "Blur";
            this.isBlue.UseCustomBackColor = true;
            this.isBlue.UseCustomForeColor = true;
            this.isBlue.UseSelectable = true;
            this.isBlue.UseStyleColors = true;
            this.isBlue.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // isCredit
            // 
            this.isCredit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.isCredit.AutoSize = true;
            this.isCredit.Location = new System.Drawing.Point(335, 462);
            this.isCredit.Name = "isCredit";
            this.isCredit.Size = new System.Drawing.Size(55, 15);
            this.isCredit.Style = MetroFramework.MetroColorStyle.Green;
            this.isCredit.TabIndex = 19;
            this.isCredit.Text = "Credit";
            this.isCredit.UseCustomBackColor = true;
            this.isCredit.UseCustomForeColor = true;
            this.isCredit.UseSelectable = true;
            this.isCredit.UseStyleColors = true;
            // 
            // wallpaperStyle
            // 
            this.wallpaperStyle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wallpaperStyle.FormattingEnabled = true;
            this.wallpaperStyle.ItemHeight = 23;
            this.wallpaperStyle.Items.AddRange(new object[] {
            "Fill",
            "Center",
            "Stretch",
            "Fit",
            "Tile"});
            this.wallpaperStyle.Location = new System.Drawing.Point(335, 489);
            this.wallpaperStyle.Name = "wallpaperStyle";
            this.wallpaperStyle.Size = new System.Drawing.Size(106, 29);
            this.wallpaperStyle.Style = MetroFramework.MetroColorStyle.Green;
            this.wallpaperStyle.TabIndex = 20;
            this.wallpaperStyle.UseSelectable = true;
            this.wallpaperStyle.UseStyleColors = true;
            this.wallpaperStyle.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(613, 543);
            this.Controls.Add(this.wallpaperStyle);
            this.Controls.Add(this.isCredit);
            this.Controls.Add(this.isBlue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.workspace);
            this.Controls.Add(this.btnSetas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Desktoper";
            this.Load += new System.EventHandler(this.PhotoSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox5;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton btnSetas;
        private MetroFramework.Controls.MetroTextBox workspace;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroCheckBox isBlue;
        private MetroFramework.Controls.MetroCheckBox isCredit;
        private MetroFramework.Controls.MetroComboBox wallpaperStyle;
       
       
    }
}