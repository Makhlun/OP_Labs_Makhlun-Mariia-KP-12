
namespace Lab1
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.Backing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Specialization = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.IDdel = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Puples = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NameDel = new System.Windows.Forms.TextBox();
            this.SurnameDel = new System.Windows.Forms.TextBox();
            this.SexDel = new System.Windows.Forms.TextBox();
            this.SpecDel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Backing
            // 
            this.Backing.BackColor = System.Drawing.Color.LavenderBlush;
            this.Backing.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Backing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backing.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backing.Location = new System.Drawing.Point(784, 343);
            this.Backing.Name = "Backing";
            this.Backing.Size = new System.Drawing.Size(250, 95);
            this.Backing.TabIndex = 0;
            this.Backing.Text = "Back to Main Menu";
            this.Backing.UseVisualStyleBackColor = false;
            this.Backing.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Specialization";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(3, 117);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(88, 34);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.NameTextBox.Location = new System.Drawing.Point(97, 117);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(154, 35);
            this.NameTextBox.TabIndex = 8;
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.Surname.Location = new System.Drawing.Point(257, 116);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(167, 35);
            this.Surname.TabIndex = 9;
            this.Surname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Sex
            // 
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex.Location = new System.Drawing.Point(430, 115);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(108, 37);
            this.Sex.TabIndex = 10;
            this.Sex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Specialization
            // 
            this.Specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Specialization.FormattingEnabled = true;
            this.Specialization.Items.AddRange(new object[] {
            "121",
            "122",
            "123",
            "113",
            "125"});
            this.Specialization.Location = new System.Drawing.Point(544, 115);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(188, 37);
            this.Specialization.TabIndex = 11;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Add.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(738, 111);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(185, 44);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // IDdel
            // 
            this.IDdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDdel.FormattingEnabled = true;
            this.IDdel.Location = new System.Drawing.Point(3, 169);
            this.IDdel.Name = "IDdel";
            this.IDdel.Size = new System.Drawing.Size(88, 37);
            this.IDdel.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(738, 169);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(185, 44);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Puples
            // 
            this.Puples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puples.FormattingEnabled = true;
            this.Puples.ItemHeight = 25;
            this.Puples.Location = new System.Drawing.Point(3, 226);
            this.Puples.Name = "Puples";
            this.Puples.Size = new System.Drawing.Size(729, 204);
            this.Puples.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add to FILE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NameDel
            // 
            this.NameDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.NameDel.Location = new System.Drawing.Point(97, 169);
            this.NameDel.Name = "NameDel";
            this.NameDel.Size = new System.Drawing.Size(154, 35);
            this.NameDel.TabIndex = 21;
            // 
            // SurnameDel
            // 
            this.SurnameDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.SurnameDel.Location = new System.Drawing.Point(257, 168);
            this.SurnameDel.Name = "SurnameDel";
            this.SurnameDel.Size = new System.Drawing.Size(167, 35);
            this.SurnameDel.TabIndex = 22;
            // 
            // SexDel
            // 
            this.SexDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexDel.Location = new System.Drawing.Point(430, 169);
            this.SexDel.Name = "SexDel";
            this.SexDel.Size = new System.Drawing.Size(108, 34);
            this.SexDel.TabIndex = 23;
            // 
            // SpecDel
            // 
            this.SpecDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecDel.Location = new System.Drawing.Point(544, 170);
            this.SpecDel.Name = "SpecDel";
            this.SpecDel.Size = new System.Drawing.Size(188, 34);
            this.SpecDel.TabIndex = 24;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1046, 451);
            this.Controls.Add(this.SpecDel);
            this.Controls.Add(this.SexDel);
            this.Controls.Add(this.SurnameDel);
            this.Controls.Add(this.NameDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Puples);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.IDdel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backing);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox Specialization;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox IDdel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox Puples;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameDel;
        private System.Windows.Forms.TextBox SurnameDel;
        private System.Windows.Forms.TextBox SexDel;
        private System.Windows.Forms.TextBox SpecDel;
    }
}

