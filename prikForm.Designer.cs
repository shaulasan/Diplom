namespace demo_proj
{
    partial class prikForm
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
            this.del_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.nom_tb = new System.Windows.Forms.TextBox();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.idPrik_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Отдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Руководитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Электронная_почта_отдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.type_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_but
            // 
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_but.Location = new System.Drawing.Point(677, 531);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(114, 30);
            this.add_but.TabIndex = 41;
            this.add_but.Text = "добавить";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(418, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "дата приказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(276, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "номер приказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "id приказа";
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_but.Location = new System.Drawing.Point(677, 495);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(114, 30);
            this.del_but.TabIndex = 36;
            this.del_but.Text = "удалить";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save_but.Location = new System.Drawing.Point(677, 459);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(114, 30);
            this.save_but.TabIndex = 35;
            this.save_but.Text = "сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // date_tb
            // 
            this.date_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.date_tb.Location = new System.Drawing.Point(389, 457);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(224, 30);
            this.date_tb.TabIndex = 34;
            // 
            // nom_tb
            // 
            this.nom_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nom_tb.Location = new System.Drawing.Point(279, 457);
            this.nom_tb.Name = "nom_tb";
            this.nom_tb.Size = new System.Drawing.Size(104, 30);
            this.nom_tb.TabIndex = 33;
            // 
            // desc_tb
            // 
            this.desc_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.desc_tb.Location = new System.Drawing.Point(15, 578);
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(653, 30);
            this.desc_tb.TabIndex = 32;
            // 
            // idPrik_tb
            // 
            this.idPrik_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idPrik_tb.Location = new System.Drawing.Point(15, 459);
            this.idPrik_tb.Name = "idPrik_tb";
            this.idPrik_tb.ReadOnly = true;
            this.idPrik_tb.Size = new System.Drawing.Size(88, 30);
            this.idPrik_tb.TabIndex = 31;
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
            this.Электронная_почта_отдела,
            this.описание,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(15, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_Отдела
            // 
            this.ID_Отдела.HeaderText = "id приказа";
            this.ID_Отдела.Name = "ID_Отдела";
            this.ID_Отдела.ReadOnly = true;
            // 
            // Название
            // 
            this.Название.HeaderText = "номер приказа";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Руководитель
            // 
            this.Руководитель.HeaderText = "дата приказа";
            this.Руководитель.Name = "Руководитель";
            this.Руководитель.ReadOnly = true;
            // 
            // Электронная_почта_отдела
            // 
            this.Электронная_почта_отдела.HeaderText = "тип приказа";
            this.Электронная_почта_отдела.Name = "Электронная_почта_отдела";
            this.Электронная_почта_отдела.ReadOnly = true;
            // 
            // описание
            // 
            this.описание.HeaderText = "описание";
            this.описание.Name = "описание";
            this.описание.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id сотрудника";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "тип приказа";
            // 
            // type_tb
            // 
            this.type_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.type_tb.Location = new System.Drawing.Point(15, 512);
            this.type_tb.Name = "type_tb";
            this.type_tb.Size = new System.Drawing.Size(301, 30);
            this.type_tb.TabIndex = 42;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_tb.Location = new System.Drawing.Point(140, 459);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(104, 30);
            this.id_tb.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(145, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "id сотрудника";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(18, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(770, 30);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(15, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "поиск";
            // 
            // prikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type_tb);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.nom_tb);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.idPrik_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "prikForm";
            this.Text = "Приказы";
            this.Load += new System.EventHandler(this.prikForm_Load);
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
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.TextBox nom_tb;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.TextBox idPrik_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Отдела;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Руководитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Электронная_почта_отдела;
        private System.Windows.Forms.DataGridViewTextBoxColumn описание;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}