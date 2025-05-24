namespace demo_proj
{
    partial class povForm
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
            this.add_but = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.del_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.dateStart_tb = new System.Windows.Forms.TextBox();
            this.dateEnd_tb = new System.Windows.Forms.TextBox();
            this.idOb_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Обучения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеКурса = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаНачала = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаОкончания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Организация = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.org_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_but
            // 
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_but.Location = new System.Drawing.Point(671, 619);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(114, 30);
            this.add_but.TabIndex = 33;
            this.add_but.Text = "добавить";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(206, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "дата начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(441, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "дата конца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(101, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "id сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "id обучения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "название курса";
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_tb.Location = new System.Drawing.Point(9, 547);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(656, 30);
            this.name_tb.TabIndex = 27;
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_but.Location = new System.Drawing.Point(671, 583);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(114, 30);
            this.del_but.TabIndex = 26;
            this.del_but.Text = "удалить";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save_but.Location = new System.Drawing.Point(671, 547);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(114, 30);
            this.save_but.TabIndex = 25;
            this.save_but.Text = "сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // dateStart_tb
            // 
            this.dateStart_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateStart_tb.Location = new System.Drawing.Point(203, 477);
            this.dateStart_tb.Name = "dateStart_tb";
            this.dateStart_tb.Size = new System.Drawing.Size(235, 30);
            this.dateStart_tb.TabIndex = 24;
            // 
            // dateEnd_tb
            // 
            this.dateEnd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateEnd_tb.Location = new System.Drawing.Point(444, 477);
            this.dateEnd_tb.Name = "dateEnd_tb";
            this.dateEnd_tb.Size = new System.Drawing.Size(221, 30);
            this.dateEnd_tb.TabIndex = 23;
            // 
            // idOb_tb
            // 
            this.idOb_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idOb_tb.Location = new System.Drawing.Point(9, 477);
            this.idOb_tb.Name = "idOb_tb";
            this.idOb_tb.ReadOnly = true;
            this.idOb_tb.Size = new System.Drawing.Size(88, 30);
            this.idOb_tb.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Обучения,
            this.ID_Сотрудника,
            this.НазваниеКурса,
            this.ДатаНачала,
            this.ДатаОкончания,
            this.Организация});
            this.dataGridView1.Location = new System.Drawing.Point(9, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_Обучения
            // 
            this.ID_Обучения.HeaderText = "ID обучения";
            this.ID_Обучения.Name = "ID_Обучения";
            this.ID_Обучения.ReadOnly = true;
            // 
            // ID_Сотрудника
            // 
            this.ID_Сотрудника.HeaderText = "ID сотрудника";
            this.ID_Сотрудника.Name = "ID_Сотрудника";
            this.ID_Сотрудника.ReadOnly = true;
            // 
            // НазваниеКурса
            // 
            this.НазваниеКурса.HeaderText = "название курса";
            this.НазваниеКурса.Name = "НазваниеКурса";
            this.НазваниеКурса.ReadOnly = true;
            // 
            // ДатаНачала
            // 
            this.ДатаНачала.HeaderText = "дата начала";
            this.ДатаНачала.Name = "ДатаНачала";
            this.ДатаНачала.ReadOnly = true;
            // 
            // ДатаОкончания
            // 
            this.ДатаОкончания.HeaderText = "дата окончания";
            this.ДатаОкончания.Name = "ДатаОкончания";
            this.ДатаОкончания.ReadOnly = true;
            // 
            // Организация
            // 
            this.Организация.HeaderText = "организация";
            this.Организация.Name = "Организация";
            this.Организация.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "организация";
            // 
            // org_tb
            // 
            this.org_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.org_tb.Location = new System.Drawing.Point(12, 600);
            this.org_tb.Name = "org_tb";
            this.org_tb.Size = new System.Drawing.Size(656, 30);
            this.org_tb.TabIndex = 34;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_tb.Location = new System.Drawing.Point(103, 477);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(88, 30);
            this.id_tb.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(773, 30);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(21, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "поиск";
            // 
            // povForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.org_tb);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.dateStart_tb);
            this.Controls.Add(this.dateEnd_tb);
            this.Controls.Add(this.idOb_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "povForm";
            this.Text = "Повышение квалификации";
            this.Load += new System.EventHandler(this.povForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.TextBox dateStart_tb;
        private System.Windows.Forms.TextBox dateEnd_tb;
        private System.Windows.Forms.TextBox idOb_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox org_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Обучения;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеКурса;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаНачала;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаОкончания;
        private System.Windows.Forms.DataGridViewTextBoxColumn Организация;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}