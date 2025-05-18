namespace OOP_Taxi_23VP2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.PhoneNumber,
            this.CarInfo,
            this.DriverInfo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1279, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус заказа";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефона клиента";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // CarInfo
            // 
            this.CarInfo.HeaderText = "Гос. номер автомобиля ";
            this.CarInfo.MinimumWidth = 6;
            this.CarInfo.Name = "CarInfo";
            this.CarInfo.Width = 125;
            // 
            // DriverInfo
            // 
            this.DriverInfo.HeaderText = "ФИО водителя";
            this.DriverInfo.MinimumWidth = 6;
            this.DriverInfo.Name = "DriverInfo";
            this.DriverInfo.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Добавление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ФИО водителя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Гос. номер автомобиля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Номер телефона клиента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Статус заказа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 477);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 513);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(236, 549);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(236, 585);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(781, 299);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(397, 22);
            this.textBox5.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1103, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Заказан",
            "В пути",
            "Завершен"});
            this.checkedListBox1.Location = new System.Drawing.Point(116, 302);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 72);
            this.checkedListBox1.TabIndex = 14;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1291, 624);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

