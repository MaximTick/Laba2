namespace Laba2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CreateBook = new System.Windows.Forms.Button();
            this.SaveInFile = new System.Windows.Forms.Button();
            this.ReadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateBook
            // 
            this.CreateBook.Location = new System.Drawing.Point(35, 23);
            this.CreateBook.Name = "CreateBook";
            this.CreateBook.Size = new System.Drawing.Size(173, 63);
            this.CreateBook.TabIndex = 2;
            this.CreateBook.Text = "Добавить книгу";
            this.CreateBook.UseVisualStyleBackColor = true;
            this.CreateBook.Click += new System.EventHandler(this.CreateBook_Click);
            // 
            // SaveInFile
            // 
            this.SaveInFile.Location = new System.Drawing.Point(35, 104);
            this.SaveInFile.Name = "SaveInFile";
            this.SaveInFile.Size = new System.Drawing.Size(173, 63);
            this.SaveInFile.TabIndex = 2;
            this.SaveInFile.Text = "Сохранить в файл";
            this.SaveInFile.UseVisualStyleBackColor = true;
            this.SaveInFile.Click += new System.EventHandler(this.SaveInFileMeth);
            // 
            // ReadFromFile
            // 
            this.ReadFromFile.Location = new System.Drawing.Point(35, 187);
            this.ReadFromFile.Name = "ReadFromFile";
            this.ReadFromFile.Size = new System.Drawing.Size(173, 63);
            this.ReadFromFile.TabIndex = 2;
            this.ReadFromFile.Text = "Показать список книг";
            this.ReadFromFile.UseVisualStyleBackColor = true;
            this.ReadFromFile.Click += new System.EventHandler(this.ReadFromFileMet);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 272);
            this.Controls.Add(this.ReadFromFile);
            this.Controls.Add(this.SaveInFile);
            this.Controls.Add(this.CreateBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateBook;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Button ReadFromFile;
    }
}

