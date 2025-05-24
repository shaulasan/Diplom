namespace demo_proj
{
    partial class upravlenieForm
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
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_permissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.log_tb = new System.Windows.Forms.TextBox();
            this.pas_tb = new System.Windows.Forms.TextBox();
            this.per_tb = new System.Windows.Forms.TextBox();
            this.save_but = new System.Windows.Forms.Button();
            this.del_but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_login,
            this.user_password,
            this.user_permissions});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // user_login
            // 
            this.user_login.HeaderText = "логин";
            this.user_login.Name = "user_login";
            this.user_login.ReadOnly = true;
            // 
            // user_password
            // 
            this.user_password.HeaderText = "пароль";
            this.user_password.Name = "user_password";
            this.user_password.ReadOnly = true;
            // 
            // user_permissions
            // 
            this.user_permissions.HeaderText = "уровень доступа";
            this.user_permissions.Name = "user_permissions";
            this.user_permissions.ReadOnly = true;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.id_tb.Location = new System.Drawing.Point(12, 408);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(88, 30);
            this.id_tb.TabIndex = 1;
            // 
            // log_tb
            // 
            this.log_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.log_tb.Location = new System.Drawing.Point(106, 408);
            this.log_tb.Name = "log_tb";
            this.log_tb.Size = new System.Drawing.Size(241, 30);
            this.log_tb.TabIndex = 2;
            // 
            // pas_tb
            // 
            this.pas_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pas_tb.Location = new System.Drawing.Point(353, 408);
            this.pas_tb.Name = "pas_tb";
            this.pas_tb.Size = new System.Drawing.Size(229, 30);
            this.pas_tb.TabIndex = 3;
            // 
            // per_tb
            // 
            this.per_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.per_tb.Location = new System.Drawing.Point(588, 408);
            this.per_tb.Name = "per_tb";
            this.per_tb.Size = new System.Drawing.Size(80, 30);
            this.per_tb.TabIndex = 4;
            // 
            // save_but
            // 
            this.save_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save_but.Location = new System.Drawing.Point(674, 408);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(114, 30);
            this.save_but.TabIndex = 5;
            this.save_but.Text = "сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // del_but
            // 
            this.del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.del_but.Location = new System.Drawing.Point(674, 444);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(114, 30);
            this.del_but.TabIndex = 6;
            this.del_but.Text = "удалить";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(113, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(366, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(588, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "ур доступа";
            // 
            // upravlenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.per_tb);
            this.Controls.Add(this.pas_tb);
            this.Controls.Add(this.log_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "upravlenieForm";
            this.Text = "Управление аккаунтами";
            this.Load += new System.EventHandler(this.upravlenieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_permissions;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox log_tb;
        private System.Windows.Forms.TextBox pas_tb;
        private System.Windows.Forms.TextBox per_tb;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Button del_but;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}