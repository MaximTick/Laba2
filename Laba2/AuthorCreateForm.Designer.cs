namespace Laba2
{
    partial class AuthorCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorCreateForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveAuthor = new System.Windows.Forms.Button();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Man = new System.Windows.Forms.RadioButton();
            this.Sex = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Sex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(75, 46);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(212, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // SaveAuthor
            // 
            this.SaveAuthor.Location = new System.Drawing.Point(15, 233);
            this.SaveAuthor.Name = "SaveAuthor";
            this.SaveAuthor.Size = new System.Drawing.Size(272, 44);
            this.SaveAuthor.TabIndex = 5;
            this.SaveAuthor.Text = "Сохранить";
            this.SaveAuthor.UseVisualStyleBackColor = true;
            this.SaveAuthor.Click += new System.EventHandler(this.SaveAuthor_Click);
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Location = new System.Drawing.Point(60, 42);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(72, 17);
            this.Woman.TabIndex = 4;
            this.Woman.TabStop = true;
            this.Woman.Text = "Женский";
            this.Woman.UseVisualStyleBackColor = true;
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(60, 19);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(71, 17);
            this.Man.TabIndex = 3;
            this.Man.TabStop = true;
            this.Man.Text = "Мужской";
            this.Man.UseVisualStyleBackColor = true;
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.Man);
            this.Sex.Controls.Add(this.Woman);
            this.Sex.Location = new System.Drawing.Point(15, 103);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(272, 74);
            this.Sex.TabIndex = 2;
            this.Sex.TabStop = false;
            this.Sex.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна";
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(75, 76);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(212, 21);
            this.CountryBox.TabIndex = 1;
            this.CountryBox.Click += new System.EventHandler(this.CountryBox_Click);
            this.CountryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(Laba2.Author);
            // 
            // authorBindingSource2
            // 
            this.authorBindingSource2.DataSource = typeof(Laba2.Author);
            // 
            // authorBindingSource1
            // 
            this.authorBindingSource1.DataSource = typeof(Laba2.Author);
            // 
            // AuthorCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 289);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.SaveAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorCreateForm";
            this.Text = "Добавить автора";
            this.Load += new System.EventHandler(this.AuthorCreateForm_Load);
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAuthor;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.GroupBox Sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.BindingSource authorBindingSource1;
        private System.Windows.Forms.BindingSource authorBindingSource2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}