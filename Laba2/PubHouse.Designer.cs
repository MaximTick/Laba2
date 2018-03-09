namespace Laba2
{
    partial class PubHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PubHouse));
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isPrivate = new System.Windows.Forms.RadioButton();
            this.isPublic = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SavePub = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.YearBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(123, 31);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(129, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(123, 75);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(127, 21);
            this.CountryBox.TabIndex = 2;
            this.CountryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryBox_KeyPress);
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(123, 129);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(128, 20);
            this.CityBox.TabIndex = 3;
            this.CityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(123, 176);
            this.YearBox.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearBox.Minimum = new decimal(new int[] {
            1750,
            0,
            0,
            0});
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(129, 20);
            this.YearBox.TabIndex = 4;
            this.YearBox.Value = new decimal(new int[] {
            1750,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isPrivate);
            this.groupBox1.Controls.Add(this.isPublic);
            this.groupBox1.Location = new System.Drawing.Point(38, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Публичное или государственное";
            // 
            // isPrivate
            // 
            this.isPrivate.AutoSize = true;
            this.isPrivate.Location = new System.Drawing.Point(59, 54);
            this.isPrivate.Name = "isPrivate";
            this.isPrivate.Size = new System.Drawing.Size(113, 17);
            this.isPrivate.TabIndex = 1;
            this.isPrivate.TabStop = true;
            this.isPrivate.Text = "Государственное";
            this.isPrivate.UseVisualStyleBackColor = true;
            // 
            // isPublic
            // 
            this.isPublic.AutoSize = true;
            this.isPublic.Location = new System.Drawing.Point(59, 31);
            this.isPublic.Name = "isPublic";
            this.isPublic.Size = new System.Drawing.Size(79, 17);
            this.isPublic.TabIndex = 0;
            this.isPublic.TabStop = true;
            this.isPublic.Text = "Публичное";
            this.isPublic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Страна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Год основания";
            // 
            // SavePub
            // 
            this.SavePub.Location = new System.Drawing.Point(39, 364);
            this.SavePub.Name = "SavePub";
            this.SavePub.Size = new System.Drawing.Size(213, 58);
            this.SavePub.TabIndex = 6;
            this.SavePub.Text = "Сохранить";
            this.SavePub.UseVisualStyleBackColor = true;
            this.SavePub.Click += new System.EventHandler(this.SavePub_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // PubHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 434);
            this.Controls.Add(this.SavePub);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PubHouse";
            this.Text = "Добавить издательство";
            this.Load += new System.EventHandler(this.PubHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.NumericUpDown YearBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton isPrivate;
        private System.Windows.Forms.RadioButton isPublic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button SavePub;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}