namespace Laba2
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatePubHouse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.NumericUpDown();
            this.isCDBox = new System.Windows.Forms.CheckBox();
            this.isDVDBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UKKBar = new System.Windows.Forms.TrackBar();
            this.CreateAuthor = new System.Windows.Forms.Button();
            this.UKKValue = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SaveBook = new System.Windows.Forms.Button();
            this.NumberLbel = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.NumericUpDown();
            this.PubHouseBox = new System.Windows.Forms.TextBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.YearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UKKBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(124, 24);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(164, 20);
            this.TitleBox.TabIndex = 1;
            this.TitleBox.Validating += new System.ComponentModel.CancelEventHandler(this.TitleBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "УДК";
            // 
            // CreatePubHouse
            // 
            this.CreatePubHouse.Location = new System.Drawing.Point(122, 186);
            this.CreatePubHouse.Name = "CreatePubHouse";
            this.CreatePubHouse.Size = new System.Drawing.Size(75, 23);
            this.CreatePubHouse.TabIndex = 5;
            this.CreatePubHouse.Text = "Добавить";
            this.CreatePubHouse.UseVisualStyleBackColor = true;
            this.CreatePubHouse.Click += new System.EventHandler(this.CreatePubHouse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Издательство";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(122, 215);
            this.YearBox.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.YearBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(165, 20);
            this.YearBox.TabIndex = 6;
            this.YearBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // isCDBox
            // 
            this.isCDBox.AutoSize = true;
            this.isCDBox.Location = new System.Drawing.Point(123, 241);
            this.isCDBox.Name = "isCDBox";
            this.isCDBox.Size = new System.Drawing.Size(50, 17);
            this.isCDBox.TabIndex = 7;
            this.isCDBox.Text = "Есть";
            this.isCDBox.UseVisualStyleBackColor = true;
            // 
            // isDVDBox
            // 
            this.isDVDBox.AutoSize = true;
            this.isDVDBox.Location = new System.Drawing.Point(123, 264);
            this.isDVDBox.Name = "isDVDBox";
            this.isDVDBox.Size = new System.Drawing.Size(50, 17);
            this.isDVDBox.TabIndex = 8;
            this.isDVDBox.Text = "Есть";
            this.isDVDBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Год издания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Наличие CD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Наличие DVD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Автор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Дата написания";
            // 
            // UKKBar
            // 
            this.UKKBar.Location = new System.Drawing.Point(122, 50);
            this.UKKBar.Maximum = 9;
            this.UKKBar.Name = "UKKBar";
            this.UKKBar.Size = new System.Drawing.Size(164, 45);
            this.UKKBar.TabIndex = 10;
            this.UKKBar.Scroll += new System.EventHandler(this.UKKBar_Scroll);
            this.UKKBar.ValueChanged += new System.EventHandler(this.Va);
            // 
            // CreateAuthor
            // 
            this.CreateAuthor.Location = new System.Drawing.Point(124, 341);
            this.CreateAuthor.Name = "CreateAuthor";
            this.CreateAuthor.Size = new System.Drawing.Size(75, 23);
            this.CreateAuthor.TabIndex = 5;
            this.CreateAuthor.Text = "Добавить";
            this.CreateAuthor.UseVisualStyleBackColor = true;
            this.CreateAuthor.Click += new System.EventHandler(this.CreateAuthor_Click);
            // 
            // UKKValue
            // 
            this.UKKValue.AutoSize = true;
            this.UKKValue.Location = new System.Drawing.Point(294, 61);
            this.UKKValue.Name = "UKKValue";
            this.UKKValue.Size = new System.Drawing.Size(55, 13);
            this.UKKValue.TabIndex = 0;
            this.UKKValue.Text = "Значение";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // SaveBook
            // 
            this.SaveBook.Location = new System.Drawing.Point(124, 433);
            this.SaveBook.Name = "SaveBook";
            this.SaveBook.Size = new System.Drawing.Size(190, 57);
            this.SaveBook.TabIndex = 12;
            this.SaveBook.Text = "Добавить";
            this.SaveBook.UseVisualStyleBackColor = true;
            this.SaveBook.Click += new System.EventHandler(this.SaveBook_Click);
            // 
            // NumberLbel
            // 
            this.NumberLbel.AutoSize = true;
            this.NumberLbel.Location = new System.Drawing.Point(12, 103);
            this.NumberLbel.Name = "NumberLbel";
            this.NumberLbel.Size = new System.Drawing.Size(110, 13);
            this.NumberLbel.TabIndex = 2;
            this.NumberLbel.Text = "Количество страниц";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(123, 101);
            this.NumberBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(164, 20);
            this.NumberBox.TabIndex = 6;
            this.NumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PubHouseBox
            // 
            this.PubHouseBox.Enabled = false;
            this.PubHouseBox.Location = new System.Drawing.Point(124, 132);
            this.PubHouseBox.Multiline = true;
            this.PubHouseBox.Name = "PubHouseBox";
            this.PubHouseBox.Size = new System.Drawing.Size(265, 48);
            this.PubHouseBox.TabIndex = 13;
            // 
            // AuthorBox
            // 
            this.AuthorBox.Enabled = false;
            this.AuthorBox.Location = new System.Drawing.Point(122, 287);
            this.AuthorBox.Multiline = true;
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(266, 48);
            this.AuthorBox.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 502);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.PubHouseBox);
            this.Controls.Add(this.SaveBook);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.UKKBar);
            this.Controls.Add(this.isDVDBox);
            this.Controls.Add(this.isCDBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.CreateAuthor);
            this.Controls.Add(this.CreatePubHouse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberLbel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.UKKValue);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.Text = "Добавить книгу";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UKKBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreatePubHouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown YearBox;
        private System.Windows.Forms.CheckBox isCDBox;
        private System.Windows.Forms.CheckBox isDVDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar UKKBar;
        private System.Windows.Forms.Button CreateAuthor;
        private System.Windows.Forms.Label UKKValue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SaveBook;
        private System.Windows.Forms.Label NumberLbel;
        private System.Windows.Forms.NumericUpDown NumberBox;
        public System.Windows.Forms.TextBox PubHouseBox;
        public System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}