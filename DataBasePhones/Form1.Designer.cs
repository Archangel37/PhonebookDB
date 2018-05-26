namespace DataBasePhones
{
    partial class Form1
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
            this.AddSomeDefault_btn = new System.Windows.Forms.Button();
            this.Human_Name_txt = new System.Windows.Forms.TextBox();
            this.Human_Surename_txt = new System.Windows.Forms.TextBox();
            this.Human_Age_txt = new System.Windows.Forms.TextBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.PhoneNumber_txt = new System.Windows.Forms.TextBox();
            this.Manufacturer_Phone_txt = new System.Windows.Forms.TextBox();
            this.Model_Phone_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.AddRecord_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DelRecord = new System.Windows.Forms.Button();
            this.ShowRecord_btn = new System.Windows.Forms.Button();
            this.label_index = new System.Windows.Forms.Label();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.DropDB_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddSomeDefault_btn
            // 
            this.AddSomeDefault_btn.Location = new System.Drawing.Point(539, 27);
            this.AddSomeDefault_btn.Name = "AddSomeDefault_btn";
            this.AddSomeDefault_btn.Size = new System.Drawing.Size(138, 23);
            this.AddSomeDefault_btn.TabIndex = 0;
            this.AddSomeDefault_btn.Text = "Add Some Default";
            this.AddSomeDefault_btn.UseVisualStyleBackColor = true;
            this.AddSomeDefault_btn.Click += new System.EventHandler(this.DoDefault_btn_Click);
            // 
            // Human_Name_txt
            // 
            this.Human_Name_txt.Location = new System.Drawing.Point(37, 102);
            this.Human_Name_txt.Name = "Human_Name_txt";
            this.Human_Name_txt.Size = new System.Drawing.Size(100, 20);
            this.Human_Name_txt.TabIndex = 1;
            // 
            // Human_Surename_txt
            // 
            this.Human_Surename_txt.Location = new System.Drawing.Point(152, 102);
            this.Human_Surename_txt.Name = "Human_Surename_txt";
            this.Human_Surename_txt.Size = new System.Drawing.Size(286, 20);
            this.Human_Surename_txt.TabIndex = 2;
            // 
            // Human_Age_txt
            // 
            this.Human_Age_txt.Location = new System.Drawing.Point(458, 101);
            this.Human_Age_txt.MaxLength = 2;
            this.Human_Age_txt.Name = "Human_Age_txt";
            this.Human_Age_txt.Size = new System.Drawing.Size(43, 20);
            this.Human_Age_txt.TabIndex = 3;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_Gender.Location = new System.Drawing.Point(517, 99);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Gender.TabIndex = 4;
            // 
            // PhoneNumber_txt
            // 
            this.PhoneNumber_txt.Location = new System.Drawing.Point(37, 147);
            this.PhoneNumber_txt.Name = "PhoneNumber_txt";
            this.PhoneNumber_txt.Size = new System.Drawing.Size(228, 20);
            this.PhoneNumber_txt.TabIndex = 5;
            // 
            // Manufacturer_Phone_txt
            // 
            this.Manufacturer_Phone_txt.Location = new System.Drawing.Point(291, 146);
            this.Manufacturer_Phone_txt.Name = "Manufacturer_Phone_txt";
            this.Manufacturer_Phone_txt.Size = new System.Drawing.Size(160, 20);
            this.Manufacturer_Phone_txt.TabIndex = 6;
            // 
            // Model_Phone_txt
            // 
            this.Model_Phone_txt.Location = new System.Drawing.Point(291, 183);
            this.Model_Phone_txt.Name = "Model_Phone_txt";
            this.Model_Phone_txt.Size = new System.Drawing.Size(160, 20);
            this.Model_Phone_txt.TabIndex = 6;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(37, 233);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(228, 20);
            this.Email_txt.TabIndex = 5;
            // 
            // AddRecord_btn
            // 
            this.AddRecord_btn.Location = new System.Drawing.Point(481, 233);
            this.AddRecord_btn.Name = "AddRecord_btn";
            this.AddRecord_btn.Size = new System.Drawing.Size(75, 23);
            this.AddRecord_btn.TabIndex = 7;
            this.AddRecord_btn.Text = "Add Record";
            this.AddRecord_btn.UseVisualStyleBackColor = true;
            this.AddRecord_btn.Click += new System.EventHandler(this.AddRecord_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Manufacturer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "E-mail";
            // 
            // DelRecord
            // 
            this.DelRecord.Location = new System.Drawing.Point(400, 233);
            this.DelRecord.Name = "DelRecord";
            this.DelRecord.Size = new System.Drawing.Size(75, 23);
            this.DelRecord.TabIndex = 9;
            this.DelRecord.Text = "Del Record";
            this.DelRecord.UseVisualStyleBackColor = true;
            // 
            // ShowRecord_btn
            // 
            this.ShowRecord_btn.Location = new System.Drawing.Point(39, 289);
            this.ShowRecord_btn.Name = "ShowRecord_btn";
            this.ShowRecord_btn.Size = new System.Drawing.Size(75, 23);
            this.ShowRecord_btn.TabIndex = 10;
            this.ShowRecord_btn.Text = "Show Record";
            this.ShowRecord_btn.UseVisualStyleBackColor = true;
            this.ShowRecord_btn.Click += new System.EventHandler(this.ShowRecord_btn_Click);
            // 
            // label_index
            // 
            this.label_index.AutoSize = true;
            this.label_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_index.Location = new System.Drawing.Point(175, 27);
            this.label_index.Name = "label_index";
            this.label_index.Size = new System.Drawing.Size(40, 42);
            this.label_index.TabIndex = 11;
            this.label_index.Text = "1";
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(94, 30);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 39);
            this.button_prev.TabIndex = 12;
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(264, 30);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 39);
            this.button_next.TabIndex = 12;
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // DropDB_btn
            // 
            this.DropDB_btn.Location = new System.Drawing.Point(435, 27);
            this.DropDB_btn.Name = "DropDB_btn";
            this.DropDB_btn.Size = new System.Drawing.Size(75, 23);
            this.DropDB_btn.TabIndex = 13;
            this.DropDB_btn.Text = "Drop Data";
            this.DropDB_btn.UseVisualStyleBackColor = true;
            this.DropDB_btn.Click += new System.EventHandler(this.DropDB_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 475);
            this.Controls.Add(this.DropDB_btn);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.label_index);
            this.Controls.Add(this.ShowRecord_btn);
            this.Controls.Add(this.DelRecord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRecord_btn);
            this.Controls.Add(this.Model_Phone_txt);
            this.Controls.Add(this.Manufacturer_Phone_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.PhoneNumber_txt);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.Human_Age_txt);
            this.Controls.Add(this.Human_Surename_txt);
            this.Controls.Add(this.Human_Name_txt);
            this.Controls.Add(this.AddSomeDefault_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSomeDefault_btn;
        private System.Windows.Forms.TextBox Human_Name_txt;
        private System.Windows.Forms.TextBox Human_Surename_txt;
        private System.Windows.Forms.TextBox Human_Age_txt;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox PhoneNumber_txt;
        private System.Windows.Forms.TextBox Manufacturer_Phone_txt;
        private System.Windows.Forms.TextBox Model_Phone_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Button AddRecord_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DelRecord;
        private System.Windows.Forms.Button ShowRecord_btn;
        private System.Windows.Forms.Label label_index;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button DropDB_btn;
    }
}

