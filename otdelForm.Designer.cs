namespace demo_proj
{
    partial class otdelForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Отдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Руководитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Электронная_почта_отдела = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.ruc_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.add_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_Отдела
            // 
            this.ID_Отдела.HeaderText = "id отдела";
            this.ID_Отдела.Name = "ID_Отдела";
            this.ID_Отдела.ReadOnly = true;
            // 
            // Название
            // 
            this.Название.HeaderText = "название";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Руководитель
            // 
            this.Руководитель.HeaderText = "руководитель";
            this.Руководитель.Name = "Руководитель";
            this.Руководитель.ReadOnly = true;
            // 
            // Электронная_почта_отдела
            // 
            this.Электронная_почта_отдела.HeaderText = "эл. почта отдела";
            this.Электронная_почта_отдела.Name = "Электронная_почта_отдела";
            this.Электронная_почта_отдела.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(405, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "эл. почта отдела";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(103, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "руководитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "id отдела";
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_but.Location = new System.Drawing.Point(674, 513);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(114, 30);
            this.del_but.TabIndex = 24;
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
            this.save_but.TabIndex = 23;
            this.save_but.Text = "сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // email_tb
            // 
            this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.email_tb.Location = new System.Drawing.Point(408, 477);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(260, 30);
            this.email_tb.TabIndex = 22;
            // 
            // ruc_tb
            // 
            this.ruc_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ruc_tb.Location = new System.Drawing.Point(106, 477);
            this.ruc_tb.Name = "ruc_tb";
            this.ruc_tb.Size = new System.Drawing.Size(296, 30);
            this.ruc_tb.TabIndex = 21;
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_tb.Location = new System.Drawing.Point(15, 537);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(653, 30);
            this.name_tb.TabIndex = 20;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_tb.Location = new System.Drawing.Point(12, 477);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(88, 30);
            this.id_tb.TabIndex = 19;
            // 
            // add_but
            // 
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_but.Location = new System.Drawing.Point(674, 549);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(114, 30);
            this.add_but.TabIndex = 29;
            this.add_but.Text = "добавить";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 30);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "поиск";
            // 
            // otdelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.ruc_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "otdelForm";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.otdelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Отдела;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Руководитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Электронная_почта_отдела;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox ruc_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}