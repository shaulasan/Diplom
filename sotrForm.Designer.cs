namespace demo_proj
{
    partial class sotrForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_but = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.idOtd_tb = new System.Windows.Forms.TextBox();
            this.dolj_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Отдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Руководитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Электронная_почта_отдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "поиск";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 30);
            this.textBox1.TabIndex = 54;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add_but
            // 
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_but.Location = new System.Drawing.Point(674, 549);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(114, 30);
            this.add_but.TabIndex = 53;
            this.add_but.Text = "добавить";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(236, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "фамилия имя отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(117, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "id отдела";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "id сотрудника";
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_but.Location = new System.Drawing.Point(674, 513);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(114, 30);
            this.del_but.TabIndex = 48;
            this.del_but.Text = "удалить";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save_but.Location = new System.Drawing.Point(674, 477);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(114, 30);
            this.save_but.TabIndex = 47;
            this.save_but.Text = "сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // fio_tb
            // 
            this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fio_tb.Location = new System.Drawing.Point(206, 477);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(462, 30);
            this.fio_tb.TabIndex = 46;
            // 
            // idOtd_tb
            // 
            this.idOtd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idOtd_tb.Location = new System.Drawing.Point(106, 477);
            this.idOtd_tb.Name = "idOtd_tb";
            this.idOtd_tb.Size = new System.Drawing.Size(94, 30);
            this.idOtd_tb.TabIndex = 45;
            // 
            // dolj_tb
            // 
            this.dolj_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dolj_tb.Location = new System.Drawing.Point(15, 537);
            this.dolj_tb.Name = "dolj_tb";
            this.dolj_tb.Size = new System.Drawing.Size(653, 30);
            this.dolj_tb.TabIndex = 44;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_tb.Location = new System.Drawing.Point(12, 477);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(88, 30);
            this.id_tb.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Отдела,
            this.Название,
            this.Руководитель,
            this.Электронная_почта_отдела});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_Отдела
            // 
            this.ID_Отдела.HeaderText = "id сотрудника";
            this.ID_Отдела.Name = "ID_Отдела";
            this.ID_Отдела.ReadOnly = true;
            // 
            // Название
            // 
            this.Название.HeaderText = "фио";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Руководитель
            // 
            this.Руководитель.HeaderText = "должность";
            this.Руководитель.Name = "Руководитель";
            this.Руководитель.ReadOnly = true;
            // 
            // Электронная_почта_отдела
            // 
            this.Электронная_почта_отдела.HeaderText = "id отдела";
            this.Электронная_почта_отдела.Name = "Электронная_почта_отдела";
            this.Электронная_почта_отдела.ReadOnly = true;
            // 
            // sotrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.fio_tb);
            this.Controls.Add(this.idOtd_tb);
            this.Controls.Add(this.dolj_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sotrForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.sotrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.TextBox fio_tb;
        private System.Windows.Forms.TextBox idOtd_tb;
        private System.Windows.Forms.TextBox dolj_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Отдела;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Руководитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Электронная_почта_отдела;
    }
}