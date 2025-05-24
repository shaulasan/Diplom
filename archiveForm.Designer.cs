namespace demo_proj
{
    partial class archiveForm
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
            this.ID_Документа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НазваниеДокумента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаСоздания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.date_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idDoc_tb = new System.Windows.Forms.TextBox();
            this.add_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Документа,
            this.НазваниеДокумента,
            this.ДатаСоздания,
            this.Описание,
            this.ID_Сотрудника});
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_Документа
            // 
            this.ID_Документа.HeaderText = "ID документа";
            this.ID_Документа.Name = "ID_Документа";
            this.ID_Документа.ReadOnly = true;
            // 
            // НазваниеДокумента
            // 
            this.НазваниеДокумента.HeaderText = "название документа";
            this.НазваниеДокумента.Name = "НазваниеДокумента";
            this.НазваниеДокумента.ReadOnly = true;
            // 
            // ДатаСоздания
            // 
            this.ДатаСоздания.HeaderText = "дата создания";
            this.ДатаСоздания.Name = "ДатаСоздания";
            this.ДатаСоздания.ReadOnly = true;
            // 
            // Описание
            // 
            this.Описание.HeaderText = "описание";
            this.Описание.Name = "Описание";
            this.Описание.ReadOnly = true;
            // 
            // ID_Сотрудника
            // 
            this.ID_Сотрудника.HeaderText = "ID сотрудника";
            this.ID_Сотрудника.Name = "ID_Сотрудника";
            this.ID_Сотрудника.ReadOnly = true;
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_but.Location = new System.Drawing.Point(674, 494);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(114, 30);
            this.del_but.TabIndex = 12;
            this.del_but.Text = "удалить";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save_but.Location = new System.Drawing.Point(674, 458);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(114, 30);
            this.save_but.TabIndex = 11;
            this.save_but.Text = "сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_tb.Location = new System.Drawing.Point(566, 458);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(102, 30);
            this.id_tb.TabIndex = 10;
            // 
            // date_tb
            // 
            this.date_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.date_tb.Location = new System.Drawing.Point(372, 458);
            this.date_tb.Name = "date_tb";
            this.date_tb.Size = new System.Drawing.Size(188, 30);
            this.date_tb.TabIndex = 9;
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name_tb.Location = new System.Drawing.Point(106, 458);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(260, 30);
            this.name_tb.TabIndex = 8;
            // 
            // desc_tb
            // 
            this.desc_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.desc_tb.Location = new System.Drawing.Point(12, 528);
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(656, 30);
            this.desc_tb.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "id документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(154, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "название документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(416, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "дата создания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(563, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "id сотрудника";
            // 
            // idDoc_tb
            // 
            this.idDoc_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idDoc_tb.Location = new System.Drawing.Point(12, 458);
            this.idDoc_tb.Name = "idDoc_tb";
            this.idDoc_tb.ReadOnly = true;
            this.idDoc_tb.Size = new System.Drawing.Size(88, 30);
            this.idDoc_tb.TabIndex = 7;
            // 
            // add_but
            // 
            this.add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add_but.Location = new System.Drawing.Point(674, 530);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(114, 30);
            this.add_but.TabIndex = 19;
            this.add_but.Text = "добавить";
            this.add_but.UseVisualStyleBackColor = true;
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(782, 30);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "поиск";
            // 
            // archiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.date_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.idDoc_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "archiveForm";
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.archiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Документа;
        private System.Windows.Forms.DataGridViewTextBoxColumn НазваниеДокумента;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаСоздания;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Сотрудника;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox date_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idDoc_tb;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}